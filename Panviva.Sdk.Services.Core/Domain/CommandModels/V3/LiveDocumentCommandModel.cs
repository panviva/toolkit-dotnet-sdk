namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3
{
    public class LiveDocumentCommandModel
    {
        public string UserName { get; set; }

        public string UserId { get; set; }

        public string Id { get; set; }

        public string Location { get; set; }

        public bool? MaximizeClient { get; set; }
    }
}