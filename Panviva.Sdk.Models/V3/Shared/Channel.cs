// <copyright file="Channel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model Channel.</summary>
    public partial class Channel
    {
        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}