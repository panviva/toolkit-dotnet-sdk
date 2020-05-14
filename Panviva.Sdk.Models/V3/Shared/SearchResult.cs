// <copyright file="SearchResult.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model SearchResult.</summary>
    public partial class SearchResult
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        /// <summary>Gets or sets the content.</summary>
        /// <value>The content.</value>
        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        /// <summary>Gets or sets the category.</summary>
        /// <value>The category.</value>
        [JsonProperty("Category")]
        public Category Category { get; set; }

        /// <summary>Gets or sets the meta data.</summary>
        /// <value>The meta data.</value>
        [JsonProperty("MetaData")]
        public Dictionary<string, MetaDataValueDetails> MetaData { get; set; }

        /// <summary>Gets or sets the search score.</summary>
        /// <value>The search score.</value>
        [JsonProperty("SearchScore")]
        public float SearchScore { get; set; }

        /// <summary>Gets or sets the links.</summary>
        /// <value>The links.</value>
        [JsonProperty("Links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>Gets or sets the query variations.</summary>
        /// <value>The query variations.</value>
        [JsonProperty("QueryVariations")]
        public IEnumerable<QueryVariation> QueryVariations { get; set; }

        /// <summary>Gets or sets the primary query.</summary>
        /// <value>The primary query.</value>
        [JsonProperty("PrimaryQuery")]
        public string PrimaryQuery { get; set; }

        /// <summary>Gets or sets the panviva document identifier.</summary>
        /// <value>The panviva document identifier.</value>
        [JsonProperty("PanvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        /// <summary>Gets or sets the panviva document version.</summary>
        /// <value>The panviva document version.</value>
        [JsonProperty("PanvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        /// <summary>Gets or sets the title.</summary>
        /// <value>The title.</value>
        [JsonProperty("Title")]
        public string Title { get; set; }
    }
}