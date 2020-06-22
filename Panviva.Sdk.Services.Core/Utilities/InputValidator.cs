using System;
using System.Runtime.CompilerServices;
using Panviva.Sdk.Services.Core.Exceptions;

[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities
{
    public class InputValidator
    {
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

        internal string GetAndSetApiKey(string apiKey)
        {
            if (!string.IsNullOrWhiteSpace(apiKey))
            {
                return apiKey;
            }

            var message = "Api key is parameter is empty or not formatted correctly.";
            throw new FailedApiRequestException(Constants.StatusCodeForInvalidApiSettings, message);
        }

        internal int GetAndSetRetryCount(string retryCount)
        {
            return int.TryParse(retryCount, out var result) ? result : Constants.DefaultRetryCount;
        }

        internal int GetAndSetRetryCount(int? retryCount)
        {
            return retryCount ?? Constants.DefaultRetryCount;
        }
    }
}