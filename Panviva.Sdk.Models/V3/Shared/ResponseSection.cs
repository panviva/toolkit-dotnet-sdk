// <copyright file="ResponseSection.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using Newtonsoft.Json;

    /// <summary>Shared Model ResponseSection.</summary>
    public partial class ResponseSection
    {
        /// <summary>Gets or sets the MediaType.</summary>
        /// <value>The MediaType.</value>
        [JsonProperty("MediaType")]
        public string MediaType { get; set; }

        /// <summary>Gets or sets the Text.</summary>
        /// <value>The Text.</value>
        [JsonProperty("Text")]
        public string Text { get; set; }

        /// <summary>Gets or sets the Href.</summary>
        /// <value>The Href.</value>
        [JsonProperty("Href")]
        public string Href { get; set; }

        /// <summary>Gets or sets the ResourceLocation.</summary>
        /// <value>The ResourceLocation.</value>
        [JsonProperty("ResourceLocation")]
        public string ResourceLocation { get; set; }
    }
}