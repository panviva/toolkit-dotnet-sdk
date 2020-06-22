using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Panviva.Sdk.Services.Core.Exceptions
{
    public class PanvivaApiExceptionMiddleware
    {
        private readonly RequestDelegate nextTask;

        public PanvivaApiExceptionMiddleware(RequestDelegate next)
        {
            nextTask = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await nextTask(httpContext);
            }
            catch (FailedApiRequestException ex)
            {
                ClearResponse(httpContext, ex.StatusCode);
            }
            catch (QueryModelException ex)
            {
                ClearResponse(httpContext, ex.StatusCode);
            }
        }

        private Task ClearCacheHeaders(object state)
        {
            var httpResponse = (HttpResponse) state;
            httpResponse.Headers["Cache-Control"] = "no-cache";
            httpResponse.Headers["Pragma"] = "no-cache";
            httpResponse.Headers["Expires"] = "-1";
            httpResponse.Headers.Remove("ETag");
            return Task.CompletedTask;
        }

        private void ClearResponse(HttpContext httpContext, HttpStatusCode statusCode)
        {
            httpContext.Response.Clear();
            httpContext.Response.StatusCode = (int) statusCode;
            httpContext.Response.OnStarting(ClearCacheHeaders, httpContext.Response);
        }
    }
}