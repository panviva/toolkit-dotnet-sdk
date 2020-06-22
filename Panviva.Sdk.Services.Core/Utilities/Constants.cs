using System.Net;

namespace Panviva.Sdk.Services.Core.Utilities
{
    internal static class Constants
    {
        internal const HttpStatusCode StatusCodeForFailedQueryValidation = HttpStatusCode.BadRequest;

        internal const HttpStatusCode StatusCodeForInvalidApiSettings = HttpStatusCode.BadRequest;

        internal const HttpStatusCode StatusCodeForInvalidModel = HttpStatusCode.BadRequest;

        internal const int DefaultRetryCount = 3;
    }
}