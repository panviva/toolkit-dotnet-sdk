// <copyright file="Folder.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model Folder.</summary>
    public partial class Folder : Resource
    {
        /// <summary>Gets or sets the Links.</summary>
        /// <value>The Links.</value>
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }
    }
}