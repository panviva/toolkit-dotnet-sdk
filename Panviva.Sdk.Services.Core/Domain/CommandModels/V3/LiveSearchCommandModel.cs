namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3
{
    public class LiveSearchCommandModel
    {
        public string UserName { get; set; }

        public string UserId { get; set; }

        public string Query { get; set; }

        public bool? ShowFirstResult { get; set; }

        public bool? MaximizeClient { get; set; }
    }
}