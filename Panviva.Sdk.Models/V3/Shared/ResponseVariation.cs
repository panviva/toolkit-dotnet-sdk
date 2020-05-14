// <copyright file="ResponseVariation.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model ResponseVariation.</summary>
    public partial class ResponseVariation : BaseEntity<int>
    {
        /// <summary>Gets or sets the Content.</summary>
        /// <value>The Content.</value>
        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        /// <summary>Gets or sets the Channels.</summary>
        /// <value>The Channels.</value>
        [JsonProperty("Channels")]
        public IEnumerable<Channel> Channels { get; set; }
    }
}