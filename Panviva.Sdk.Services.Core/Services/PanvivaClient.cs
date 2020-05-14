using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Panviva.Sdk.Services.Core.Domain.CommonModels;
using Panviva.Sdk.Services.Core.Exceptions;
using Panviva.Sdk.Services.Core.Utilities;
using Polly;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Panviva.Sdk.Services.Core.Services
{

    /// <summary>Class contains the API call functions.</summary>
    /// <seealso cref="Panviva.Sdk.Services.Core.Services.IPanvivaClient" />
    public class PanvivaClient : IPanvivaClient
    {

        private readonly HttpClient _client;

        public PanvivaClient(HttpClient client, IConfiguration configuration, InputValidator inputValidator)
        {
            _client = client;
        }

        /// <summary>
        /// Calls the GET endpoints on Panviva's public facing APIs and parses the result to a specified type
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="queryUrl"></param>
        /// <param name="apiKey"></param>
        /// <param name="retryCount"></param>
        /// <returns></returns>
        public async Task<TResult> GetFromPanvivaApi<TResult>(string queryUrl, string apiKey, int retryCount)
        {
            // Add key for the request.
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

                throw new FailedApiRequestException(errorCode, errorModel?.Message ?? string.Empty);
            }

            var contentString = await response.Content.ReadAsStringAsync();

            var returnObject = JsonConvert.DeserializeObject<TResult>(contentString);

            return returnObject;
        }

        /// <summary>
        /// This method calls Panviva's public POST apis and parses the result into a specified data type
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="queryUrl"></param>
        /// <param name="apiKey"></param>
        /// <param name="requestBody"></param>
        /// <param name="retryCount"></param>
        /// <returns></returns>
        public async Task<TResult> PostToPanvivaApi<TResult>(string queryUrl, string apiKey, object requestBody, int retryCount)
        {
            // Content variable for post request.
            StringContent content;

            try
            {
                var stringObject = JsonConvert.SerializeObject(requestBody);
                content = new StringContent(stringObject, Encoding.UTF8, "application/json");
            }
            catch (Exception)
            {
                throw new FailedApiRequestException(Utilities.Constants.StatusCodeForInvalidModel, "Failed to convert request body to a json string.");
            }

            // Add key for the request.
            _client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(retryCount, attempt => TimeSpan.FromSeconds(Math.Min(Math.Pow(2, attempt), 30)))
                .ExecuteAsync(() => _client.PostAsync(queryUrl, content));

            if (!response.IsSuccessStatusCode)
            {
                var errorString = await response.Content.ReadAsStringAsync();
                var errorCode = response.StatusCode;
                var errorModel = JsonConvert.DeserializeObject<DefaultErrorModel>(errorString);

                throw new FailedApiRequestException(errorCode, errorModel?.Message ?? string.Empty);
            }

            var contentString = await response.Content.ReadAsStringAsync();

            var returnObject = JsonConvert.DeserializeObject<TResult>(contentString);

            return returnObject;
        }
    }
}
