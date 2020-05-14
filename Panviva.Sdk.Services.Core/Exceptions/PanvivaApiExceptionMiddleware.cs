// <copyright file="PanvivaApiExceptionMiddleware.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Exceptions
{
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>Panviva Exception Middleware.</summary>
    public class PanvivaApiExceptionMiddleware
    {
        /// <summary>The next task.</summary>
        private readonly RequestDelegate nextTask;

        /// <summary>Initializes a new instance of the <see cref="PanvivaApiExceptionMiddleware"/> class.</summary>
        /// <param name="next">The next.</param>
        public PanvivaApiExceptionMiddleware(RequestDelegate next)
        {
            this.nextTask = next;
        }

        /// <summary>Invokes the asynchronous.</summary>
        /// <param name="httpContext">The HTTP context.</param>
        /// <returns>The task.</returns>
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await this.nextTask(httpContext);
            }
            catch (FailedApiRequestException ex)
            {
                this.ClearResponse(httpContext, ex.StatusCode);
            }
            catch (QueryModelException ex)
            {
                this.ClearResponse(httpContext, ex.StatusCode);
            }
        }

        /// <summary>Clears the cache headers.</summary>
        /// <param name="state">The state.</param>
        /// <returns>The task.</returns>
        private Task ClearCacheHeaders(object state)
        {
            var httpResponse = (HttpResponse)state;
            httpResponse.Headers["Cache-Control"] = "no-cache";
            httpResponse.Headers["Pragma"] = "no-cache";
            httpResponse.Headers["Expires"] = "-1";
            httpResponse.Headers.Remove("ETag");
            return Task.CompletedTask;
        }

        /// <summary>Clears the response.</summary>
        /// <param name="httpContext">The HTTP context.</param>
        /// <param name="statusCode">The status code.</param>
        private void ClearResponse(HttpContext httpContext, HttpStatusCode statusCode)
        {
            httpContext.Response.Clear();
            httpContext.Response.StatusCode = (int)statusCode;
            httpContext.Response.OnStarting(this.ClearCacheHeaders, httpContext.Response);
        }
    }
}
