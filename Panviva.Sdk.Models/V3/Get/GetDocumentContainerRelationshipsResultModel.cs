// <copyright file="GetDocumentContainerRelationshipsResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetDocumentContainerRelationships endpoint.</summary>
    public class GetDocumentContainerRelationshipsResultModel
    {
        /// <summary>Gets or sets the Relationships.</summary>
        /// <value>The Relationships.</value>
        [JsonProperty("Relationships")]
        public IList<ContainerRelationship> Relationships { get; set; }
    }
}