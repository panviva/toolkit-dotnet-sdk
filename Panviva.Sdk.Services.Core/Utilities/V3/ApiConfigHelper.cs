using Microsoft.Extensions.Configuration;
using Panviva.Sdk.Services.Core.Domain.CommonModels;

namespace Panviva.Sdk.Services.Core.Utilities.V3
{
    public class ApiConfigHelper
    {
        private readonly IConfiguration _configuration;
        private readonly InputValidator _inputValidator;

        public ApiConfigHelper(IConfiguration configuration, InputValidator inputValidator)
        {
            _configuration = configuration;
            _inputValidator = inputValidator;
        }

        internal string GetClientUrlFromAppSettings()
        {
            var baseUrl = _configuration["PanvivaApi:BaseUrl"] ?? UrlConstants.DefaultBaseUrl;
            var instance = _configuration["PanvivaApi:Instance"];

            _inputValidator.ValidatePanvivaApiSettings(baseUrl, instance);

            var clientUrl = $"{baseUrl}/v3/{instance}";

            return clientUrl;
        }

        internal string GetClientUrlFromModel(ApiConfigModel apiConfigModel)
        {
            var baseUrl = apiConfigModel?.BaseUrl ?? UrlConstants.DefaultBaseUrl;
            var instance = apiConfigModel?.Instance;

            _inputValidator.ValidatePanvivaApiSettings(baseUrl, instance);

            var clientUrl = $"{baseUrl}/v3/{instance}";

            return clientUrl;
        }

        internal string GetApiKeyFromAppSettings()
        {
            return _inputValidator.GetAndSetApiKey(_configuration["PanvivaApi:ApiKey"]);
        }

        internal string GetApiKeyFromModel(ApiConfigModel apiConfigModel)
        {
            return _inputValidator.GetAndSetApiKey(apiConfigModel?.ApiKey);
        }

        internal int GetRetryCountFromAppSettings()
        {
            return _inputValidator.GetAndSetRetryCount(_configuration["PanvivaApi:RetryCount"]);
        }

        internal int GetRetryCountFromModel(ApiConfigModel apiConfigModel)
        {
            return _inputValidator.GetAndSetRetryCount(apiConfigModel.RetryCount);
        }
    }
}