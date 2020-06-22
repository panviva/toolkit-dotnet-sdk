using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ArtefactContent
    {
        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("MediaType")]
        public string MediaType { get; set; }

        [JsonProperty("ResourceLocation")]
        public string ResourceLocation { get; set; }
    }
}