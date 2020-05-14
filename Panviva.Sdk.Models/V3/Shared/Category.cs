// <copyright file="Category.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using Newtonsoft.Json;

    /// <summary>Shared Model Category.</summary>
    public class Category : BaseEntity<int>
    {
        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}