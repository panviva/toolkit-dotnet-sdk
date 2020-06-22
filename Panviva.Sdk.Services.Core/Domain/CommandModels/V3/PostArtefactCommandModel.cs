using System.Collections.Generic;
using Panviva.Sdk.Models.V3.Shared;
using ArtefactCategory = Panviva.Sdk.Models.V3.Post.ArtefactCategory;

namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3
{
    public class PostArtefactCommandModel
    {
        public string Title { get; set; }

        public string PrimaryQuery { get; set; }

        public int PanvivaDocumentId { get; set; }

        public IEnumerable<ArtefactContent> Content { get; set; }

        public ArtefactCategory Category { get; set; }
    }
}