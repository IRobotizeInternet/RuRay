using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RuRay.API.Swagger
{
    /// <summary>
    /// Defines the <see cref="ConfigureSwaggerOptions" />.
    /// </summary>
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        /// <summary>
        /// Defines the _apiVerProvider.
        /// </summary>
        internal readonly IApiVersionDescriptionProvider _apiVerProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
        /// </summary>
        /// <param name="apiVerProvider">The apiVerProvider<see cref="IApiVersionDescriptionProvider"/>.</param>
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider apiVerProvider) => _apiVerProvider = apiVerProvider;

        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="options">The options<see cref="SwaggerGenOptions"/>.</param>
        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _apiVerProvider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, GetSwaggerDocInfo(description));
            }
        }

        /// <summary>
        /// The GetSwaggerDocInfo.
        /// </summary>
        /// <param name="description">The description<see cref="ApiVersionDescription"/>.</param>
        /// <returns>The <see cref="OpenApiInfo"/>.</returns>
        internal static OpenApiInfo GetSwaggerDocInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = $"RuRay WebAPI {description.ApiVersion}",
                Version = description.GroupName,
                Description = "Web API Template",
                Contact = new OpenApiContact()
                {
                    Name = "Web API service"
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT"
                }
            };

            if (description.IsDeprecated)
            {
                info.Description += $" {description.ApiVersion} API version is deprecated.";
            }

            return info;
        }
    }
}
