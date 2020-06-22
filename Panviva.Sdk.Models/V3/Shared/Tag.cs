using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Tag
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}