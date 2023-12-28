using Newtonsoft.Json;

namespace AutomationFramework.API.Test.DTO.Foundation
{
    class HistoricalV3Response
    {
        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("PIN")]
        public string PIN { get; set; }
        [JsonProperty("Reason")]
        public string Reason { get; set; }
    }
}
