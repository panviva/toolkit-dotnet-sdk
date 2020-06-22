using System.Collections.Generic;
using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Get
{
    public interface ISearchPayload<T>
    {
        [JsonProperty("Results")]
        IList<T> Results { get; set; }

        [JsonProperty("Total")]
        int? Total { get; set; }
    }
}