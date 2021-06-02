using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using Serilog.Context;

namespace RuRay.API.Middleware
{
    /// <summary>
    /// Defines the <see cref="HttpContextMiddleware" />.
    /// </summary>
    public class HttpContextMiddleware
    {
        /// <summary>
        /// Defines the MessageTemplate.
        /// </summary>
        internal const string MessageTemplate =
            "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms [User:{User}][Protocol:{RequestProtocol}][Host:{RequestHost}][Referer:{Referer}][User-Agent:{UserAgent}]";

        /// <summary>
        /// Defines the ErrorMessageTemplate.
        /// </summary>
        internal const string ErrorMessageTemplate =
           "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms [User:{User}][Protocol:{RequestProtocol}][Host:{RequestHost}][Headers:{RequestHeaders}]";

        /// <summary>
        /// Defines the _next.
        /// </summary>
        internal readonly RequestDelegate _next;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpContextMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next<see cref="RequestDelegate"/>.</param>
        public HttpContextMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// The Invoke.
        /// </summary>
        /// <param name="httpContext">The httpContext<see cref="HttpContext"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            var userName = httpContext.User.Identity.IsAuthenticated ? httpContext.User.Identity.Name : "unknown";

            LogContext.PushProperty("User", !string.IsNullOrWhiteSpace(userName) ? userName : null);

            var sw = Stopwatch.StartNew();
            try
            {
                await _next(httpContext);
                sw.Stop();
                PushProperties(sw.Elapsed.TotalMilliseconds, httpContext);
                Log.Information(MessageTemplate, httpContext.Request.Method, httpContext.Request.Path, httpContext.Response.StatusCode, sw.Elapsed.TotalMilliseconds);
            }
            catch (Exception ex)
            {
                sw.Stop();
                var errorId = Guid.NewGuid();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                PushProperties(sw.Elapsed.TotalMilliseconds, httpContext, errorId);
                Log.Error(ex, ErrorMessageTemplate, httpContext.Request.Method, httpContext.Request.Path, 500, sw.Elapsed.TotalMilliseconds);

                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new { errorId }));
            }
        }

        /// <summary>
        /// The PushProperties.
        /// </summary>
        /// <param name="elapsed">The elapsed<see cref="double"/>.</param>
        /// <param name="httpContext">The httpContext<see cref="HttpContext"/>.</param>
        /// <param name="errorId">The errorId<see cref="Guid?"/>.</param>
        private static void PushProperties(double elapsed, HttpContext httpContext, Guid? errorId = null)
        {
            var requestHeader = httpContext.Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString());
            LogContext.PushProperty("Elapsed", elapsed);
            LogContext.PushProperty("RequestHeaders", requestHeader, destructureObjects: true);
            LogContext.PushProperty("Referer", requestHeader.ContainsKey("Referer") ? requestHeader["Referer"] : "");
            LogContext.PushProperty("UserAgent", requestHeader.ContainsKey("User-Agent") ? requestHeader["User-Agent"] : "");

            LogContext.PushProperty("RequestHost", httpContext.Request.Host);
            LogContext.PushProperty("RequestProtocol", httpContext.Request.Protocol);
            if (errorId != null)
            {
                LogContext.PushProperty("ErrorId", errorId);
            }
        }
    }
}
