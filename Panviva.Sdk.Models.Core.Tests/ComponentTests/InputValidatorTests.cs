// <copyright file="InputValidatorTests.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Tests.ComponentTests
{
    using System;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Panviva.Sdk.Services.Core.Exceptions;
    using Panviva.Sdk.Services.Core.Extensions.V3;
    using Panviva.Sdk.Services.Core.Utilities;
    using Xunit;

    /// <summary>Test class for InputValidator.cs.</summary>
    public class InputValidatorTests
    {
        /// <summary>The input validator from SDK.</summary>
        private readonly InputValidator inputValidator;

        /// <summary>Initializes a new instance of the <see cref="InputValidatorTests"/> class.</summary>
        public InputValidatorTests()
        {
            // Creating an app service service collection.
            var serviceCollection = new ServiceCollection();

            // Adding IConfiguration service to service collection.(It's reading config from json file specified)
            serviceCollection.AddTransient<IConfiguration>(sp =>
            {
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddJsonFile("appsettings.json");
                return configurationBuilder.Build();
            });

            // Registering necessary Services to service collection.
            serviceCollection.AddPanvivaApis();

            // Getting service provider form service collection.
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Extracting necessary services from service provider.
            this.inputValidator = serviceProvider.GetService<InputValidator>();
        }

        /// <summary>Determines whether [is valid panviva API settings invalid when invalid base URL].</summary>
        [Fact]
        public void IsValidPanvivaApiSettings_Invalid_WhenInvalidBaseUrl()
        {
            const string BaseUrl = "Invalid/Url";
            const string Instance = "qa-a";

            Exception ex = Assert.Throws<FailedApiRequestException>(() => this.inputValidator.ValidatePanvivaApiSettings(BaseUrl, Instance));
        }

        /// <summary>Determines whether [is valid panviva API settings invalid when null instance].</summary>
        /// <param name="instance">The the Instance input from Theory.</param>
        [Theory]
        [InlineData(null)]
        [InlineData("\n")]
        public void IsValidPanvivaApiSettings_Invalid_WhenNullInstance(string instance)
        {
            const string BaseUrl = "https://staging-api.panviva.com";

            Exception ex = Assert.Throws<FailedApiRequestException>(() => this.inputValidator.ValidatePanvivaApiSettings(BaseUrl, instance));
        }

        /// <summary>Determines whether [is API key validated valid when not null key].</summary>
        [Fact]
        public void IsApiKeyValidated_Valid_WhenNotNullKey()
        {
            const string ApiKey = "1234567890key";
            var returnedKey = this.inputValidator.GetAndSetApiKey(ApiKey);

            Assert.Equal(returnedKey, ApiKey);
        }

        /// <summary>Determines whether [is API key validated invalid when null key].</summary>
        [Fact]
        public void IsApiKeyValidated_Invalid_WhenNullKey()
        {
            const string ApiKey = null;

            Exception ex = Assert.Throws<FailedApiRequestException>(() => this.inputValidator.GetAndSetApiKey(ApiKey));
        }

        /// <summary>Determines whether [is retry count validated valid when acceptable number].</summary>
        [Fact]
        public void IsRetryCountValidated_Valid_WhenAcceptableNumber()
        {
            const string RetryCount = "3";
            var returnedRetryCount = this.inputValidator.GetAndSetRetryCount(RetryCount);

            Assert.Equal(3, returnedRetryCount);
        }

        /// <summary>Determines whether [is retry count validated invalid when null].</summary>
        [Fact]
        public void IsRetryCountValidated_Invalid_WhenNull()
        {
            const string RetryCount = null;
            const int DefaultRetryCount = 3;
            var returnedRetryCount = this.inputValidator.GetAndSetRetryCount(RetryCount);

            Assert.Equal(DefaultRetryCount, returnedRetryCount);
        }

        /// <summary>Determines whether [is retry count validated invalid when in compatible integer].</summary>
        [Fact]
        public void IsRetryCountValidated_Invalid_WhenInCompatibleInteger()
        {
            const string RetryCount = "Five";
            const int DefaultRetryCount = 3;
            var returnedRetryCount = this.inputValidator.GetAndSetRetryCount(RetryCount);

            Assert.Equal(DefaultRetryCount, returnedRetryCount);
        }
    }
}
