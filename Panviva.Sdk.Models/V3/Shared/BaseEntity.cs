using System;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class BaseEntity<T>
    {
        [JsonProperty("Id")]
        public T Id { get; set; }

        [JsonProperty("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("DateModified")]
        public DateTimeOffset? DateModified { get; set; }
    }
}