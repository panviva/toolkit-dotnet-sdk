using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class QueryVariation
    {
        [JsonProperty("Query")]
        public string Query { get; set; }
    }
}