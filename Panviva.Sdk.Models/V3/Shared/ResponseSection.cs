using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ResponseSection
    {
        [JsonProperty("MediaType")]
        public string MediaType { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("Href")]
        public string Href { get; set; }

        [JsonProperty("ResourceLocation")]
        public string ResourceLocation { get; set; }
    }
}