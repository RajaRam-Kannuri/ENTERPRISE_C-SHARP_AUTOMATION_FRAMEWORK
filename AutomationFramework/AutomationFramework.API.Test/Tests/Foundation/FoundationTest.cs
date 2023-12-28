using RestSharp;
using System.Collections.Generic;
using System.Configuration;

namespace AutomationFramework.API.Test.Tests.Foundation
{
    public abstract class FoundationTest : BaseAPITest
    {
        protected const string AUTHENTICATING_GUARDIAN_V3 = "/historical/v3/pin";

        public FoundationTest() : base()
        {
        }

        protected override string BaseUrl()
        {
            return ConfigurationManager.AppSettings[$"Foundation_{environment}"];
        }

        protected override RestClient RestClient()
        {
            return new RestClient(BaseUrl());
        }

        /// <summary>
        /// Adds the Authorization header with the Bearer token to the request.
        /// </summary>
        /// <param name="request">The request object.</param>
        protected Dictionary<string, string> AuthorizationHeaders()
        {
            var authHeaders = new Dictionary<string, string>()
            {
                { "Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings[$"Foundation_{environment}_KEY"] },
                { "Content-Type", "application/json" }
            };
            return authHeaders;
        }
    }
}
