using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class SearchResult
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        [JsonProperty("Category")]
        public Category Category { get; set; }

        [JsonProperty("MetaData")]
        public Dictionary<string, MetaDataValueDetails> MetaData { get; set; }

        [JsonProperty("SearchScore")]
        public float SearchScore { get; set; }

        [JsonProperty("Links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("QueryVariations")]
        public IEnumerable<QueryVariation> QueryVariations { get; set; }

        [JsonProperty("PrimaryQuery")]
        public string PrimaryQuery { get; set; }

        [JsonProperty("PanvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        [JsonProperty("PanvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }
    }
}