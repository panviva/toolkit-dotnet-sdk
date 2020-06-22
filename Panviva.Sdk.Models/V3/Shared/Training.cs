using Newtonsoft.Json;

namespace Panviva.Sdk.Models.V3.Shared
{
    public class Training
    {
        [JsonProperty("FailureFeedback")]
        public string FailureFeedback { get; set; }

        [JsonProperty("ForcePageSequence")]
        public bool? ForcePageSequence { get; set; }

        [JsonProperty("ForceQuestionSequence")]
        public bool? ForceQuestionSequence { get; set; }

        [JsonProperty("PassingScore")]
        public int? PassingScore { get; set; }

        [JsonProperty("SuccessFeedback")]
        public string SuccessFeedback { get; set; }
    }
}