// <copyright file="GetSearchResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetSearch endpoint.</summary>
    public class GetSearchResultModel : ISearchPayload<ResourceSearchResult>
    {
        /// <summary>Gets or sets the results.</summary>
        /// <value>The results.</value>
        [JsonProperty("Results")]
        public IList<ResourceSearchResult> Results { get; set; }

        /// <summary>Gets or sets the total.</summary>
        /// <value>The total.</value>
        [JsonProperty("Total")]
        public int? Total { get; set; }

        /// <summary>Gets or sets the links.</summary>
        /// <value>The links.</value>
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }
    }
}