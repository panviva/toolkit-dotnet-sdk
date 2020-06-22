using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Document : Resource
    {
        [JsonProperty("Release")]
        public int? Release { get; set; }

        [JsonProperty("Released")]
        public bool? Released { get; set; }

        [JsonProperty("Copyright")]
        public string Copyright { get; set; }

        [JsonProperty("Classification")]
        public string Classification { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Percentage")]
        public int? Percentage { get; set; }

        [JsonProperty("ReleaseDate")]
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty("Layout")]
        public string Layout { get; set; }

        [JsonProperty("Training")]
        public Training Training { get; set; }

        [JsonProperty("Keywords")]
        public IList<string> Keywords { get; set; }

        [JsonProperty("CshKeywords")]
        public IList<string> CshKeywords { get; set; }

        [JsonProperty("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [JsonProperty("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("ReusableContent")]
        public bool? ReusableContent { get; set; }

        [JsonProperty("ChangeNote")]
        public string ChangeNote { get; set; }

        [JsonProperty("Links")]
        public IList<Link> Links { get; set; }
    }
}