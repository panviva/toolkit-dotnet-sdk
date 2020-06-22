using System.Threading.Tasks;

namespace Panviva.Sdk.Services.Core.Services
{
    public interface IPanvivaClient
    {
        Task<TResult> GetFromPanvivaApi<TResult>(string queryUrl, string apiKey, int retryCount);

        Task<TResult> PostToPanvivaApi<TResult>(string queryUrl, string apiKey, object requestBody, int retryCount);
    }
}