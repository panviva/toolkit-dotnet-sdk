namespace Panviva.Sdk.Services.Core.Domain.QueryModels.V3
{
    public class GetSearchQueryModel
    {
        public string Term { get; set; }

        public int? PageOffset { get; set; }

        public int? PageLimit { get; set; }
    }
}