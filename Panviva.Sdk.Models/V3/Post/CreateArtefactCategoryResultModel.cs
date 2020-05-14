// <copyright file="CreateArtefactCategoryResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Post
{
    using Newtonsoft.Json;

    /// <summary>Response Model for PostSampleModel endpoint.</summary>
    public class CreateArtefactCategoryResultModel
    {
        /// <summary>Gets or sets the results.</summary>
        /// <value>The results.</value>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>Gets or sets the total.</summary>
        /// <value>The total.</value>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }
}