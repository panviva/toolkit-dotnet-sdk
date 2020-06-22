using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Link
    {
        [JsonProperty("Href")]
        public string Href { get; set; }

        [JsonProperty("Rel")]
        public string Rel { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}