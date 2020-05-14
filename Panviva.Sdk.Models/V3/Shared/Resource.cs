// <copyright file="Resource.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model Resource.</summary>
    public partial class Resource
    {
        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the Description.</summary>
        /// <value>The Description.</value>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>Gets or sets the Version.</summary>
        /// <value>The Version.</value>
        [JsonProperty("Version")]
        public int? Version { get; set; }

        /// <summary>Gets or sets the Language.</summary>
        /// <value>The Language.</value>
        [JsonProperty("Language")]
        public string Language { get; set; }

        /// <summary>Gets or sets the Tags.</summary>
        /// <value>The Tags.</value>
        [JsonProperty("Tags")]
        public IList<Tag> Tags { get; set; }

        /// <summary>Gets or sets the Hidden.</summary>
        /// <value>The Hidden.</value>
        [JsonProperty("Hidden")]
        public bool? Hidden { get; set; }

        /// <summary>Gets or sets the Source.</summary>
        /// <value>The Source.</value>
        [JsonProperty("Source")]
        public string Source { get; set; }

        /// <summary>Gets or sets the Type.</summary>
        /// <value>The Type.</value>
        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}
