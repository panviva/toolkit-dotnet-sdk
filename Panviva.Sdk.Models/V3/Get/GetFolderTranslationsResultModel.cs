// <copyright file="GetFolderTranslationsResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetFolderTranslationsResultModel endpoint.</summary>
    public class GetFolderTranslationsResultModel
    {
        /// <summary>Gets or sets the Translations.</summary>
        /// <value>The Translations.</value>
        [JsonProperty("Translations")]
        public IList<Folder> Translations { get; set; }
    }
}