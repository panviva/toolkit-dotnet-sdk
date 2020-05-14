// <copyright file="GetDocumentContainersResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;
    using Container = Panviva.Sdk.Models.V3.Shared.Container;

    /// <summary>Response Model for GetDocumentContainers endpoint.</summary>
    public class GetDocumentContainersResultModel
    {
        /// <summary>Gets or sets the Containers.</summary>
        /// <value>The Containers.</value>
        [JsonProperty("Containers")]
        public IList<Container> Containers { get; set; }
    }
}