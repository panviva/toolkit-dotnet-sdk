// <copyright file="GetSearchArtefactsQueryModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.QueryModels.V3
{
    /// <summary>Query Model for Get  endpoint.</summary>
    public class GetSearchArtefactsQueryModel
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string SimpleQuery { get; set; }

        /// <summary>Gets or sets the advanced query.</summary>
        /// <value>The advanced query.</value>
        public string AdvancedQuery { get; set; }

        /// <summary>Gets or sets the filter.</summary>
        /// <value>The filter.</value>
        public string Filter { get; set; }

        /// <summary>Gets or sets the channel.</summary>
        /// <value>The channel.</value>
        public string Channel { get; set; }

        /// <summary>Gets or sets the page offset.</summary>
        /// <value>The page offset.</value>
        public int? PageOffset { get; set; }

        /// <summary>Gets or sets the page limit.</summary>
        /// <value>The page limit.</value>
        public int? PageLimit { get; set; }

        /// <summary>Gets or sets the facet parameter.</summary>
        /// <value>The facet.</value>
        public string Facet { get; set; }
    }
}
