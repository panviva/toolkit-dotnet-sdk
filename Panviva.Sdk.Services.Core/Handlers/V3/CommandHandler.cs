// <copyright file="CommandHandler.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>
using Microsoft.Extensions.Configuration;
using Panviva.Sdk.Models.V3.Post;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Requests;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Responses;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Services;
using Panviva.Sdk.Services.Core.Utilities;
using Panviva.Sdk.Services.Core.Utilities.V3;
using System.Threading.Tasks;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{

    /// <summary>Implementation on Command Handler.</summary>
    /// <seealso cref="Panviva.Sdk.Services.Core.Handlers.V3.ICommandHandler" />
    public class CommandHandler : ICommandHandler
    {
        /// <summary>The configuration.</summary>
        private readonly IConfiguration _configuration;

        /// <summary>The Input Validator.</summary>
        private readonly InputValidator _inputValidator;

        /// <summary>The panviva client.</summary>
        private readonly IPanvivaClient _panvivaClient;

        /// <summary>The query URL constructor.</summary>
        private readonly RequestUrlConstructor _requestUrlConstructor;

        /// <summary>The API configuration helper.</summary>
        private readonly ApiConfigHelper _apiConfigHelper;

        /// <summary>Initializes a new instance of the <see cref="CommandHandler"/> class.</summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="panvivaClient">The panviva client.</param>
        /// <param name="requestUrlConstructor">The query URL constructor.</param>
        /// <param name="inputValidator">The input validator.</param>
        /// <param name="apiConfigHelper">The Api config helper.</param>
        public CommandHandler(
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

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        public async Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = await _panvivaClient.PostToPanvivaApi<CreateArtefactCategoryResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api config model.</param>
        /// <returns>Status of Post command.</returns>
        public async Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = await _panvivaClient.PostToPanvivaApi<CreateArtefactCategoryResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveCshResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api config model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveCshResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveDocumentResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api config model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveDocumentResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();
            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();
            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveSearchResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api config model.</param>
        /// <returns>Status of Post command.</returns>
        public Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel, ApiConfigModel configModel)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);
            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);
            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);
            var queryUrl = _requestUrlConstructor.ConstructRequestUrl(queryModel, clientUrl);
            var responseModel = _panvivaClient.PostToPanvivaApi<LiveSearchResultModel>(queryUrl, apiKey, queryModel, retryCount);

            return responseModel;
        }

        public Task<PostArtefactResponse> HandleAsync(PostArtefactRequest postArtefactRequest, ApiConfigModel configModel, bool isDraft)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromModel(configModel);

            var apiKey = _apiConfigHelper.GetApiKeyFromModel(configModel);

            var retryCount = _apiConfigHelper.GetRetryCountFromModel(configModel);

            var queryUrl = _requestUrlConstructor.ConstructPostRequestUrl(clientUrl, isDraft);

            var responseModel = _panvivaClient.PostToPanvivaApi<PostArtefactResponse>(queryUrl, apiKey, postArtefactRequest, retryCount);

            return responseModel;
        }

        public Task<PostArtefactResponse> HandleAsync(PostArtefactRequest postArtefactRequest, bool isDraft)
        {
            var clientUrl = _apiConfigHelper.GetClientUrlFromAppSettings();

            var apiKey = _apiConfigHelper.GetApiKeyFromAppSettings();

            var retryCount = _apiConfigHelper.GetRetryCountFromAppSettings();

            var queryUrl = _requestUrlConstructor.ConstructPostRequestUrl(clientUrl, isDraft: isDraft);

            var responseModel = _panvivaClient.PostToPanvivaApi<PostArtefactResponse>(queryUrl, apiKey, postArtefactRequest, retryCount);

            return responseModel;
        }
    }
}
