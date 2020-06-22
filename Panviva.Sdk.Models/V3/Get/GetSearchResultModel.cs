using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetSearchResultModel : ISearchPayload<ResourceSearchResult>
    {
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }

        [JsonProperty("Results")]
        public IList<ResourceSearchResult> Results { get; set; }

        [JsonProperty("Total")]
        public int? Total { get; set; }
    }
}