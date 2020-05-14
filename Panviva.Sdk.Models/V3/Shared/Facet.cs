// <copyright file="Facet.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>Facet model calss.</summary>
    public class Facet
    {
        /// <summary>Gets or sets the field.</summary>
        /// <value>The field.</value>
        [JsonProperty("Field")]
        public string Field { get; set; }

        /// <summary>Gets or sets the groups.</summary>
        /// <value>The groups.</value>
        [JsonProperty("Groups")]
        public KeyValuePair<string, long?>[] Groups { get; set; }
    }
}
