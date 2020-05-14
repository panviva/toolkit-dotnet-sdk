// <copyright file="ISearchPayload.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Search Payload result model.</summary>
    /// <typeparam name="T">Type of Payload.</typeparam>
    public interface ISearchPayload<T>
    {
        /// <summary>Gets or sets the Results.</summary>
        /// <value>The Results.</value>
        [JsonProperty("Results")]
        IList<T> Results { get; set; }

        /// <summary>Gets or sets the Total.</summary>
        /// <value>The Total.</value>
        [JsonProperty("Total")]
        int? Total { get; set; }
    }
}