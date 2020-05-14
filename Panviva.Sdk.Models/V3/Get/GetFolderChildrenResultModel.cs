// <copyright file="GetFolderChildrenResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetFolderChildren endpoint.</summary>
    public class GetFolderChildrenResultModel
    {
        /// <summary>Gets or sets the Children.</summary>
        /// <value>The Children.</value>
        [JsonProperty("Children")]
        public IList<Resource> Children { get; set; }
    }
}