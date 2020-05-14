// <copyright file="Container.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model Container.</summary>
    public partial class Container
    {
        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the Body.</summary>
        /// <value>The Body.</value>
        [JsonProperty("Body")]
        public string Body { get; set; }
    }
}