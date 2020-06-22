using System.Threading.Tasks;
using Panviva.Sdk.Models.V3.Post;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.CommonModels;

namespace Panviva.Sdk.Services.Core.Handlers.V3
{
    public interface ICommandHandler
    {
        Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel);

        Task<CreateArtefactCategoryResultModel> HandleAsync(CreateArtefactCategoryCommandModel queryModel,
            ApiConfigModel configModel);

        Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel);

        Task<LiveCshResultModel> HandleAsync(LiveCshCommandModel queryModel, ApiConfigModel configModel);

        Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel);

        Task<LiveDocumentResultModel> HandleAsync(LiveDocumentCommandModel queryModel, ApiConfigModel configModel);

        Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel);

        Task<LiveSearchResultModel> HandleAsync(LiveSearchCommandModel queryModel, ApiConfigModel configModel);

        Task<PostArtefactResultModel> HandleAsync(PostArtefactCommandModel postArtefactCommandModel, ApiConfigModel configModel,
            bool isDraft);

        Task<PostArtefactResultModel> HandleAsync(PostArtefactCommandModel postArtefactCommandModel, bool isDraft);
    }
}