using Microsoft.AspNetCore.Builder;

namespace Robotize.API.Middleware
{
    public static class HttpContextMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpContextMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextMiddleware>();
        }
    }
}




