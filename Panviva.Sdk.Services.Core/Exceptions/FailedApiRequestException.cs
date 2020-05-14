// <copyright file="FailedApiRequestException.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Exceptions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;

    /// <summary>Failed API Response Exception.</summary>
    /// <seealso cref="System.Exception" />
    public class FailedApiRequestException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="FailedApiRequestException"/> class.</summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessage">The error message.</param>
        public FailedApiRequestException(HttpStatusCode errorCode, string errorMessage)
            : base($"Error Code: {errorCode} , Error Message: {errorMessage}")
        {
            this.StatusCode = errorCode;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>Gets or sets the error message.</summary>
        /// <value>The error message.</value>
        public string ErrorMessage { get; set; }

        /// <summary>Gets or sets the status code.</summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; set; }
    }
}