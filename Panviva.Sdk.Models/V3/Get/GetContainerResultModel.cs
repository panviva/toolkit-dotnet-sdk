using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetContainerResultModel
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }
    }
}