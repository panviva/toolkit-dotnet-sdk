// <copyright file="DefaultErrorModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.CommonModels
{
    using Newtonsoft.Json;

    /// <summary>Default Error Model.</summary>
    internal class DefaultErrorModel
    {
        /// <summary>Gets or sets the message.</summary>
        /// <value>The message.</value>
        [JsonProperty("message")]
        internal string Message { get; set; }
    }
}
