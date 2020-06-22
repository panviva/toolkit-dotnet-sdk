using System.Threading.Tasks;
using Panviva.Sdk.Models.V3.Get;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    public interface IQueryHandler
    {
        Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel);

        Task<GetArtefactResultModel> HandleAsync(GetArtefactQueryModel queryModel, ApiConfigModel configModel);

        Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel);

        Task<GetContainerResultModel> HandleAsync(GetContainerQueryModel queryModel, ApiConfigModel configModel);

        Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel);

        Task<GetDocumentResultModel> HandleAsync(GetDocumentQueryModel queryModel, ApiConfigModel configModel);

        Task<GetDocumentContainerRelationshipsResultModel>
            HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel);

        Task<GetDocumentContainerRelationshipsResultModel>
            HandleAsync(GetDocumentContainerRelationshipsQueryModel queryModel, ApiConfigModel configModel);

        Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel);

        Task<GetDocumentContainersResultModel> HandleAsync(GetDocumentContainersQueryModel queryModel,
            ApiConfigModel configModel);

        Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel);

        Task<GetDocumentTranslationsResultModel> HandleAsync(GetDocumentTranslationsQueryModel queryModel,
            ApiConfigModel configModel);

        Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel);

        Task<GetFileResultModel> HandleAsync(GetFileQueryModel queryModel, ApiConfigModel configModel);

        Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel);

        Task<GetFolderResultModel> HandleAsync(GetFolderQueryModel queryModel, ApiConfigModel configModel);

        Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel);

        Task<GetFolderChildrenResultModel> HandleAsync(GetFolderChildrenQueryModel queryModel,
            ApiConfigModel configModel);

        Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel);

        Task<GetFolderRootResultModel> HandleAsync(GetFolderRootQueryModel queryModel, ApiConfigModel configModel);

        Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel);

        Task<GetFolderTranslationsResultModel> HandleAsync(GetFolderTranslationsQueryModel queryModel,
            ApiConfigModel configModel);

        Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel);

        Task<GetArtefactCategoryResultModel> HandleAsync(GetArtefactCategoryQueryModel queryModel,
            ApiConfigModel configModel);

        Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel);

        Task<GetImageResultModel> HandleAsync(GetImageQueryModel queryModel, ApiConfigModel configModel);

        Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel);

        Task<GetSearchResultModel> HandleAsync(GetSearchQueryModel queryModel, ApiConfigModel configModel);

        Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel);

        Task<GetSearchArtefactResultModel> HandleAsync(GetSearchArtefactsQueryModel queryModel,
            ApiConfigModel configModel);
    }
}