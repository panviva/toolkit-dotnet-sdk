using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Extensions.V3;
using Panviva.Sdk.Services.Core.Utilities;
using Xunit;

namespace Panviva.Sdk.Services.Core.Tests.ComponentTests
{
    public class InputValidatorTests
    {
        public InputValidatorTests()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IConfiguration>(sp =>
            {
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddJsonFile("appsettings.json");
                return configurationBuilder.Build();
            });

            serviceCollection.AddPanvivaApis();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            _inputValidator = serviceProvider.GetService<InputValidator>();
        }

        private readonly InputValidator _inputValidator;

        [Theory]
        [InlineData(null)]
        [InlineData("\n")]
        public void IsValidPanvivaApiSettings_Invalid_WhenNullInstance(string instance)
        {
            const string baseUrl = "https://staging-api.panviva.com";

            Assert.Throws<FailedApiRequestException>(() =>
                _inputValidator.ValidatePanvivaApiSettings(baseUrl, instance));
        }

        [Fact]
        public void IsApiKeyValidated_Invalid_WhenNullKey()
        {
            const string apiKey = null;

            Assert.Throws<FailedApiRequestException>(() => _inputValidator.GetAndSetApiKey(apiKey));
        }

        [Fact]
        public void IsApiKeyValidated_Valid_WhenNotNullKey()
        {
            const string apiKey = "1234567890key";
            var returnedKey = _inputValidator.GetAndSetApiKey(apiKey);

            Assert.Equal(returnedKey, apiKey);
        }

        [Fact]
        public void IsRetryCountValidated_Invalid_WhenInCompatibleInteger()
        {
            const string retryCount = "Five";
            const int defaultRetryCount = 3;
            var returnedRetryCount = _inputValidator.GetAndSetRetryCount(retryCount);

            Assert.Equal(defaultRetryCount, returnedRetryCount);
        }

        [Fact]
        public void IsRetryCountValidated_Invalid_WhenNull()
        {
            const string retryCount = null;
            const int defaultRetryCount = 3;
            var returnedRetryCount = _inputValidator.GetAndSetRetryCount(retryCount);

            Assert.Equal(defaultRetryCount, returnedRetryCount);
        }

        [Fact]
        public void IsRetryCountValidated_Valid_WhenAcceptableNumber()
        {
            const string retryCount = "3";
            var returnedRetryCount = _inputValidator.GetAndSetRetryCount(retryCount);

            Assert.Equal(3, returnedRetryCount);
        }

        [Fact]
        public void IsValidPanvivaApiSettings_Invalid_WhenInvalidBaseUrl()
        {
            const string baseUrl = "Invalid/Url";
            const string instance = "qa-a";

            Assert.Throws<FailedApiRequestException>(() =>
                _inputValidator.ValidatePanvivaApiSettings(baseUrl, instance));
        }
    }
}