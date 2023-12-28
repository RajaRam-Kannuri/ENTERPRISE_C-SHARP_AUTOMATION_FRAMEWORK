using Newtonsoft.Json;

namespace AutomationFramework.API.Test.DTO.Commerce
{
    public class BalanceCheckV3Request
    {
        [JsonProperty("studentId")]
        public string StudentId { get; set; }

        [JsonProperty("programAlias")]
        public string ProgramAlias { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("replacement")]
        public DocumentDTOV3 Replacement { get; set; }
    }
    public class DocumentDTOV3
    {
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }
    }
}
