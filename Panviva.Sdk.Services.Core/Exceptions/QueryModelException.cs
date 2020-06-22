using System;
using System.Net;
using Panviva.Sdk.Services.Core.Utilities;

namespace Panviva.Sdk.Services.Core.Exceptions
{
    public class QueryModelException : Exception
    {
        public QueryModelException(string message)
            : base(string.Format(message))
        {
            StatusCode = Constants.StatusCodeForFailedQueryValidation;
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}