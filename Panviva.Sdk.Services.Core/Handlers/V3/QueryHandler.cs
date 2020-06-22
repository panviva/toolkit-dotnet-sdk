using System.Threading.Tasks;
using Panviva.Sdk.Models.V3.Get;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities.V3;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    public class QueryHandler : IQueryHandler
    {
        private readonly ApiConfigHelper _apiConfigHelper;

        private readonly IPanvivaClient _panvivaClient;

        private readonly RequestUrlConstructor _requestUrlConstructor;


        public QueryHandler(
            IPanvivaClient panvivaClient,
            RequestUrlConstructor requestUrlConstructor,
            ApiConfigHelper apiConfigHelper)
        {
            _panvivaClient = panvivaClient;
            _requestUrlConstructor = requestUrlConstructor;
            _apiConfigHelper = apiConfigHelper;
        }

        public async Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetContainerResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetContainerResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetDocumentContainerRelationshipsResultModel> HandleAsync(
            GetDocumentContainerRelationshipsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(queryUrl, apiKey,
                    retryCount);

            return returnObject;
        }

        public async Task<GetDocumentContainerRelationshipsResultModel> HandleAsync(
            GetDocumentContainerRelationshipsQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentContainerRelationshipsResultModel>(queryUrl, apiKey,
                    retryCount);

            return returnObject;
        }

        public async Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentContainersResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentContainersResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(queryUrl, apiKey,
                    retryCount);

            return returnObject;
        }

        public async Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetDocumentTranslationsResultModel>(queryUrl, apiKey,
                    retryCount);

            return returnObject;
        }

        public async Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFileResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject = await _panvivaClient.GetFromPanvivaApi<GetFileResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderChildrenResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderChildrenResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderRootResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderRootResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetFolderTranslationsResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetArtefactCategoryResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetArtefactCategoryResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetImageResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetImageResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetSearchResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetSearchResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetSearchArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }

        public async Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var returnObject =
                await _panvivaClient.GetFromPanvivaApi<GetSearchArtefactResultModel>(queryUrl, apiKey, retryCount);

            return returnObject;
        }
    }
}