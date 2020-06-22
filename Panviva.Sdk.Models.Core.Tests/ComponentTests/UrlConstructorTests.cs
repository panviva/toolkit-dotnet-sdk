using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Extensions;
using Panviva.Sdk.Services.Core.Extensions.V3;
using Panviva.Sdk.Services.Core.Utilities.V3;
using Xunit;

namespace Panviva.Sdk.Services.Core.Tests.ComponentTests
{
    public class UrlConstructorTests
    {
        public UrlConstructorTests()
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

            _urlConstructor = serviceProvider.GetService<RequestUrlConstructor>();
        }

        private readonly RequestUrlConstructor _urlConstructor;

        [Fact]
        public void CreateArtefactCategoryCommandModelUrlCheck_Invalid_WhenNameIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new CreateArtefactCategoryCommandModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void CreateArtefactCategoryCommandModelUrlCheck_Valid_WhenValidName()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new CreateArtefactCategoryCommandModel
            {
                Name = "test"
            };

            const string expectedUrl = baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetArtefactCategoryQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactCategoryQueryModel();
            const string expectedUrl = baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetArtefactQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetArtefactQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactQueryModel
            {
                Id = "100"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.ArtefactEndpointUrlSegment.AddSegmentToUrl(testDataModel.Id.ToLower());

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetContainerQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetContainerQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetContainerQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetContainerQueryModel
            {
                Id = "100"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.ResourcesContainerUrlSegment
                              + testDataModel.Id;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetDocumentContainerRelationshipsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainerRelationshipsQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetDocumentContainerRelationshipsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainerRelationshipsQueryModel
            {
                Id = "100"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.ResourcesRelationshipUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetDocumentContainersQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainersQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetDocumentContainersQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainersQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentContainerUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetDocumentQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetDocumentQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel
            {
                Id = "100"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetDocumentQueryModelUrlCheck_Valid_WhenValidModelDataWithVersion()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel
            {
                Id = "100",
                Version = "100"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + "?version=" + testDataModel.Version;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetDocumentTranslationsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentTranslationsQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetDocumentTranslationsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentTranslationsQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentTranslationsUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetFileQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFileQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetFileQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFileQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.FileEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetFolderChildrenQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderChildrenQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetFolderChildrenQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderChildrenQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.FolderChildrenUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetFolderQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetFolderQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetFolderRootQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderRootQueryModel();
            var expectedUrl = baseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + UrlConstants.FolderRootUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetFolderTranslationsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderTranslationsQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetFolderTranslationsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderTranslationsQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentTranslationsUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetImageQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetImageQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetImageQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetImageQueryModel
            {
                Id = "1"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.ImageEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithChannel()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Channel = "testChannel"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&channel=" + testDataModel.Channel;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithFacet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Facet = "rating"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&facet=" + testDataModel.Facet;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithFilter()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Filter = "testFilter"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&filter=" + testDataModel.Filter;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageLimit()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageLimit = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageOffset()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageOffset = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageOffsetAndPageLimit()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageOffset = 1,
                PageLimit = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageOffset=" + testDataModel.PageOffset
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithChannel()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Channel = "testChannel"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&channel=" + testDataModel.Channel;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithFacet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Facet = "rating"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&facet=" + testDataModel.Facet;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithFilter()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Filter = "testFilter"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&filter=" + testDataModel.Filter;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageLimit()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageLimit = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageOffset()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageOffset = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageOffsetAndPageLimit()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageOffset = 1,
                PageLimit = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageOffset=" + testDataModel.PageOffset
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenBothSimpleQueryAndAdvancedQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                AdvancedQuery = "test"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenNoQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel();

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenTermIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel();
            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test"
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchEndpointUrlSegment
                              + "&term=" + testDataModel.Term;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelDataWithPageOffset()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test",
                PageOffset = 1
            };
            var expectedUrl = baseUrl
                              + UrlConstants.SearchEndpointUrlSegment
                              + "&term=" + testDataModel.Term
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelDataWithPageOffsetAndPageLimit()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test",
                PageOffset = 1,
                PageLimit = 1
            };
            var expectedUrl = baseUrl + UrlConstants.SearchEndpointUrlSegment
                                      + "&term=" + testDataModel.Term
                                      + "&pageOffset=" + testDataModel.PageOffset
                                      + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdBothHaveValues()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                Query = "testQuery"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenValidUserIdAndQueryIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenValidUserNameAndQueryIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void
            LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagAndMaximizeClientIsSet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
                MaximizeClient = true
            };

            var expectedUrl = baseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagIsSet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true
            };

            var expectedUrl = baseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidUserIdAndQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdHaveValues()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidId()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                Id = "testId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenValidUserIdAndIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenValidUserNameAndIdIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndId()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                Id = "testId"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndIdAndLocation()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId",
                Location = "testLocation"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndIdAndMaximizeClientIsSet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId",
                MaximizeClient = true
            };

            var expectedUrl = baseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidUserIdAndId()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdBothHaveValues()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                Query = "testQuery"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenValidUserIdAndQueryIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenValidUserNameAndQueryIsNull()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName"
            };

            Assert.Throws<QueryModelException>(() => _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl));
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void
            LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagAndMaximizeClientIsSet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
                MaximizeClient = true
            };

            var expectedUrl = baseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagIsSet()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true
            };

            var expectedUrl = baseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidUserIdAndQuery()
        {
            const string baseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery"
            };

            var expectedUrl = baseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = _urlConstructor.ConstructRequestUrl(testDataModel, baseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }
    }
}