using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Post
{
    public class CreateArtefactCategoryResultModel
    {
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }
}