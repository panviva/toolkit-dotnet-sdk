// <copyright file="ApiConfigModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.CommonModels
{
    /// <summary>Api Configuration model.</summary>
    public class ApiConfigModel
    {
        /// <summary>Gets or sets the base URL.</summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; set; }

        /// <summary>Gets or sets the instance.</summary>
        /// <value>The instance.</value>
        public string Instance { get; set; }

        /// <summary>Gets or sets the API key.</summary>
        /// <value>The API key.</value>
        public string ApiKey { get; set; }

        /// <summary>Gets or sets the retry count.</summary>
        /// <value>The retry count.</value>
        public int? RetryCount { get; set; }
    }
}
