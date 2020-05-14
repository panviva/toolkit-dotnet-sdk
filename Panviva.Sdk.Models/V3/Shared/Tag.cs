// <copyright file="Tag.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using Newtonsoft.Json;

    /// <summary>Shared Model Tag.</summary>
    public partial class Tag
    {
        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the Value.</summary>
        /// <value>The Value.</value>
        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}