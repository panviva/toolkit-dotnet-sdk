namespace Panviva.Sdk.Services.Core.Domain.CommonModels
{
    public class ApiConfigModel
    {
        public string BaseUrl { get; set; }

        public string Instance { get; set; }

        public string ApiKey { get; set; }

        public int? RetryCount { get; set; }
    }
}