// <copyright file="CommandHandlerTests.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Tests.HandlerTests
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Moq;
    using Panviva.Sdk.Models.V3.Post;
    using Panviva.Sdk.Models.V3.Shared;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Requests;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Responses;
    using Panviva.Sdk.Services.Core.Domain.CommonModels;
    using Panviva.Sdk.Services.Core.Extensions.V3;
    using Panviva.Sdk.Services.Core.Handlers.V3;
    using Panviva.Sdk.Services.Core.Services;
    using Panviva.Sdk.Services.Core.Utilities;
    using Panviva.Sdk.Services.Core.Utilities.V3;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Test class for CommandHandler.cs.</summary>
    public class CommandHandlerTests
    {
        /// <summary>The configuration.</summary>
        private readonly IConfiguration _configuration;

        /// <summary>The request URL constructor.</summary>
        private readonly RequestUrlConstructor _requestUrlConstructor;

        /// <summary>The input validator.</summary>
        private readonly InputValidator _inputValidator;

        /// <summary>The mocked panviva client.</summary>
        private readonly Mock<IPanvivaClient> _mockedPanvivaClient;

        /// <summary>The API configuration helper.</summary>
        private readonly ApiConfigHelper _apiConfigHelper;

        /// <summary>Initializes a new instance of the <see cref="CommandHandlerTests"/> class.</summary>
        public CommandHandlerTests()
        {
            // create new moq for panviva client.
            _mockedPanvivaClient = new Mock<IPanvivaClient>();

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

            // Getting necessary services.
            _configuration = serviceProvider.GetService<IConfiguration>();

            _inputValidator = serviceProvider.GetService<InputValidator>();

            _apiConfigHelper = serviceProvider.GetService<ApiConfigHelper>();

            _requestUrlConstructor = serviceProvider.GetService<RequestUrlConstructor>();
        }

        /// <summary>Checks the return model is create artefact category result model when create artefact category command model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsCreateArtefactCategoryResultModelWhenCreateArtefactCategoryCommandModel()
        {
            // create models for tests.
            var expectedResultModel = new CreateArtefactCategoryResultModel();
            var commandModel = new CreateArtefactCategoryCommandModel
            {
                Name = "testName",
            };

            // mock the panviva client
            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<CreateArtefactCategoryResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CreateArtefactCategoryCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_configuration, _mockedPanvivaClient.Object, _requestUrlConstructor, _inputValidator, _apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is live CSH result model when create artefact category command model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsLiveCshResultModelWhenCreateArtefactCategoryCommandModel()
        {
            // create models for tests.
            var expectedResultModel = new LiveCshResultModel();
            var commandModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery",
            };

            // mock the panviva client
            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveCshResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<LiveCshCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_configuration, _mockedPanvivaClient.Object, _requestUrlConstructor, _inputValidator, _apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is live document result model when create live document command model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsLiveDocumentResultModelWhenCreateLiveDocumentCommandModel()
        {
            // create models for tests.
            var expectedResultModel = new LiveDocumentResultModel();
            var commandModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                Id = "testId",
            };

            // mock the panviva client
            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveDocumentResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<LiveDocumentCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_configuration, _mockedPanvivaClient.Object, _requestUrlConstructor, _inputValidator, _apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is live search result model when live search command model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsLiveSearchResultModelWhenLiveSearchCommandModel()
        {
            // create models for tests.
            var expectedResultModel = new LiveSearchResultModel();
            var commandModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery",
            };

            // mock the panviva client
            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveSearchResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<LiveSearchCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_configuration, _mockedPanvivaClient.Object, _requestUrlConstructor, _inputValidator, _apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task HandleAsync_IsCorrectResponseReturned_CorrectResponseExpected()
        {
            // Arrange
            var postArtefactRequest = new PostArtefactRequest()
            {
                Category = new Models.V3.Post.ArtefactCategory() { Id = 1 },
                Content = new List<ArtefactContent>(),
                PanvivaDocumentId = 1,
                PrimaryQuery = "This is my query",
                Title = "This is my title"
            };

            var commandModelResponse = new PostArtefactResponse
            {
                ResponseId = Guid.NewGuid(),
                Errors = new List<string>()
            };

            // mock the panviva client
            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<PostArtefactResponse>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<PostArtefactRequest>(), It.IsAny<int>()))
                .ReturnsAsync(commandModelResponse);

            var handler = new CommandHandler(_configuration, _mockedPanvivaClient.Object, _requestUrlConstructor, _inputValidator, _apiConfigHelper);

            var config = new ApiConfigModel()
            {
                ApiKey = "2b50d089e233sddh4c4f8fsee84c0bregh1b05b96d", // random key
                BaseUrl = "https://panviva-api.panviva.com",
                Instance = "local",
                RetryCount = 0
            };

            //Act
            var actualResultModel = await handler.HandleAsync(postArtefactRequest, config, true);

            //Assert
            Assert.Equal(commandModelResponse, actualResultModel);
        }
    }
}
