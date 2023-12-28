using Newtonsoft.Json;

namespace AutomationFramework.API.Test.DTO.Commerce
{
    public class GetDetailV2Response
    {
        [JsonProperty("available")]
        public decimal Available { get; set; }

        [JsonProperty("funding")]
        public decimal Funding { get; set; }

        [JsonProperty("spending")]
        public decimal Spending { get; set; }

        [JsonProperty("adjustments")]
        public decimal Adjustments { get; set; }

        [JsonProperty("reserved")]
        public decimal Reserved { get; set; }
    }
}
