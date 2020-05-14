using Panviva.Sdk.Models.V3.Shared;
using System.Collections.Generic;

namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Requests
{
    public class PostArtefactRequest
    {
        public string Title { get; set; }

        public string PrimaryQuery { get; set; }

        public int PanvivaDocumentId { get; set; }

        public IEnumerable<ArtefactContent> Content { get; set; }

        public Models.V3.Post.ArtefactCategory Category { get; set; }
    }
}
