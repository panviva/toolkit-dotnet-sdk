// <copyright file="ApiConfigHelper.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Utilities.V3
{
    using Microsoft.Extensions.Configuration;
    using Panviva.Sdk.Services.Core.Domain.CommonModels;

    /// <summary>Api config helper class.</summary>
    public class ApiConfigHelper
    {
        /// <summary>The configuration.</summary>
        private readonly IConfiguration configuration;

        /// <summary>The input validator.</summary>
        private readonly InputValidator inputValidator;

        /// <summary>Initializes a new instance of the <see cref="ApiConfigHelper"/> class.</summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="inputValidator">The input validator.</param>
        public ApiConfigHelper(IConfiguration configuration, InputValidator inputValidator)
        {
            this.configuration = configuration;
            this.inputValidator = inputValidator;
        }

        /// <summary>Gets the client URL from application settings.</summary>
        /// <returns>The configured client url.</returns>
        internal string GetClientUrlFromAppSettings()
        {
            var baseUrl = this.configuration["PanvivaApi:BaseUrl"] ?? UrlConstants.DefaultBaseUrl;
            var instance = this.configuration["PanvivaApi:Instance"];

            // validate the configuration inputs.
            this.inputValidator.ValidatePanvivaApiSettings(baseUrl, instance);

            var clientUrl = $"{baseUrl}/v3/{instance}";

            return clientUrl;
        }

        /// <summary>Gets the client URL from model.</summary>
        /// <param name="apiConfigModel">The Configuration model.</param>
        /// <returns>The configured client url.</returns>
        internal string GetClientUrlFromModel(ApiConfigModel apiConfigModel)
        {
            var baseUrl = apiConfigModel?.BaseUrl ?? UrlConstants.DefaultBaseUrl;
            var instance = apiConfigModel?.Instance;

            // validate the configuration inputs.
            this.inputValidator.ValidatePanvivaApiSettings(baseUrl, instance);

            var clientUrl = $"{baseUrl}/v3/{instance}";

            return clientUrl;
        }

        /// <summary>Gets the API key from application settings.</summary>
        /// <returns>The Api Key.</returns>
        internal string GetApiKeyFromAppSettings()
        {
            return this.inputValidator.GetAndSetApiKey(this.configuration["PanvivaApi:ApiKey"]);
        }

        /// <summary>Gets the API key from model.</summary>
        /// <param name="apiConfigModel">The Api Configuration Model.</param>
        /// <returns>The Api Key.</returns>
        internal string GetApiKeyFromModel(ApiConfigModel apiConfigModel)
        {
            return this.inputValidator.GetAndSetApiKey(apiConfigModel?.ApiKey);
        }

        /// <summary>Gets the retry count from application settings.</summary>
        /// <returns>The retry count.</returns>
        internal int GetRetryCountFromAppSettings()
        {
            return this.inputValidator.GetAndSetRetryCount(this.configuration["PanvivaApi:RetryCount"]);
        }

        /// <summary>Gets the retry count from model.</summary>
        /// <param name="apiConfigModel">The Api Configuration Model.</param>
        /// <returns>The retry count.</returns>
        internal int GetRetryCountFromModel(ApiConfigModel apiConfigModel)
        {
            return this.inputValidator.GetAndSetRetryCount(apiConfigModel.RetryCount);
        }
    }
}
