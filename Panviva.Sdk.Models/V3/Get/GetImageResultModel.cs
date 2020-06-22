using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetImageResultModel
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Width")]
        public int? Width { get; set; }

        [JsonProperty("Height")]
        public int? Height { get; set; }

        [JsonProperty("Size")]
        public int? Size { get; set; }

        [JsonProperty("ContentType")]
        public string ContentType { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }
    }
}