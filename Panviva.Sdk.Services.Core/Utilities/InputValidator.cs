// <copyright file="InputValidator.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities
{
    using System;
    using System.Text.RegularExpressions;
    using Panviva.Sdk.Services.Core.Exceptions;

    /// <summary>Inputs Validator methods class.</summary>
    public class InputValidator
    {
        /// <summary>Validates the panviva API settings.</summary>
        /// <param name="baseUri">The base URI.</param>
        /// <param name="instance">The instance.</param>
        internal void ValidatePanvivaApiSettings(string baseUri, string instance)
        {
            var isBaseUrlValid = Uri.IsWellFormedUriString(baseUri, UriKind.Absolute);
            var isInstanceValid = !string.IsNullOrWhiteSpace(instance);

            if (isBaseUrlValid && isInstanceValid)
            {
                return;
            }

            var message = "Api settings provided either invalid or not formatted correctly.";
            throw new FailedApiRequestException(Constants.StatusCodeForInvalidApiSettings, message);
        }

        /// <summary>Validates the panviva API key.</summary>
        /// <param name="apiKey">The API key.</param>
        /// <returns>Api key.</returns>
        internal string GetAndSetApiKey(string apiKey)
        {
            if (!string.IsNullOrWhiteSpace(apiKey))
            {
                return apiKey;
            }

            var message = "Api key is parameter is empty or not formatted correctly.";
            throw new FailedApiRequestException(Constants.StatusCodeForInvalidApiSettings, message);
        }

        /// <summary>Gets the and set retry count.</summary>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>configured or default retry count.</returns>
        internal int GetAndSetRetryCount(string retryCount)
        {
            return int.TryParse(retryCount, out var result) ? result : Constants.DefaultRetryCount;
        }

        /// <summary>Gets the and set retry count.</summary>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>configured or default retry count.</returns>
        internal int GetAndSetRetryCount(int? retryCount)
        {
            return retryCount ?? Constants.DefaultRetryCount;
        }

        /// <summary>Checks the version number.</summary>
        /// <param name="input">The input.</param>
        /// <returns>The validness.</returns>
        private bool CheckVersionNumber(string input)
        {
            // checks for a (v,V) followed by the Semantic Version
            var regex = @"^[v,V]{1}[3-9]$";

            var match = Regex.Match(input, regex);

            return match.Success;
        }
    }
}
