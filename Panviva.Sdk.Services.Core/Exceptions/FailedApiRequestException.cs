using System;
using System.Net;

namespace Panviva.Sdk.Services.Core.Exceptions
{
    public class FailedApiRequestException : Exception
    {
        public FailedApiRequestException(HttpStatusCode errorCode)
        {
            StatusCode = errorCode;
        }

        public FailedApiRequestException(HttpStatusCode errorCode, string errorMessage)
            : base(errorMessage)
        {
            StatusCode = errorCode;
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}