using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ResponseVariation : BaseEntity<int>
    {
        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        [JsonProperty("Channels")]
        public IEnumerable<Channel> Channels { get; set; }
    }
}