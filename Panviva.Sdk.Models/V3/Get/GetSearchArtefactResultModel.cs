// <copyright file="GetSearchArtefactResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetSearchArtefactResultModel endpoint.</summary>
    public class GetSearchArtefactResultModel : ISearchPayload<SearchResult>
    {
        /// <summary>Gets or sets the facets.</summary>
        /// <value>The facets.</value>
        [JsonProperty("Facets")]
        public IEnumerable<Facet> Facets { get; set; }

        /// <summary>Gets or sets the Results.</summary>
        /// <value>The Results.</value>
        [JsonProperty("Results")]
        public IList<SearchResult> Results { get; set; }

        /// <summary>Gets or sets the Total.</summary>
        /// <value>The Total.</value>
        [JsonProperty("Total")]
        public int? Total { get; set; }
    }
}