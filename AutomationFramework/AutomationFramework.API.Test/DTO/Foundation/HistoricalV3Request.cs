using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.API.Test.DTO.Foundation
{
    public class HistoricalV3Request
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("encodedPassword")]
        public string EncodedPassword { get; set; }
        public string Password
        {
            get { return EncodedPassword; }
            set { EncodedPassword = EncodePassword(value); }
        }
        [JsonProperty("program")]
        public string Program { get; set; }

        private string EncodePassword(string password)
        {
            // Encode the password using Base64 encoding
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(bytes);
        }
    }
}
