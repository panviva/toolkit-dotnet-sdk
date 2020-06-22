using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class MetaDataValueDetails
    {
        [JsonProperty("Values")]
        public string[] Value { get; set; }

        [JsonProperty("DataType")]
        public string DataType { get; set; }
    }
}