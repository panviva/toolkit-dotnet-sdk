using System.Collections.Generic;
using Newtonsoft.Json;
using Panviva.Sdk.Models.V3.Shared;

namespace Panviva.Sdk.Models.V3.Get
{
    public class GetFolderTranslationsResultModel
    {
        [JsonProperty("Translations")]
        public IList<Folder> Translations { get; set; }
    }
}