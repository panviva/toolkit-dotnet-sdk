using Microsoft.AspNetCore.Builder;

namespace Panviva.Sdk.Services.Core.Exceptions
{
    public static class PanvivaApiExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UsePanvivaExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PanvivaApiExceptionMiddleware>();
        }
    }
}