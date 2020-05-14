// <copyright file="QueryModelException.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Exceptions
{
    using System;
    using System.Net;
    using Panviva.Sdk.Services.Core.Utilities;

    /// <summary>Query model validation exception.</summary>
    /// <seealso cref="System.Exception" />
    public class QueryModelException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="QueryModelException"/> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public QueryModelException(string message)
            : base(string.Format(message))
        {
            this.StatusCode = Constants.StatusCodeForFailedQueryValidation;
        }

        /// <summary>Gets or sets the status code.</summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; set; }
    }
}