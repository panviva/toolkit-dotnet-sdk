using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Category : BaseEntity<int>
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}