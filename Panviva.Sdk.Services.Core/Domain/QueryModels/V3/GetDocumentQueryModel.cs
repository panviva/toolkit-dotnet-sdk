// <copyright file="GetDocumentQueryModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.QueryModels.V3
{
    /// <summary>Query Model for Get Document endpoint.</summary>
    public class GetDocumentQueryModel
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the version.</summary>
        /// <value>The version.</value>
        public string Version { get; set; }
    }
}
