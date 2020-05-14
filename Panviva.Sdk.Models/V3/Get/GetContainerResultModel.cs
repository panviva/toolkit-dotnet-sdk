// <copyright file="GetContainerResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using Newtonsoft.Json;

    /// <summary>Response Model for GetContainer endpoint.</summary>
    public class GetContainerResultModel
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the body.</summary>
        /// <value>The body.</value>
        [JsonProperty("Body")]
        public string Body { get; set; }
    }
}
