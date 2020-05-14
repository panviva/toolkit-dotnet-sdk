// <copyright file="IQueryHandler.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    using System.Threading.Tasks;
    using Panviva.Sdk.Models.V3.Get;
    using Panviva.Sdk.Services.Core.Domain.CommonModels;
    using Panviva.Sdk.Services.Core.Domain.QueryModels;
    using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;

    /// <summary>Query Handler Interface.</summary>
    public interface IQueryHandler
    {
        /// <summary>Handles the get Artefact endpoint asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel);

        /// <summary>Handles the get Artefact endpoint asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel);

        /// <summary>Handles the get container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get document query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel);

        /// <summary>Handles the get document query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get document container asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentContainerRelationshipsResultModel>
            HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel);

        /// <summary>Handles the get document container asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentContainerRelationshipsResultModel>
            HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get document container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel);

        /// <summary>Handles the get document container query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get document translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel);

        /// <summary>Handles the get document translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get file query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel);

        /// <summary>Handles the get file query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get folder query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel);

        /// <summary>Handles the get folder query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get folder children asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel);

        /// <summary>Handles the get folder children asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get folder root asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel);

        /// <summary>Handles the get folder root asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get folder translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel);

        /// <summary>Handles the get folder translations asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get artefact category asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel);

        /// <summary>Handles the get artefact category asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get image query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel);

        /// <summary>Handles the get image query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get search query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel);

        /// <summary>Handles the get search query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel, ApiConfigModel configModel);

        /// <summary>Handles the get search artefact query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <returns>Result Model.</returns>
        Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel);

        /// <summary>Handles the get search artefact query asynchronous.</summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="configModel">The api configuration model.</param>
        /// <returns>Result Model.</returns>
        Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel, ApiConfigModel configModel);
    }
}
