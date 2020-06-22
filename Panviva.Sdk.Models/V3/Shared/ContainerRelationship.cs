using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ContainerRelationship
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Parent")]
        public string Parent { get; set; }

        [JsonProperty("Children")]
        public IList<string> Children { get; set; }

        [JsonProperty("TaskFlow")]
        public string TaskFlow { get; set; }
    }
}