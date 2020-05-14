// <copyright file="GetSearchQueryModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.QueryModels.V3
{
    /// <summary>Query Model for Get  endpoint.</summary>
    public class GetSearchQueryModel
    {
        /// <summary>Gets or sets the term.</summary>
        /// <value>The term.</value>
        public string Term { get; set; }

        /// <summary>Gets or sets the page offset.</summary>
        /// <value>The page offset.</value>
        public int? PageOffset { get; set; }

        /// <summary>Gets or sets the page limit.</summary>
        /// <value>The page limit.</value>
        public int? PageLimit { get; set; }
    }
}
