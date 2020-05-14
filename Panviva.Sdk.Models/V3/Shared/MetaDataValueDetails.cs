// <copyright file="MetaDataValueDetails.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using Newtonsoft.Json;

    /// <summary>Shared Model MetaDataValueDetails.</summary>
    public partial class MetaDataValueDetails
    {
        /// <summary>Gets or sets the Value.</summary>
        /// <value>The Value.</value>
        [JsonProperty("Values")]
        public string[] Value { get; set; }

        /// <summary>Gets or sets the DataType.</summary>
        /// <value>The DataType.</value>
        [JsonProperty("DataType")]
        public string DataType { get; set; }
    }
}