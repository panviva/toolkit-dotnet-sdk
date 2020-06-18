// <copyright file="PanvivaClient.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Services
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Panviva.Sdk.Services.Core.Domain.CommonModels;
    using Panviva.Sdk.Services.Core.Exceptions;
    using Panviva.Sdk.Services.Core.Utilities;
    using Polly;

    /// <summary>Class contains the API call functions.</summary>
    /// <seealso cref="Panviva.Sdk.Services.Core.Services.IPanvivaClient" />
    public class PanvivaClient : IPanvivaClient
    {

        private readonly HttpClient client;

        /// <summary>Initializes a new instance of the <see cref="PanvivaClient" /> class.</summary>
        /// <param name="client">The client.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="inputValidator">The input validator.</param>
        public PanvivaClient(HttpClient client, IConfiguration configuration, InputValidator inputValidator)
        {
            this.client = client;
        }

        /// <summary>Calls the panviva API.</summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="queryUrl">The query URL.</param>
        /// <param name="apiKey">The Api key.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>The result Model.</returns>
        public async Task<TResult> GetFromPanvivaApi<TResult>(string queryUrl, string apiKey, int retryCount)
        {
            // clear headers.
            this.client.DefaultRequestHeaders.Clear();

            // Add key for the request.
            this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            this.client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(retryCount, attempt => TimeSpan.FromSeconds(Math.Min(Math.Pow(2, attempt), 30)))
                .ExecuteAsync(() => client.GetAsync(queryUrl));

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

        /// <summary>Gets the panviva API response.</summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="queryUrl">The query URL.</param>
        /// <param name="apiKey">The Api key.</param>
        /// <param name="requestBody">The request body.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>True if successful.</returns>
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

            // clear headers.
            this.client.DefaultRequestHeaders.Clear();

            // Add key for the request.
            this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(retryCount, attempt => TimeSpan.FromSeconds(Math.Min(Math.Pow(2, attempt), 30)))
                .ExecuteAsync(() => this.client.PostAsync(queryUrl, content));

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
