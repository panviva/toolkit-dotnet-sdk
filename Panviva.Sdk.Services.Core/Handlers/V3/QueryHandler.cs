// <copyright file="QueryHandler.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>
using Microsoft.Extensions.Configuration;
using Panviva.Sdk.Models.V3.Get;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities;
using Panviva.Sdk.Services.Core.Utilities.V3;
using System.Threading.Tasks;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    /// <summary>Query Handler implementation.</summary>
    /// <seealso cref="IQueryHandler" />
    public class QueryHandler : IQueryHandler
    {
        private readonly IConfiguration _configuration;

        private readonly InputValidator _inputValidator;

        private readonly IPanvivaClient _panvivaClient;

        private readonly RequestUrlConstructor _requestUrlConstructor;

        private readonly ApiConfigHelper _apiConfigHelper;


        public QueryHandler(
            IConfiguration configuration,
            IPanvivaClient panvivaClient,
            RequestUrlConstructor requestUrlConstructor,
            InputValidator inputValidator,
            ApiConfigHelper apiConfigHelper)
        {
            _configuration = configuration;

            _inputValidator = inputValidator;

            _panvivaClient = panvivaClient;

            _requestUrlConstructor = requestUrlConstructor;

            _apiConfigHelper = apiConfigHelper;
        }

        /// <summary>Handles the get Artefact endpoint asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get Artefact endpoint asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetContainerResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetContainerResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document container asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentContainerRelationshipsResultModel> HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document container asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentContainerRelationshipsResultModel> HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentContainersResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentContainersResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get document translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get file query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFileResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get file query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFileResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder children asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderChildrenResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder children asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderChildrenResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder root asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderRootResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder root asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderRootResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get folder translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFolderTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get artefact category asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetArtefactCategoryResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get artefact category asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetArtefactCategoryResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get image query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetImageResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get image query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetImageResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get search query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetSearchResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get search query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetSearchResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get search artefact query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetSearchArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        /// <summary>Handles the get search artefact query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api Config Model.</param>
        /// <returns>Result Model.</returns>
        public async Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetSearchArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }
    }
}
