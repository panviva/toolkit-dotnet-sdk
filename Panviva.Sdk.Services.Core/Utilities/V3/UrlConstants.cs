// <copyright file="UrlConstants.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities.V3
{
    /// <summary>Constants class for query services.</summary>
    internal static class UrlConstants
    {
        /// <summary>The default base URL.</summary>
        internal const string DefaultBaseUrl = "https://api.panviva.com";

        /// <summary>The Artefact endpoint URL segment.</summary>
        internal const string ArtefactEndpointUrlSegment = "/resources/artefact";

        /// <summary>The document endpoint URL segment.</summary>
        internal const string DocumentEndpointUrlSegment = "/resources/document/";

        /// <summary>The resources container URL segment.</summary>
        internal const string ResourcesContainerUrlSegment = "/resources/container/";

        /// <summary>The file endpoint URL segment.</summary>
        internal const string FileEndpointUrlSegment = "/resources/file/";

        /// <summary>The image endpoint URL segment.</summary>
        internal const string ImageEndpointUrlSegment = "/resources/image/";

        /// <summary>The folder endpoint URL segment.</summary>
        internal const string FolderEndpointUrlSegment = "/resources/folder/";

        /// <summary>The Artefact category endpoint URL segment.</summary>
        internal const string ArtefactCategoryEndpointUrlSegment = "/resources/artefactcategory";

        /// <summary>The search endpoint URL segment.</summary>
        internal const string SearchEndpointUrlSegment = "/operations/search?";

        /// <summary>The search Artefact endpoint URL segment.</summary>
        internal const string SearchArtefactEndpointUrlSegment = "/operations/artefact/nls?";

        /// <summary>The resources relationship URL segment.</summary>
        internal const string ResourcesRelationshipUrlSegment = "/containers/relationships";

        /// <summary>The document container URL segment.</summary>
        internal const string DocumentContainerUrlSegment = "/containers";

        /// <summary>The document translations URL segment.</summary>
        internal const string DocumentTranslationsUrlSegment = "/translations";

        /// <summary>The folder children URL segment.</summary>
        internal const string FolderChildrenUrlSegment = "/children";

        /// <summary>The folder root URL segment.</summary>
        internal const string FolderRootUrlSegment = "/root";

        /// <summary>The live CSH URL segment.</summary>
        internal const string LiveCshUrlSegment = "/operations/live/csh";

        /// <summary>The live Document URL segment.</summary>
        internal const string LiveDocumentUrlSegment = "/operations/live/document";

        /// <summary>The live Search URL segment.</summary>
        internal const string LiveSearchUrlSegment = "/operations/live/search";

        internal struct UrlParameters
        {
            internal const string isDraft = "isDraft";
        }
    }
}
