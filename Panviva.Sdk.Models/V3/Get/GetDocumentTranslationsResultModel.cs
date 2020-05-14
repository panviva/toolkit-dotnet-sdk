// <copyright file="GetDocumentTranslationsResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetDocumentTranslations endpoint.</summary>
    public class GetDocumentTranslationsResultModel
    {
        /// <summary>Gets or sets the Translations.</summary>
        /// <value>The Translations.</value>
        [JsonProperty("Translations")]
        public IList<Document> Translations { get; set; }

        /// <summary>Gets or sets the Origin.</summary>
        /// <value>The Origin.</value>
        [JsonProperty("Origin")]
        public string Origin { get; set; }
    }
}