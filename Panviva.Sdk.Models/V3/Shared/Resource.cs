using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Resource
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Version")]
        public int? Version { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("Tags")]
        public IList<Tag> Tags { get; set; }

        [JsonProperty("Hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}