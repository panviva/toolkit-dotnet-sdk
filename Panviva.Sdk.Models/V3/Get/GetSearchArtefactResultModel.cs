using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetSearchArtefactResultModel : ISearchPayload<SearchResult>
    {
        [JsonProperty("Facets")]
        public IEnumerable<Facet> Facets { get; set; }

        [JsonProperty("Results")]
        public IList<SearchResult> Results { get; set; }

        [JsonProperty("Total")]
        public int? Total { get; set; }
    }
}