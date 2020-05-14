// <copyright file="LiveSearchCommandModel.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Services.Core.Domain.CommandModels.V3
{
    /// <summary>Command Model for live Document.</summary>
    public class LiveSearchCommandModel
    {
        /// <summary>Gets or sets the name of the user.</summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        /// <summary>Gets or sets the query.</summary>
        /// <value>The query.</value>
        public string Query { get; set; }

        /// <summary>Gets or sets a value indicating whether [show first result].</summary>
        /// <value><c>true</c> if [show first result]; otherwise, <c>false</c>.</value>
        public bool? ShowFirstResult { get; set; }

        /// <summary>Gets or sets a value indicating whether [maximize client].</summary>
        /// <value><c>true</c> if [maximize client]; otherwise, <c>false</c>.</value>
        public bool? MaximizeClient { get; set; }
    }
}
