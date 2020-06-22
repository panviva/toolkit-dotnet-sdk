using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Utilities;
using Polly;

namespace Panviva.Sdk.Services.Core.Services
{
    public class PanvivaClient : IPanvivaClient
    {
        private readonly HttpClient _client;

        public PanvivaClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<TResult> GetFromPanvivaApi<TResult>(string queryUrl, string apiKey, int retryCount)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            _client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(retryCount, attempt => TimeSpan.FromSeconds(Math.Min(Math.Pow(2, attempt), 30)))
                .ExecuteAsync(() => _client.GetAsync(queryUrl));

            if (!response.IsSuccessStatusCode)
            {
                var errorString = await response.Content.ReadAsStringAsync();
                var errorCode = response.StatusCode;
                var errorModel = JsonConvert.DeserializeObject<DefaultErrorModel>(errorString);

                if (!string.IsNullOrEmpty(errorModel?.Message))
                {
                    throw new FailedApiRequestException(errorCode, errorModel.Message);
                }

                if (errorModel?.Errors != null && errorModel.Errors.Any())
                {
                    var errorMessage = string.Join(", ", errorModel.Errors);
                    throw new FailedApiRequestException(errorCode, errorMessage);
                }

                throw new FailedApiRequestException(errorCode);
            }

            var contentString = await response.Content.ReadAsStringAsync();
            var returnObject = JsonConvert.DeserializeObject<TResult>(contentString);

            return returnObject;
        }

        public async Task<TResult> PostToPanvivaApi<TResult>(string queryUrl, string apiKey, object requestBody,
            int retryCount)
        {
            StringContent content;

            try
            {
                var stringObject = JsonConvert.SerializeObject(requestBody);
                content = new StringContent(stringObject, Encoding.UTF8, "application/json");
            }
            catch (Exception)
            {
                throw new FailedApiRequestException(Constants.StatusCodeForInvalidModel,
                    "Failed to convert request body to a json string.");
            }

            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(retryCount, attempt => TimeSpan.FromSeconds(Math.Min(Math.Pow(2, attempt), 30)))
                .ExecuteAsync(() => _client.PostAsync(queryUrl, content));

            if (!response.IsSuccessStatusCode)
            {
                var errorString = await response.Content.ReadAsStringAsync();
                var errorCode = response.StatusCode;
                var errorModel = JsonConvert.DeserializeObject<DefaultErrorModel>(errorString);

                if (!string.IsNullOrEmpty(errorModel?.Message))
                {
                    throw new FailedApiRequestException(errorCode, errorModel.Message);
                }

                if (errorModel?.Errors != null && errorModel.Errors.Any())
                {
                    var errorMessage = string.Join(",", errorModel.Errors);
                    throw new FailedApiRequestException(errorCode, errorMessage);
                }

                throw new FailedApiRequestException(errorCode);
            }

            var contentString = await response.Content.ReadAsStringAsync();
            var returnObject = JsonConvert.DeserializeObject<TResult>(contentString);

            return returnObject;
        }
    }
}