namespace Panviva.Sdk.Services.Core.Domain.QueryModels.V3
{
    public class GetSearchArtefactsQueryModel
    {
        public string SimpleQuery { get; set; }

        public string AdvancedQuery { get; set; }

        public string Filter { get; set; }

        public string Channel { get; set; }

        public int? PageOffset { get; set; }

        public int? PageLimit { get; set; }

        public string Facet { get; set; }
    }
}