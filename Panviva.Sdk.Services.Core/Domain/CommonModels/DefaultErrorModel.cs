using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Panviva.Sdk.Services.Core.Domain.CommonModels
{
    internal class DefaultErrorModel
    {
        public bool HasErrors => Errors?.Count() > 0;

        internal string Message { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}