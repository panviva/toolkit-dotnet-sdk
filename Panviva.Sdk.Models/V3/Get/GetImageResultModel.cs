// <copyright file="GetImageResultModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Get
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Panviva.Sdk.Models.V3.Shared;

    /// <summary>Response Model for GetImage endpoint.</summary>
    public class GetImageResultModel
    {
        /// <summary>Gets or sets the Id.</summary>
        /// <value>The Id.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>Gets or sets the Name.</summary>
        /// <value>The Name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the Width.</summary>
        /// <value>The Width.</value>
        [JsonProperty("Width")]
        public int? Width { get; set; }

        /// <summary>Gets or sets the Height.</summary>
        /// <value>The Height.</value>
        [JsonProperty("Height")]
        public int? Height { get; set; }

        /// <summary>Gets or sets the Size.</summary>
        /// <value>The Size.</value>
        [JsonProperty("Size")]
        public int? Size { get; set; }

        /// <summary>Gets or sets the ContentType.</summary>
        /// <value>The ContentType.</value>
        [JsonProperty("ContentType")]
        public string ContentType { get; set; }

        /// <summary>Gets or sets the Content.</summary>
        /// <value>The Content.</value>
        [JsonProperty("Content")]
        public string Content { get; set; }
    }
}