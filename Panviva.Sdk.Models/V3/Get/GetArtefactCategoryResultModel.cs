// <copyright file="GetArtefactCategoryResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetArtefactCategoryResultModel endpoint.</summary>
    public class GetArtefactCategoryResultModel
    {
        /// <summary>Gets or sets the Categories.</summary>
        /// <value>The Categories.</value>
        [JsonProperty("Categories")]
        public IList<ArtefactCategory> Categories { get; set; }
    }
}