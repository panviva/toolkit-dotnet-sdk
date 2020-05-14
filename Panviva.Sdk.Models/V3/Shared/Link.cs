// <copyright file="Link.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using Newtonsoft.Json;

    /// <summary>Shared Model LinkModel.</summary>
    public partial class Link
    {
        /// <summary>Gets or sets the Href.</summary>
        /// <value>The Href.</value>
        [JsonProperty("Href")]
        public string Href { get; set; }

        /// <summary>Gets or sets the Rel.</summary>
        /// <value>The Relation.</value>
        [JsonProperty("Rel")]
        public string Rel { get; set; }

        /// <summary>Gets or sets the Type.</summary>
        /// <value>The Type.</value>
        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}
