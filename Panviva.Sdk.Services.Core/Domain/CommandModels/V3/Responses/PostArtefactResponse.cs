using System;
using System.Collections.Generic;

namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3.Responses
{
    public class PostArtefactResponse
    {
        public Guid? ResponseId { get; set; }

        public bool HasErrors
        {
            get
            {
                return Errors?.Count > 0;
            }
        }

        public List<string> Errors { get; set; }
    }
}
