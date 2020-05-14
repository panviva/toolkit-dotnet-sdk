// <copyright file="ContainerRelationship.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model ContainerRelationship.</summary>
    public partial class ContainerRelationship
    {
        /// <summary>Gets or sets the Href.</summary>
        /// <value>The Href.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the Parent.</summary>
        /// <value>The Parent.</value>
        [JsonProperty("Parent")]
        public string Parent { get; set; }

        /// <summary>Gets or sets the Children.</summary>
        /// <value>The Children.</value>
        [JsonProperty("Children")]
        public IList<string> Children { get; set; }

        /// <summary>Gets or sets the TaskFlow.</summary>
        /// <value>The TaskFlow.</value>
        [JsonProperty("TaskFlow")]
        public string TaskFlow { get; set; }
    }
}