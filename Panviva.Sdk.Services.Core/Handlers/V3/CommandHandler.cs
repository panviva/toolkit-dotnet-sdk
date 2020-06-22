using System.Threading.Tasks;
using Panviva.Sdk.Models.V3.Post;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities.V3;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    public class CommandHandler : ICommandHandler
    {
        private readonly ApiConfigHelper _apiConfigHelper;

        private readonly IPanvivaClient _panvivaClient;

        private readonly RequestUrlConstructor _requestUrlConstructor;

        public CommandHandler(
            IPanvivaClient panvivaClient,
            RequestUrlConstructor requestUrlConstructor,
            ApiConfigHelper apiConfigHelper)
        {
            _panvivaClient = panvivaClient;
            _requestUrlConstructor = requestUrlConstructor;
            _apiConfigHelper = apiConfigHelper;
        }

        public async Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                await _panvivaClient.PostToPanvivaApi<CreateArtefactCategoryResultModel>(queryUrl, apiKey, queryModel,
                    retryCount);

            return responseModel;
        }

        public async Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                await _panvivaClient.PostToPanvivaApi<CreateArtefactCategoryResultModel>(queryUrl, apiKey, queryModel,
                    retryCount);

            return responseModel;
        }

        public Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveCshResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveCshResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveDocumentResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel,
            ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveDocumentResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveSearchResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<LiveSearchResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<PostArtefactResultModel> HandleAsync(PostArtefactCommandModel postArtefactCommandModel,
            ApiConfigModel configModel, bool isDraft)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructPostRequestUrl(clientUrl, isDraft);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<PostArtefactResultModel>(queryUrl, apiKey, postArtefactCommandModel,
                    retryCount);

            return responseModel;
        }

        public Task<PostArtefactResultModel> HandleAsync(PostArtefactCommandModel postArtefactCommandModel,
            bool isDraft)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructPostRequestUrl(clientUrl, isDraft);
            var responseModel =
                _panvivaClient.PostToPanvivaApi<PostArtefactResultModel>(queryUrl, apiKey, postArtefactCommandModel,
                    retryCount);

            return responseModel;
        }
    }
}