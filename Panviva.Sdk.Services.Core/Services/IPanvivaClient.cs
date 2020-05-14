// <copyright file="IPanvivaClient.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Services
{
    using System.Threading.Tasks;

    /// <summary>Interface of Panviva API helper library.</summary>
    public interface IPanvivaClient
    {
        /// <summary>Calls the panviva API.</summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="queryUrl">The query URL.</param>
        /// <param name="apiKey">The api key.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>The result Model.</returns>
        Task<TResult> GetFromPanvivaApi<TResult>(string queryUrl, string apiKey, int retryCount);

        /// <summary>Posts to panviva APIs.</summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="queryUrl">The query URL.</param>
        /// <param name="apiKey">The api key.</param>
        /// <param name="requestBody">The request body.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <returns>Status of Post Request.</returns>
        Task<TResult> PostToPanvivaApi<TResult>(string queryUrl, string apiKey, object requestBody, int retryCount);
    }
}
