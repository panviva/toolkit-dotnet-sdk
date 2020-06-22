using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Panviva.Sdk.Models.V3.Post;
using Panviva.Sdk.Models.V3.Shared;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Extensions.V3;
using Panviva.Sdk.Services.Core.Handlers.V3;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities;
using Panviva.Sdk.Services.Core.Utilities.V3;
using Xunit;
using ArtefactCategory = Panviva.Sdk.Models.V3.Post.ArtefactCategory;

namespace Panviva.Sdk.Services.Core.Tests.HandlerTests
{
    public class CommandHandlerTests
    {
        private readonly RequestUrlConstructor _requestUrlConstructor;

        private readonly Mock<IPanvivaClient> _mockedPanvivaClient;

        private readonly ApiConfigHelper _apiConfigHelper;

        public CommandHandlerTests()
        {
            _mockedPanvivaClient = new Mock<IPanvivaClient>();
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IConfiguration>(sp =>
            {
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddJsonFile("appsettings.json");
                return configurationBuilder.Build();
            });

            serviceCollection.AddPanvivaApis();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<IConfiguration>();
            serviceProvider.GetService<InputValidator>();

            _apiConfigHelper = serviceProvider.GetService<ApiConfigHelper>();
            _requestUrlConstructor = serviceProvider.GetService<RequestUrlConstructor>();
        }

        [Fact]
        public async Task CheckReturnModel_IsCreateArtefactCategoryResultModelWhenCreateArtefactCategoryCommandModel()
        {
            var expectedResultModel = new CreateArtefactCategoryResultModel();
            var commandModel = new CreateArtefactCategoryCommandModel
            {
                Name = "testName"
            };

            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<CreateArtefactCategoryResultModel>(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<CreateArtefactCategoryCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsLiveCshResultModelWhenCreateArtefactCategoryCommandModel()
        {
            var expectedResultModel = new LiveCshResultModel();
            var commandModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery"
            };

            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveCshResultModel>(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<LiveCshCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsLiveDocumentResultModelWhenCreateLiveDocumentCommandModel()
        {
            var expectedResultModel = new LiveDocumentResultModel();
            var commandModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                Id = "testId"
            };

            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveDocumentResultModel>(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<LiveDocumentCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsLiveSearchResultModelWhenLiveSearchCommandModel()
        {
            var expectedResultModel = new LiveSearchResultModel();
            var commandModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery"
            };

            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<LiveSearchResultModel>(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<LiveSearchCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new CommandHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(commandModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task HandleAsync_IsCorrectResponseReturned_CorrectResponseExpected()
        {
            var postArtefactRequest = new PostArtefactCommandModel
            {
                Category = new ArtefactCategory {Id = 1},
                Content = new List<ArtefactContent>(),
                PanvivaDocumentId = 1,
                PrimaryQuery = "This is my query",
                Title = "This is my title"
            };

            var commandModelResponse = new PostArtefactResultModel
            {
                ResponseId = Guid.NewGuid()
            };

            _mockedPanvivaClient.Setup(x => x.PostToPanvivaApi<PostArtefactResultModel>(It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<PostArtefactCommandModel>(), It.IsAny<int>()))
                .ReturnsAsync(commandModelResponse);

            var handler = new CommandHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var config = new ApiConfigModel
            {
                ApiKey = "2b50d089e233sddh4c4f8fsee84c0bregh1b05b96d",   
                BaseUrl = "https://panviva-api.panviva.com",
                Instance = "local",
                RetryCount = 0
            };
            var actualResultModel = await handler.HandleAsync(postArtefactRequest, config, true);

            Assert.Equal(commandModelResponse, actualResultModel);
        }
    }
}