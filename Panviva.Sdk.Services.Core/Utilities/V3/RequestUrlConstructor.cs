using System.Runtime.CompilerServices;
using System.Web;
using Microsoft.AspNetCore.WebUtilities;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Extensions;

[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities.V3
{
    public class RequestUrlConstructor
    {
        internal string ConstructRequestUrl(GetArtefactQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.ArtefactEndpointUrlSegment.AddSegmentToUrl(model.Id);
        }

        internal string ConstructPostRequestUrl(string baseUrl, bool isDraft)
        {
            if (!isDraft)
            {
                return baseUrl + UrlConstants.ArtefactEndpointUrlSegment;
            }

            return baseUrl + UrlConstants.ArtefactEndpointUrlSegment.AddParameterToUrl(
                UrlConstants.UrlParameters.IsDraft, isDraft.ToString());
        }

        internal string ConstructRequestUrl(GetContainerQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.ResourcesContainerUrlSegment + model.Id;
        }

        internal string ConstructRequestUrl(GetDocumentQueryModel model, string baseUrl)
        {
            baseUrl += UrlConstants.DocumentEndpointUrlSegment;

            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            var id = HttpUtility.UrlEncode(model.Id);
            return model.Version == null
                ? $"{baseUrl}{id}"
                : QueryHelpers.AddQueryString($"{baseUrl}{id}", "version", $"{model.Version}");
        }

        internal string ConstructRequestUrl(GetDocumentContainerRelationshipsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id +
                   UrlConstants.ResourcesRelationshipUrlSegment;
        }

        internal string ConstructRequestUrl(GetDocumentContainersQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id +
                   UrlConstants.DocumentContainerUrlSegment;
        }

        internal string ConstructRequestUrl(GetDocumentTranslationsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id +
                   UrlConstants.DocumentTranslationsUrlSegment;
        }

        internal string ConstructRequestUrl(GetFileQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FileEndpointUrlSegment + model.Id;
        }

        internal string ConstructRequestUrl(GetFolderQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id;
        }

        internal string ConstructRequestUrl(GetFolderChildrenQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id + UrlConstants.FolderChildrenUrlSegment;
        }

        internal string ConstructRequestUrl(GetFolderRootQueryModel model, string baseUrl)
        {
            return baseUrl + UrlConstants.FolderEndpointUrlSegment + UrlConstants.FolderRootUrlSegment;
        }

        internal string ConstructRequestUrl(GetFolderTranslationsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id +
                   UrlConstants.DocumentTranslationsUrlSegment;
        }

        internal string ConstructRequestUrl(GetArtefactCategoryQueryModel model, string baseUrl)
        {
            return baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;
        }

        internal string ConstructRequestUrl(GetImageQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.ImageEndpointUrlSegment + model.Id;
        }

        internal string ConstructRequestUrl(GetSearchQueryModel model, string baseUrl)
        {
            var urlWithParameters = baseUrl + UrlConstants.SearchEndpointUrlSegment;

            if (string.IsNullOrWhiteSpace(model?.Term))
            {
                throw new QueryModelException("Error : Term field can not be NULL.");
            }

            urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "term", $"{model.Term}");

            if (model.PageOffset != null)
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "pageOffset", $"{model.PageOffset}");
            }

            if (model.PageLimit != null)
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "pageLimit", $"{model.PageLimit}");
            }

            return urlWithParameters;
        }

        internal string ConstructRequestUrl(GetSearchArtefactsQueryModel model, string baseUrl)
        {
            var urlWithParameters = baseUrl + UrlConstants.SearchArtefactEndpointUrlSegment;

            if (string.IsNullOrWhiteSpace(model?.SimpleQuery) && string.IsNullOrWhiteSpace(model?.AdvancedQuery))
            {
                throw new QueryModelException("Error : Both Simple Query and Advanced Query fields can not be NULL.");
            }

            if (!string.IsNullOrWhiteSpace(model?.SimpleQuery) && !string.IsNullOrWhiteSpace(model?.AdvancedQuery))
            {
                throw new QueryModelException(
                    "Error : Both Simple Query and Advanced Query fields can not have values.");
            }

            if (!string.IsNullOrWhiteSpace(model?.SimpleQuery))
            {
                urlWithParameters =
                    QueryHelpers.AddQueryString(urlWithParameters, "simplequery", $"{model.SimpleQuery}");
            }
            else
            {
                urlWithParameters =
                    QueryHelpers.AddQueryString(urlWithParameters, "advancedquery", $"{model.AdvancedQuery}");
            }

            if (!string.IsNullOrWhiteSpace(model?.Filter))
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "filter", $"{model.Filter}");
            }

            if (!string.IsNullOrWhiteSpace(model?.Channel))
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "channel", $"{model.Channel}");
            }

            if (model.PageOffset != null)
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "pageOffset", $"{model.PageOffset}");
            }

            if (model.PageLimit != null)
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "pageLimit", $"{model.PageLimit}");
            }

            if (!string.IsNullOrWhiteSpace(model?.Facet))
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "facet", $"{model.Facet}");
            }

            return urlWithParameters;
        }

        internal string ConstructRequestUrl(CreateArtefactCategoryCommandModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Name))
            {
                throw new QueryModelException("Error : Name field can not be NULL.");
            }

            return baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;
        }

        internal string ConstructRequestUrl(LiveCshCommandModel model, string baseUrl)
        {
            if (!string.IsNullOrWhiteSpace(model?.UserName) && !string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Both Username and UserId fields can not have values.");
            }

            if (string.IsNullOrWhiteSpace(model?.UserName) && string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Username and UserId both can not be NULL.");
            }

            if (string.IsNullOrWhiteSpace(model?.Query))
            {
                throw new QueryModelException("Error : Query field can not be NULL.");
            }

            return baseUrl + UrlConstants.LiveCshUrlSegment;
        }

        internal string ConstructRequestUrl(LiveDocumentCommandModel model, string baseUrl)
        {
            if (!string.IsNullOrWhiteSpace(model?.UserName) && !string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Username and UserId both can not have values.");
            }

            if (string.IsNullOrWhiteSpace(model?.UserName) && string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Username and UserId both can not be null.");
            }

            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field must not be NULL.");
            }

            return baseUrl + UrlConstants.LiveDocumentUrlSegment;
        }

        internal string ConstructRequestUrl(LiveSearchCommandModel model, string baseUrl)
        {
            if (!string.IsNullOrWhiteSpace(model?.UserName) && !string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Username and UserId both can not have values.");
            }

            if (string.IsNullOrWhiteSpace(model?.UserName) && string.IsNullOrWhiteSpace(model?.UserId))
            {
                throw new QueryModelException("Error : Username and UserId both can not be null.");
            }

            if (string.IsNullOrWhiteSpace(model?.Query))
            {
                throw new QueryModelException("Error : Query field must not be NULL.");
            }

            return baseUrl + UrlConstants.LiveSearchUrlSegment;
        }
    }
}