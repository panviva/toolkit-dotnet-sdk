using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetDocumentContainersResultModel
    {
        [JsonProperty("Containers")]
        public IList<Container> Containers { get; set; }
    }
}