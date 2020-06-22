using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Facet
    {
        [JsonProperty("Field")]
        public string Field { get; set; }

        [JsonProperty("Groups")]
        public KeyValuePair<string, long?>[] Groups { get; set; }
    }
}