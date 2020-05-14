// <copyright file="RequestUrlConstructor.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Extensions;
using System.Runtime.CompilerServices;
using System.Web;


[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities.V3
{

    /// <summary>
    /// Helper functions fro Query Model.
    /// </summary>
    public class RequestUrlConstructor
    {
        /// <summary>The configuration.</summary>
        private readonly IConfiguration configuration;

        /// <summary>Initializes a new instance of the <see cref="RequestUrlConstructor"/> class.</summary>
        /// <param name="configuration">The configuration.</param>
        public RequestUrlConstructor(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
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

            return baseUrl + UrlConstants.ArtefactEndpointUrlSegment.AddParameterToUrl(UrlConstants.UrlParameters.isDraft, isDraft.ToString());
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetContainerQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.ResourcesContainerUrlSegment + model.Id;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetDocumentQueryModel model, string baseUrl)
        {
            baseUrl += UrlConstants.DocumentEndpointUrlSegment;

            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            var id = HttpUtility.UrlEncode(model.Id);
            return model.Version == null ? $"{baseUrl}{id}" : QueryHelpers.AddQueryString($"{baseUrl}{id}", "version", $"{model.Version}");
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetDocumentContainerRelationshipsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id + UrlConstants.ResourcesRelationshipUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetDocumentContainersQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id + UrlConstants.DocumentContainerUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetDocumentTranslationsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.DocumentEndpointUrlSegment + model.Id + UrlConstants.DocumentTranslationsUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetFileQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FileEndpointUrlSegment + model.Id;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetFolderQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetFolderChildrenQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id + UrlConstants.FolderChildrenUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetFolderRootQueryModel model, string baseUrl)
        {
            return baseUrl + UrlConstants.FolderEndpointUrlSegment + UrlConstants.FolderRootUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetFolderTranslationsQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.FolderEndpointUrlSegment + model.Id + UrlConstants.DocumentTranslationsUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetArtefactCategoryQueryModel model, string baseUrl)
        {
            return baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Value of ID field is invalid.</exception>
        internal string ConstructRequestUrl(GetImageQueryModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                throw new QueryModelException("Error : Id field can not be NULL.");
            }

            return baseUrl + UrlConstants.ImageEndpointUrlSegment + model.Id;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base url.</param>
        /// <returns>valid url.</returns>
        /// <exception cref="QueryModelException">Error : Term must not be NULL.</exception>
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

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base Url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Both Simple Query and Advanced Query can not have values.</exception>
        internal string ConstructRequestUrl(GetSearchArtefactsQueryModel model, string baseUrl)
        {
            var urlWithParameters = baseUrl + UrlConstants.SearchArtefactEndpointUrlSegment;

            if (string.IsNullOrWhiteSpace(model?.SimpleQuery) && string.IsNullOrWhiteSpace(model?.AdvancedQuery))
            {
                throw new QueryModelException("Error : Both Simple Query and Advanced Query fields can not be NULL.");
            }

            if (!string.IsNullOrWhiteSpace(model?.SimpleQuery) && !string.IsNullOrWhiteSpace(model?.AdvancedQuery))
            {
                throw new QueryModelException("Error : Both Simple Query and Advanced Query fields can not have values.");
            }

            if (!string.IsNullOrWhiteSpace(model?.SimpleQuery))
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "simplequery", $"{model.SimpleQuery}");
            }
            else
            {
                urlWithParameters = QueryHelpers.AddQueryString(urlWithParameters, "advancedquery", $"{model.AdvancedQuery}");
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

        // Commands Section

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">Base Url.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : Both Simple Query and Advanced Query can not have values.</exception>
        internal string ConstructRequestUrl(CreateArtefactCategoryCommandModel model, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(model?.Name))
            {
                throw new QueryModelException("Error : Name field can not be NULL.");
            }

            return baseUrl + UrlConstants.ArtefactCategoryEndpointUrlSegment;
        }

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : One or More Fields must not be NULL.</exception>
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

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : One or More Fields must not be NULL.</exception>
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

        /// <summary>Constructs the request URL.</summary>
        /// <param name="model">The model.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns>Valid Url.</returns>
        /// <exception cref="QueryModelException">Error : One or More Fields must not be NULL.</exception>
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
