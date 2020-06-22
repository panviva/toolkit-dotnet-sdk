using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Channel
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}