using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RuRay.API.Middleware;
using RuRay.API.Models;
using RuRay.API.Swagger;
using RuRayFacebook.App.LoggedIn.Pages;
using Serilog;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RuRay.API
{
    /// <summary>
    /// Defines the <see cref="Startup" />.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/>.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the Configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// The ConfigureServices.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            var appSettings = appSettingsSection.Get<AppSettings>();

            // Adding this code to open the browser, and redirect to the default url defined in the app.config
            PageHome pageHome = new PageHome();

            services.AddControllers();

            services.AddWebServices(
                BLLOptionsSection: Configuration.GetSection("AppSettings"),
                DALOptionSection: Configuration.GetSection("ConnectionStrings")
            );

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddHttpClient();

            services.AddVersionedApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'VVV";

                // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                // can also be used to control the format of the API version in route templates
                opt.SubstituteApiVersionInUrl = true;
            });

            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new UrlSegmentApiVersionReader();
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder
                    .WithOrigins(appSettings.AllowedOrigins)
                    .AllowCredentials());
            });

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen(opt =>
            {
                opt.ExampleFilters();

                var xmlPath = GetXmlDataAnnotationFilePath();
                if (!string.IsNullOrEmpty(xmlPath))
                {
                    opt.IncludeXmlComments(xmlPath);
                }

                opt.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Authorization header. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                opt.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            var key = Encoding.ASCII.GetBytes(appSettings.JwtSecretKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(cfg => { cfg.SlidingExpiration = true; })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });

            services.AddSwaggerExamplesFromAssemblyOf<Program>();

            var logger = new LoggerConfiguration()
               .Enrich.FromLogContext()
               .ReadFrom.Configuration(Configuration);

            Log.Logger = logger.CreateLogger();
            Log.Information("web api service is started.");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="app">The app<see cref="IApplicationBuilder"/>.</param>
        /// <param name="env">The env<see cref="IWebHostEnvironment"/>.</param>
        /// <param name="provider">The provider<see cref="IApiVersionDescriptionProvider"/>.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();

            // Make sure you call this before calling app.UseMvc()
            app.UseCors(
                options => options.WithOrigins("http://localhost:5055").AllowAnyMethod()
            );

            app.UseCors("AllowSpecificOrigin");

            app.UseHttpContextMiddleware();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                foreach (var description in provider.ApiVersionDescriptions.OrderByDescending(o => o.GroupName))
                {
                    c.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseWebServices();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /// <summary>
        /// The GetXmlDataAnnotationFilePath.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        private string GetXmlDataAnnotationFilePath()
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            if (!File.Exists(xmlPath))
            {
                return null;
            }

            return xmlPath;
        }
    }
}
