// <copyright file="QueryVariation.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using Newtonsoft.Json;

    /// <summary>Shared Model QueryVariation.</summary>
    public partial class QueryVariation
    {
        /// <summary>Gets or sets the Query.</summary>
        /// <value>The Query.</value>
        [JsonProperty("Query")]
        public string Query { get; set; }
    }
}