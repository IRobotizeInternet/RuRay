using Microsoft.AspNetCore.Builder;

namespace RuRay.API.Middleware
{
    /// <summary>
    /// Defines the <see cref="HttpContextMiddlewareExtensions" />.
    /// </summary>
    public static class HttpContextMiddlewareExtensions
    {
        /// <summary>
        /// The UseHttpContextMiddleware.
        /// </summary>
        /// <param name="builder">The builder<see cref="IApplicationBuilder"/>.</param>
        /// <returns>The <see cref="IApplicationBuilder"/>.</returns>
        public static IApplicationBuilder UseHttpContextMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextMiddleware>();
        }
    }
}
