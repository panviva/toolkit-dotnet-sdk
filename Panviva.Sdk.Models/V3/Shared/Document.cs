﻿// <copyright file="Document.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>Shared Model Document.</summary>
    public partial class Document : Resource
    {
        /// <summary>Gets or sets the Release.</summary>
        /// <value>The Release.</value>
        [JsonProperty("Release")]
        public int? Release { get; set; }

        /// <summary>Gets or sets the Released.</summary>
        /// <value>The Released.</value>
        [JsonProperty("Released")]
        public bool? Released { get; set; }

        /// <summary>Gets or sets the Copyright.</summary>
        /// <value>The Copyright.</value>
        [JsonProperty("Copyright")]
        public string Copyright { get; set; }

        /// <summary>Gets or sets the Classification.</summary>
        /// <value>The Classification.</value>
        [JsonProperty("Classification")]
        public string Classification { get; set; }

        /// <summary>Gets or sets the Status.</summary>
        /// <value>The Status.</value>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>Gets or sets the Percentage.</summary>
        /// <value>The Percentage.</value>
        [JsonProperty("Percentage")]
        public int? Percentage { get; set; }

        /// <summary>Gets or sets the ReleaseDate.</summary>
        /// <value>The ReleaseDate.</value>
        [JsonProperty("ReleaseDate")]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>Gets or sets the Layout.</summary>
        /// <value>The Layout.</value>
        [JsonProperty("Layout")]
        public string Layout { get; set; }

        /// <summary>Gets or sets the Training.</summary>
        /// <value>The Training.</value>
        [JsonProperty("Training")]
        public Training Training { get; set; }

        /// <summary>Gets or sets the Keywords.</summary>
        /// <value>The Keywords.</value>
        [JsonProperty("Keywords")]
        public IList<string> Keywords { get; set; }

        /// <summary>Gets or sets the CshKeywords.</summary>
        /// <value>The CshKeywords.</value>
        [JsonProperty("CshKeywords")]
        public IList<string> CshKeywords { get; set; }

        /// <summary>Gets or sets the UpdatedDate.</summary>
        /// <value>The UpdatedDate.</value>
        [JsonProperty("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the CreatedDate.</summary>
        /// <value>The CreatedDate.</value>
        [JsonProperty("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>Gets or sets the ReusableContent.</summary>
        /// <value>The ReusableContent.</value>
        [JsonProperty("ReusableContent")]
        public bool? ReusableContent { get; set; }

        /// <summary>Gets or sets the ChangeNote.</summary>
        /// <value>The ChangeNote.</value>
        [JsonProperty("ChangeNote")]
        public string ChangeNote { get; set; }

        /// <summary>Gets or sets the Links.</summary>
        /// <value>The Links.</value>
        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }
    }
}