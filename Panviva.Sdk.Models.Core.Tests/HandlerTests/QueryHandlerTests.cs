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

namespace Panviva.Sdk.Services.Core.Tests.HandlerTests
{
    public class QueryHandlerTests
    {
        private readonly RequestUrlConstructor _requestUrlConstructor;

        private readonly Mock<IPanvivaClient> _mockedPanvivaClient;

        private readonly ApiConfigHelper _apiConfigHelper;

        public QueryHandlerTests()
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
        public async Task CheckReturnModel_IsGetArtefactCategoryResultModelWhenGetArtefactCategoryQueryModel()
        {
            var expectedResultModel = new GetArtefactCategoryResultModel();
            var queryModel = new GetArtefactCategoryQueryModel();

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetArtefactCategoryResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetArtefactResultModelWhenGetArtefactQueryModel()
        {
            var expectedResultModel = new GetArtefactResultModel();
            var queryModel = new GetArtefactQueryModel
            {
                Id = "testId"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetArtefactResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetContainerResultModelWhenGetContainerQueryModel()
        {
            var expectedResultModel = new GetContainerResultModel();
            var queryModel = new GetContainerQueryModel
            {
                Id = "testId"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetContainerResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task
            CheckReturnModel_IsGetDocumentContainerRelationshipsResultModelWhenGetDocumentContainerRelationshipsQueryModel()
        {
            var expectedResultModel = new GetDocumentContainerRelationshipsResultModel();
            var queryModel = new GetDocumentContainerRelationshipsQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(It.IsAny<string>(),
                        It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetDocumentContainersResultModelWhenGetDocumentContainersQueryModel()
        {
            var expectedResultModel = new GetDocumentContainersResultModel();
            var queryModel = new GetDocumentContainersQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetDocumentContainersResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetDocumentResultModelWhenGetDocumentQueryModel()
        {
            var expectedResultModel = new GetDocumentResultModel();
            var queryModel = new GetDocumentQueryModel
            {
                Id = "testId"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetDocumentResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetDocumentTranslationsResultModelWhenGetDocumentTranslationsQueryModel()
        {
            var expectedResultModel = new GetDocumentTranslationsResultModel();
            var queryModel = new GetDocumentTranslationsQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetFileResultModelWhenGetFileQueryModel()
        {
            var expectedResultModel = new GetFileResultModel();
            var queryModel = new GetFileQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetFileResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetFolderChildrenResultModelWhenGetFolderChildrenQueryModel()
        {
            var expectedResultModel = new GetFolderChildrenResultModel();
            var queryModel = new GetFolderChildrenQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetFolderChildrenResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetFolderResultModelWhenGetFolderQueryModel()
        {
            var expectedResultModel = new GetFolderResultModel();
            var queryModel = new GetFolderQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetFolderResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetFolderRootResultModelWhenGetFolderRootQueryModel()
        {
            var expectedResultModel = new GetFolderRootResultModel();
            var queryModel = new GetFolderRootQueryModel();

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetFolderRootResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetFolderTranslationsResultModelWhenGetFolderTranslationsQueryModel()
        {
            var expectedResultModel = new GetFolderTranslationsResultModel();
            var queryModel = new GetFolderTranslationsQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetFolderTranslationsResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetImageResultModelWhenGetImageQueryModel()
        {
            var expectedResultModel = new GetImageResultModel();
            var queryModel = new GetImageQueryModel
            {
                Id = "100"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetImageResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetSearchArtefactResultModelWhenGetSearchArtefactQueryModel()
        {
            var expectedResultModel = new GetSearchArtefactResultModel();
            var queryModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetSearchArtefactResultModel>(It.IsAny<string>(), It.IsAny<string>(),
                        It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }

        [Fact]
        public async Task CheckReturnModel_IsGetSearchResultModelWhenGetSearchQueryModel()
        {
            var expectedResultModel = new GetSearchResultModel();
            var queryModel = new GetSearchQueryModel
            {
                Term = "test"
            };

            _mockedPanvivaClient.Setup(x =>
                    x.GetFromPanvivaApi<GetSearchResultModel>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(expectedResultModel);

            var handler = new QueryHandler(_mockedPanvivaClient.Object, _requestUrlConstructor, _apiConfigHelper);
            var actualResultModel = await handler.HandleAsync(queryModel);

            Assert.Equal(expectedResultModel, actualResultModel);
        }
    }
}