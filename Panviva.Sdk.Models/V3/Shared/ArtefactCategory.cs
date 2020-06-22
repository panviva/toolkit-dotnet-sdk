using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class ArtefactCategory
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }
    }
}