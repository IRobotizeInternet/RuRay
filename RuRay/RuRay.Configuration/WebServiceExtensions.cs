using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polly;
using RuRay.BLL;
using RuRay.BLL.Contracts;
using RuRay.BLL.Models;
using RuRay.BLL.Services;
using RuRay.BLL.Services.Keyboard;
using RuRay.DAL.MySql;
using RuRay.DAL.MySql.Contract;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Defines the <see cref="WebServiceExtensions" />.
    /// </summary>
    public static class WebServiceExtensions
    {
        /// <summary>
        /// The AddWebServices.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        /// <param name="BLLOptionsSection">The BLLOptionsSection<see cref="IConfigurationSection"/>.</param>
        /// <param name="DALOptionSection">The DALOptionSection<see cref="IConfigurationSection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddWebServices(
            this IServiceCollection services,
            IConfigurationSection BLLOptionsSection,
            IConfigurationSection DALOptionSection)
        {
            if (BLLOptionsSection == null)
            {
                throw new ArgumentNullException(nameof(BLLOptionsSection));
            }

            if (DALOptionSection == null)
            {
                throw new ArgumentNullException(nameof(DALOptionSection));
            }

            var bllSettings = BLLOptionsSection.Get<CarsBLLOptions>();

            services.Configure<CarsBLLOptions>(opt =>
            {
                opt.JwtSecretKey = BLLOptionsSection.GetValue<string>("JwtSecretKey");
                opt.WebApiUrl = BLLOptionsSection.GetValue<string>("WebApiUrl");
            });
            services.Configure<CarsMySqlRepositoryOption>(opt =>
            {
                opt.CarsDbConnectionString = DALOptionSection.GetValue<string>("CarsDbConnectionString");
            });

            services.TryAddSingleton<ICarsRepository, CarsRepository>();

            services.TryAddScoped<ICarsService, CarsService>();
            services.TryAddScoped<IServiceHomeHeader, ServiceHomeHeader>();
            services.TryAddScoped<IServiceWindowsScreen, ServiceWindowsScreen>();
            services.TryAddScoped<IJwtTokenService, JwtTokenService>();
            services.TryAddScoped<IServiceKeyboard, ServiceKeyboard>();
            services.TryAddScoped<IServiceMouse, ServiceMouse>();

            services.AddHttpClient();
            services.AddHttpClient<TodosMockProxyService>(c =>
            {
                c.BaseAddress = new Uri(bllSettings.WebApiUrl);
            }).AddTransientHttpErrorPolicy(p =>
                p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(600))
            );

            services.AddHealthChecks()
                .AddCheck<CarsRepository>("CarsRepository")
                .AddCheck<TodosMockProxyService>("TodosMockProxyService");

            return services;
        }

        /// <summary>
        /// The UseWebServices.
        /// </summary>
        /// <param name="app">The app<see cref="IApplicationBuilder"/>.</param>
        /// <returns>The <see cref="IApplicationBuilder"/>.</returns>
        public static IApplicationBuilder UseWebServices(this IApplicationBuilder app)
        {
            app.UseHealthChecks("/api/health", new HealthCheckOptions()
            {
                ResponseWriter = (httpContext, result) =>
                {
                    httpContext.Response.ContentType = "application/json";

                    var json = new JObject(
                        new JProperty("status", result.Status.ToString()),
                        new JProperty("results", new JObject(result.Entries.Select(pair =>
                            new JProperty(pair.Key, new JObject(
                                new JProperty("status", pair.Value.Status.ToString())))))));
                    return httpContext.Response.WriteAsync(
                        json.ToString(Formatting.Indented));
                }
            });

            return app;
        }
    }
}
