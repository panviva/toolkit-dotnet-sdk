using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Panviva.Sdk.Services.Core.Tests")]

namespace Panviva.Sdk.Services.Core.Utilities.V3
{
    internal static class UrlConstants
    {
        internal const string DefaultBaseUrl = "https://api.panviva.com";

        internal const string ArtefactEndpointUrlSegment = "/resources/artefact";

        internal const string DocumentEndpointUrlSegment = "/resources/document/";

        internal const string ResourcesContainerUrlSegment = "/resources/container/";

        internal const string FileEndpointUrlSegment = "/resources/file/";

        internal const string ImageEndpointUrlSegment = "/resources/image/";

        internal const string FolderEndpointUrlSegment = "/resources/folder/";

        internal const string ArtefactCategoryEndpointUrlSegment = "/resources/artefactcategory";

        internal const string SearchEndpointUrlSegment = "/operations/search?";

        internal const string SearchArtefactEndpointUrlSegment = "/operations/artefact/nls?";

        internal const string ResourcesRelationshipUrlSegment = "/containers/relationships";

        internal const string DocumentContainerUrlSegment = "/containers";

        internal const string DocumentTranslationsUrlSegment = "/translations";

        internal const string FolderChildrenUrlSegment = "/children";

        internal const string FolderRootUrlSegment = "/root";

        internal const string LiveCshUrlSegment = "/operations/live/csh";

        internal const string LiveDocumentUrlSegment = "/operations/live/document";

        internal const string LiveSearchUrlSegment = "/operations/live/search";

        internal struct UrlParameters
        {
            internal const string IsDraft = "isDraft";
        }
    }
}