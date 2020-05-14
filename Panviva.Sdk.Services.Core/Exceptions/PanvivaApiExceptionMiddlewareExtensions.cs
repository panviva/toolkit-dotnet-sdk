// <copyright file="PanvivaApiExceptionMiddlewareExtensions.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Exceptions
{
    using Microsoft.AspNetCore.Builder;

    /// <summary>Middleware extension.</summary>
    public static class PanvivaApiExceptionMiddlewareExtensions
    {
        /// <summary>Uses the panviva API library exception middleware.</summary>
        /// <param name="builder">The builder.</param>
        /// <returns>Built middleware.</returns>
        public static IApplicationBuilder UsePanvivaExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PanvivaApiExceptionMiddleware>();
        }
    }
}
