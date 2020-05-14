// <copyright file="GetArtefactResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetArtefact endpoint.</summary>
    public class GetArtefactResultModel
    {
        /// <summary>Gets or sets the Links.</summary>
        /// <value>The Links.</value>
        [JsonProperty("Links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>Gets or sets the Title.</summary>
        /// <value>The Title.</value>
        [JsonProperty("Title")]
        public string Title { get; set; }

        /// <summary>Gets or sets the Content.</summary>
        /// <value>The Content.</value>
        [JsonProperty("Content")]
        public IEnumerable<ResponseSection> Content { get; set; }

        /// <summary>Gets or sets the Variations.</summary>
        /// <value>The Variations.</value>
        [JsonProperty("Variations")]
        public IEnumerable<ResponseVariation> Variations { get; set; }

        /// <summary>Gets or sets the Category.</summary>
        /// <value>The Category.</value>
        [JsonProperty("Category")]
        public Category Category { get; set; }

        /// <summary>Gets or sets the PrimaryQuery.</summary>
        /// <value>The PrimaryQuery.</value>
        [JsonProperty("PrimaryQuery")]
        public string PrimaryQuery { get; set; }

        /// <summary>Gets or sets the QueryVariations.</summary>
        /// <value>The QueryVariations.</value>
        [JsonProperty("QueryVariations")]
        public IEnumerable<QueryVariation> QueryVariations { get; set; }

        /// <summary>Gets or sets the PanvivaDocumentId.</summary>
        /// <value>The PanvivaDocumentId.</value>
        [JsonProperty("PanvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        /// <summary>Gets or sets the PanvivaDocumentVersion.</summary>
        /// <value>The PanvivaDocumentVersion.</value>
        [JsonProperty("PanvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        /// <summary>Gets or sets the MetaData.</summary>
        /// <value>The List of MetaData.</value>
        [JsonProperty("MetaData")]
        public Dictionary<string, MetaDataValueDetails> MetaData { get; set; }

        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        /// <summary>Gets or sets the DateCreated.</summary>
        /// <value>The DateCreated.</value>
        [JsonProperty("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>Gets or sets the DateModified.</summary>
        /// <value>The DateModified.</value>
        [JsonProperty("DateModified")]
        public DateTimeOffset? DateModified { get; set; }
    }
}