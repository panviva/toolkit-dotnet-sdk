using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ResourceSearchResult
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("MatchedFields")]
        public IList<string> MatchedFields { get; set; }

        [JsonProperty("Snippet")]
        public string Snippet { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }

        [JsonProperty("Layout")]
        public string Layout { get; set; }

        [JsonProperty("Classification")]
        public string Classification { get; set; }

        [JsonProperty("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [JsonProperty("FileName")]
        public string FileName { get; set; }
    }
}