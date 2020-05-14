// <copyright file="QueryHandlerTests.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Tests.HandlerTests
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Moq;
    using Panviva.Sdk.Models.V3.Get;
    using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
    using Panviva.Sdk.Services.Core.Extensions.V3;
    using Panviva.Sdk.Services.Core.Handlers.V3;
    using Panviva.Sdk.Services.Core.Services;
    using Panviva.Sdk.Services.Core.Utilities;
    using Panviva.Sdk.Services.Core.Utilities.V3;
    using Xunit;

    /// <summary>Test class for QueryHandler.cs.</summary>
    public class QueryHandlerTests
    {
        /// <summary>The configuration.</summary>
        private readonly IConfiguration configuration;

        /// <summary>The request URL constructor.</summary>
        private readonly RequestUrlConstructor requestUrlConstructor;

        /// <summary>The input validator.</summary>
        private readonly InputValidator inputValidator;

        /// <summary>The mocked panviva client.</summary>
        private readonly Mock<IPanvivaClient> mockedPanvivaClient;

        /// <summary>The API configuration helper.</summary>
        private readonly ApiConfigHelper apiConfigHelper;

        /// <summary>Initializes a new instance of the <see cref="QueryHandlerTests"/> class.</summary>
        public QueryHandlerTests()
        {
            // create new moq for panviva client.
            this.mockedPanvivaClient = new Mock<IPanvivaClient>();

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
            this.configuration = serviceProvider.GetService<IConfiguration>();
            this.inputValidator = serviceProvider.GetService<InputValidator>();
            this.apiConfigHelper = serviceProvider.GetService<ApiConfigHelper>();
            this.requestUrlConstructor = serviceProvider.GetService<RequestUrlConstructor>();
        }

        /// <summary>Checks the return model is get artefact result model when get artefact query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetArtefactResultModelWhenGetArtefactQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetArtefactResultModel();
            var queryModel = new GetArtefactQueryModel
            {
                Id = "testId",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetArtefactResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get container result model when get container query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetContainerResultModelWhenGetContainerQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetContainerResultModel();
            var queryModel = new GetContainerQueryModel
            {
                Id = "testId",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetContainerResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get document result model when get document query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetDocumentResultModelWhenGetDocumentQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetDocumentResultModel();
            var queryModel = new GetDocumentQueryModel
            {
                Id = "testId",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetDocumentResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get document container relationships result model when get document container relationships query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetDocumentContainerRelationshipsResultModelWhenGetDocumentContainerRelationshipsQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetDocumentContainerRelationshipsResultModel();
            var queryModel = new GetDocumentContainerRelationshipsQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get document containers result model when get document containers query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetDocumentContainersResultModelWhenGetDocumentContainersQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetDocumentContainersResultModel();
            var queryModel = new GetDocumentContainersQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetDocumentContainersResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get document translations result model when get document translations query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetDocumentTranslationsResultModelWhenGetDocumentTranslationsQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetDocumentTranslationsResultModel();
            var queryModel = new GetDocumentTranslationsQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get file result model when get file query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetFileResultModelWhenGetFileQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetFileResultModel();
            var queryModel = new GetFileQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetFileResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get folder result model when get folder query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetFolderResultModelWhenGetFolderQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetFolderResultModel();
            var queryModel = new GetFolderQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetFolderResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get folder children result model when get folder children query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetFolderChildrenResultModelWhenGetFolderChildrenQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetFolderChildrenResultModel();
            var queryModel = new GetFolderChildrenQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetFolderChildrenResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get folder root result model when get folder root query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetFolderRootResultModelWhenGetFolderRootQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetFolderRootResultModel();
            var queryModel = new GetFolderRootQueryModel();

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetFolderRootResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get folder translations result model when get folder translations query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetFolderTranslationsResultModelWhenGetFolderTranslationsQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetFolderTranslationsResultModel();
            var queryModel = new GetFolderTranslationsQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetFolderTranslationsResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get artefact category result model when get artefact category query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetArtefactCategoryResultModelWhenGetArtefactCategoryQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetArtefactCategoryResultModel();
            var queryModel = new GetArtefactCategoryQueryModel();

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetArtefactCategoryResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get image result model when get image query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetImageResultModelWhenGetImageQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetImageResultModel();
            var queryModel = new GetImageQueryModel
            {
                Id = "100",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetImageResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get search result model when get search query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetSearchResultModelWhenGetSearchQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetSearchResultModel();
            var queryModel = new GetSearchQueryModel
            {
                Term = "test",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetSearchResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        /// <summary>Checks the return model is get search artefact result model when get search artefact query model.</summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Fact]
        public async Task CheckReturnModel_IsGetSearchArtefactResultModelWhenGetSearchArtefactQueryModel()
        {
            // create models for tests.
            var expectedResultModel = new GetSearchArtefactResultModel();
            var queryModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
            };

            // mock the panviva client
            this.mockedPanvivaClient.Setup(x => x.GetFromPanvivaApi<GetSearchArtefactResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(this.configuration, this.mockedPanvivaClient.Object, this.requestUrlConstructor, this.inputValidator, this.apiConfigHelper);

            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }
    }
}
