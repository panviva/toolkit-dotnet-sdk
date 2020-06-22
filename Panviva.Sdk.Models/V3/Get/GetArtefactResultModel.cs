using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetArtefactResultModel
    {
        [JsonProperty("Links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        [JsonProperty("Variations")]
        public IEnumerable<ResponseVariation> Variations { get; set; }

        [JsonProperty("Category")]
        public Category Category { get; set; }

        [JsonProperty("PrimaryQuery")]
        public string PrimaryQuery { get; set; }

        [JsonProperty("QueryVariations")]
        public IEnumerable<QueryVariation> QueryVariations { get; set; }

        [JsonProperty("PanvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        [JsonProperty("PanvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        [JsonProperty("MetaData")]
        public Dictionary<string, MetaDataValueDetails> MetaData { get; set; }

        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("DateModified")]
        public DateTimeOffset? DateModified { get; set; }
    }
}