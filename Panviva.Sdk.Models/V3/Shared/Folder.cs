using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Folder : Resource
    {
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }
    }
}