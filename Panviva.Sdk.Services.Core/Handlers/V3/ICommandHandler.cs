// <copyright file="ICommandHandler.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    using Panviva.Sdk.Models.V3.Post;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Requests;
    using Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Responses;
    using Panviva.Sdk.Services.Core.Domain.CommonModels;
    using System.Threading.Tasks;

    /// <summary> <para>Interface for Command handler.</para></summary>
    public interface ICommandHandler
    {
        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api configuration model.</param>
        /// <returns>Status of Post command.</returns>
        Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api configuration model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api configuration model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel);

        /// <summary>Handles the asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The Api configuration model.</param>
        /// <returns>Status of Post command.</returns>
        Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel, ApiConfigModel configModel);

        Task<PostArtefactResponse> HandleAsync(PostArtefactRequest postArtefactRequest, ApiConfigModel configModel, bool isDraft);

        Task<PostArtefactResponse> HandleAsync(PostArtefactRequest postArtefactRequest, bool isDraft);
    }
}
