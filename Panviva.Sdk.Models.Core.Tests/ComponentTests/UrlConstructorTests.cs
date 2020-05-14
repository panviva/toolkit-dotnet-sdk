// <copyright file="UrlConstructorTests.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Tests.ComponentTests
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
    using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
    using Panviva.Sdk.Services.Core.Exceptions;
    using Panviva.Sdk.Services.Core.Extensions;
    using Panviva.Sdk.Services.Core.Extensions.V3;
    using Panviva.Sdk.Services.Core.Utilities.V3;
    using System;
    using Xunit;

    /// <summary>Test class for QueryUrlConstructor.cs.</summary>
    public class UrlConstructorTests
    {
        /// <summary>The query URL constructor form SDK.</summary>
        private readonly RequestUrlConstructor urlConstructor;

        /// <summary>Initializes a new instance of the <see cref="UrlConstructorTests"/> class.</summary>
        public UrlConstructorTests()
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
            this.urlConstructor = serviceProvider.GetService<RequestUrlConstructor>();
        }

        /// <summary>Gets the artefact query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetArtefactQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactQueryModel
            {
                Id = "100",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.ArtefactEndpointUrlSegment.AddSegmentToUrl(testDataModel.Id.ToLower());

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the artefact query model URL check invalid when identifier is null.</summary>
        [Fact]
        public void GetArtefactQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the container query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetContainerQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetContainerQueryModel
            {
                Id = "100",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.ResourcesContainerUrlSegment
                              + testDataModel.Id;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the container query model URL check invalid when identifier is null.</summary>
        [Fact]
        public void GetContainerQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetContainerQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the document query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetDocumentQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel
            {
                Id = "100",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the document query model URL check invalid when identifier is null.</summary>
        [Fact]
        public void GetDocumentQueryModelUrlCheck_Invalid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the document query model URL check valid when valid model data with version.</summary>
        [Fact]
        public void GetDocumentQueryModelUrlCheck_Valid_WhenValidModelDataWithVersion()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentQueryModel
            {
                Id = "100",
                Version = "100",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + "?version=" + testDataModel.Version;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the document container relationships query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetDocumentContainerRelationshipsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainerRelationshipsQueryModel
            {
                Id = "100",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.ResourcesRelationshipUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the document container relationships query model URL check valid when identifier is null.</summary>
        [Fact]
        public void GetDocumentContainerRelationshipsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainerRelationshipsQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the document containers query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetDocumentContainersQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainersQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentContainerUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the document containers query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetDocumentContainersQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentContainersQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the document translations query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetDocumentTranslationsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentTranslationsQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.DocumentEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentTranslationsUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the document translations query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetDocumentTranslationsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetDocumentTranslationsQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the file query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetFileQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFileQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.FileEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the file query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetFileQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFileQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the folder query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetFolderQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the folder query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetFolderQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the folder children query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetFolderChildrenQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderChildrenQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.FolderChildrenUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the folder children query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetFolderChildrenQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderChildrenQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the folder root query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetFolderRootQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderRootQueryModel();
            var expectedUrl = BaseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + UrlConstants.FolderRootUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the folder translations query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetFolderTranslationsQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderTranslationsQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.FolderEndpointUrlSegment
                              + testDataModel.Id
                              + UrlConstants.DocumentTranslationsUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the folder translations query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetFolderTranslationsQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetFolderTranslationsQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the artefact category query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetArtefactCategoryQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetArtefactCategoryQueryModel();
            var expectedUrl = BaseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the image query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetImageQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetImageQueryModel
            {
                Id = "1",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.ImageEndpointUrlSegment
                              + testDataModel.Id;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the image query model URL check in valid when identifier is null.</summary>
        [Fact]
        public void GetImageQueryModelUrlCheck_InValid_WhenIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetImageQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the search query model URL check valid when valid model data.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelData()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchEndpointUrlSegment
                              + "&term=" + testDataModel.Term;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search query model URL check invalid when term is null.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenTermIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel();
            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the search query model URL check valid when valid model data with page offset.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelDataWithPageOffset()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test",
                PageOffset = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchEndpointUrlSegment
                              + "&term=" + testDataModel.Term
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search query model URL check valid when valid model data with page offset and page limit.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Valid_WhenValidModelDataWithPageOffsetAndPageLimit()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchQueryModel
            {
                Term = "test",
                PageOffset = 1,
                PageLimit = 1,
            };
            var expectedUrl = BaseUrl + UrlConstants.SearchEndpointUrlSegment
                                      + "&term=" + testDataModel.Term
                                      + "&pageOffset=" + testDataModel.PageOffset
                                      + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with page offset.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageOffset()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageOffset = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with page limit.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageLimit()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageLimit = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with page offset and page limit.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithPageOffsetAndPageLimit()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                PageOffset = 1,
                PageLimit = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&pageOffset=" + testDataModel.PageOffset
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with filter.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithFilter()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Filter = "testFilter",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&filter=" + testDataModel.Filter;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with filter.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithChannel()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Channel = "testChannel",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&channel=" + testDataModel.Channel;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with facet.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenSimpleQueryWithFacet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                Facet = "rating",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&simplequery=" + testDataModel.SimpleQuery
                              + "&facet=" + testDataModel.Facet;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when advanced query.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when advanced query with page offset.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageOffset()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageOffset = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageOffset=" + testDataModel.PageOffset;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when advanced query with page limit.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageLimit()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageLimit = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when advanced query with page offset and page limit.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithPageOffsetAndPageLimit()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                PageOffset = 1,
                PageLimit = 1,
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&pageOffset=" + testDataModel.PageOffset
                              + "&pageLimit=" + testDataModel.PageLimit;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when advanced query with filter.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithFilter()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Filter = "testFilter",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&filter=" + testDataModel.Filter;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with filter.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithChannel()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Channel = "testChannel",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&channel=" + testDataModel.Channel;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search artefacts query model URL check valid when simple query with filter.</summary>
        [Fact]
        public void GetSearchArtefactsQueryModelUrlCheck_Valid_WhenAdvancedQueryWithFacet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                AdvancedQuery = "test",
                Facet = "rating",
            };
            var expectedUrl = BaseUrl
                              + UrlConstants.SearchArtefactEndpointUrlSegment
                              + "&advancedquery=" + testDataModel.AdvancedQuery
                              + "&facet=" + testDataModel.Facet;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Gets the search query model URL check invalid when no query.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenNoQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Gets the search query model URL check invalid when both simple query and advanced query.</summary>
        [Fact]
        public void GetSearchQueryModelUrlCheck_Invalid_WhenBothSimpleQueryAndAdvancedQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new GetSearchArtefactsQueryModel
            {
                SimpleQuery = "test",
                AdvancedQuery = "test",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Creates the name of the artefact category command model URL check valid when valid.</summary>
        [Fact]
        public void CreateArtefactCategoryCommandModelUrlCheck_Valid_WhenValidName()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new CreateArtefactCategoryCommandModel
            {
                Name = "test",
            };

            var expectedUrl = BaseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Creates the artefact category command model URL check invalid when name is null.</summary>
        [Fact]
        public void CreateArtefactCategoryCommandModelUrlCheck_Invalid_WhenNameIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new CreateArtefactCategoryCommandModel();

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the CSH command model URL check valid when valid name and query.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the CSH command model URL check valid when valid user identifier and query.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidUserIdAndQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the CSH command model URL check invalid when user name and user identifier both have values.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdBothHaveValues()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the CSH command model URL check invalid when user name and user identifier is null and valid query.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                Query = "testQuery",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the CSH command model URL check invalid when valid user name and query is null.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenValidUserNameAndQueryIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserName = "testUserName",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the CSH command model URL check invalid when valid user identifier and query is null.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Invalid_WhenValidUserIdAndQueryIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the CSH command model URL check valid when valid name and query and show first result flag is set.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagIsSet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the CSH command model URL check valid when valid name and query and show first result flag and maximize client is set.</summary>
        [Fact]
        public void LiveCshCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagAndMaximizeClientIsSet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveCshCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
                MaximizeClient = true,
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveCshUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the document command model URL check valid when valid name and identifier.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndId()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                Id = "testId",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the document command model URL check valid when valid user identifier and identifier.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidUserIdAndId()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the document command model URL check invalid when user name and user identifier have values.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdHaveValues()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the document command model URL check invalid when user name and user identifier is null and valid identifier.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidId()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                Id = "testId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the document command model URL check invalid when valid user name and identifier is null.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenValidUserNameAndIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserName = "testUserName",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the document command model URL check invalid when valid user identifier and identifier is null.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Invalid_WhenValidUserIdAndIdIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the document command model URL check valid when valid name and identifier and location.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndIdAndLocation()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId",
                Location = "testLocation",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the document command model URL check valid when valid name and identifier and maximize client is set.</summary>
        [Fact]
        public void LiveDocumentCommandModelUrlCheck_Valid_WhenValidNameAndIdAndMaximizeClientIsSet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveDocumentCommandModel
            {
                UserId = "testUserId",
                Id = "testId",
                MaximizeClient = true,
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveDocumentUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the search command model URL check valid when valid name and query.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                Query = "testQuery",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the search command model URL check valid when valid user identifier and query.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidUserIdAndQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the search command model URL check invalid when user name and user identifier both have values.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdBothHaveValues()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the search command model URL check invalid when user name and user identifier is null and valid query.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenUserNameAndUserIdIsNullAndValidQuery()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                Query = "testQuery",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the search command model URL check invalid when valid user name and query is null.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenValidUserNameAndQueryIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserName = "testUserName",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the search command model URL check invalid when valid user identifier and query is null.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Invalid_WhenValidUserIdAndQueryIsNull()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";
            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
            };

            Exception ex = Assert.Throws<QueryModelException>(() => this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl));
        }

        /// <summary>Lives the search command model URL check valid when valid name and query and show first result flag is set.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagIsSet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }

        /// <summary>Lives the search command model URL check valid when valid name and query and show first result flag and maximize client is set.</summary>
        [Fact]
        public void LiveSearchCommandModelUrlCheck_Valid_WhenValidNameAndQueryAndShowFirstResultFlagAndMaximizeClientIsSet()
        {
            const string BaseUrl = "https://staging-api.panviva.com/v3/test";

            var testDataModel = new LiveSearchCommandModel
            {
                UserId = "testUserId",
                Query = "testQuery",
                ShowFirstResult = true,
                MaximizeClient = true,
            };

            var expectedUrl = BaseUrl + UrlConstants.LiveSearchUrlSegment;

            var returnedUrl = this.urlConstructor.ConstructRequestUrl(testDataModel, BaseUrl);

            Assert.Equal(expectedUrl, returnedUrl);
        }
    }
}
