// <copyright file="Training.cs" company="Panviva">
// Licensed under the MIT License.
// </copyright>

namespace Panviva.Sdk.Models.V3.Shared
{
    using Newtonsoft.Json;

    /// <summary>Shared Model Training.</summary>
    public partial class Training
    {
        /// <summary>Gets or sets the FailureFeedback.</summary>
        /// <value>The FailureFeedback.</value>
        [JsonProperty("FailureFeedback")]
        public string FailureFeedback { get; set; }

        /// <summary>Gets or sets the ForcePageSequence.</summary>
        /// <value>The ForcePageSequence.</value>
        [JsonProperty("ForcePageSequence")]
        public bool? ForcePageSequence { get; set; }

        /// <summary>Gets or sets the ForceQuestionSequence.</summary>
        /// <value>The ForceQuestionSequence.</value>
        [JsonProperty("ForceQuestionSequence")]
        public bool? ForceQuestionSequence { get; set; }

        /// <summary>Gets or sets the PassingScore.</summary>
        /// <value>The PassingScore.</value>
        [JsonProperty("PassingScore")]
        public int? PassingScore { get; set; }

        /// <summary>Gets or sets the SuccessFeedback.</summary>
        /// <value>The SuccessFeedback.</value>
        [JsonProperty("SuccessFeedback")]
        public string SuccessFeedback { get; set; }
    }
}