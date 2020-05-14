// <copyright file="ResourceSearchResult.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model ResourceSearchResult.</summary>
    public partial class ResourceSearchResult
    {
        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [JsonProperty("Type")]
        public string Type { get; set; }

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>Gets or sets the matched fields.</summary>
        /// <value>The matched fields.</value>
        [JsonProperty("MatchedFields")]
        public IList<string> MatchedFields { get; set; }

        /// <summary>Gets or sets the snippet.</summary>
        /// <value>The snippet.</value>
        [JsonProperty("Snippet")]
        public string Snippet { get; set; }

        /// <summary>Gets or sets the language.</summary>
        /// <value>The language.</value>
        [JsonProperty("Language")]
        public string Language { get; set; }

        /// <summary>Gets or sets the links.</summary>
        /// <value>The links.</value>
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }

        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Layout")]
        public string Layout { get; set; }

        /// <summary>Gets or sets the DateCreated.</summary>
        /// <value>The DateCreated.</value>
        [JsonProperty("Classification")]
        public string Classification { get; set; }

        /// <summary>Gets or sets the DateModified.</summary>
        /// <value>The DateModified.</value>
        [JsonProperty("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the FileName.</summary>
        /// <value>The FileName.</value>
        [JsonProperty("FileName")]
        public string FileName { get; set; }
    }
}