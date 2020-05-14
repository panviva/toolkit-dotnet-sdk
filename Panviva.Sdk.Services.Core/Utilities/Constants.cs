// <copyright file="Constants.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>
using System.Net;

namespace Panviva.Sdk.Services.Core.Utilities
{

    /// <summary>Constants class.</summary>
    internal static class Constants
    {
        /// <summary>The Status code for invalid query model data.</summary>
        internal const HttpStatusCode StatusCodeForFailedQueryValidation = (HttpStatusCode)400;

        /// <summary>The Status code for invalid Api settings.</summary>
        internal const HttpStatusCode StatusCodeForInvalidApiSettings = (HttpStatusCode)400;

        /// <summary>The Status code for invalid Api settings.</summary>
        internal const HttpStatusCode StatusCodeForInvalidModel = (HttpStatusCode)400;

        /// <summary>The default retry count.</summary>
        internal const int DefaultRetryCount = 3;
    }
}
