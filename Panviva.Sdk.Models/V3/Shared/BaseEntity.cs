// <copyright file="BaseEntity.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using Newtonsoft.Json;

    /// <summary>Shared Model BaseEntity.</summary>
    /// <typeparam name="T">Generic Type T.</typeparam>
    public partial class BaseEntity<T>
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public T Id { get; set; }

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