using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetDocumentTranslationsResultModel
    {
        [JsonProperty("Translations")]
        public IList<Document> Translations { get; set; }

        [JsonProperty("Origin")]
        public string Origin { get; set; }
    }
}