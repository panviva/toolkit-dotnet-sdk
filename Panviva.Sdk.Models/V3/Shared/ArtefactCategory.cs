// <copyright file="ArtefactCategory.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using Newtonsoft.Json;

    /// <summary>Shared Model ArtefactCategory.</summary>
    public partial class ArtefactCategory
    {
        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Id")]
        public int Id { get; set; }

        /// <summary>Gets or sets the CategoryName.</summary>
        /// <value>The CategoryName.</value>
        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }
    }
}