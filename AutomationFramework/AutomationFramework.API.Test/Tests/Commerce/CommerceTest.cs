using AutomationFramework.API.Test.DTO.Token;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Configuration;

namespace AutomationFramework.API.Test.Tests.Commerce
{
    public abstract class CommerceTest : BaseAPITest
    {
        protected const string GET_AVAILABLE_V2 = "/Balance/GetAvailableV2";
        protected const string GET_AVAILABLE_V3 = "/Balance/GetAvailableV3";
        protected const string GET_DETAIL_V2 = "/Balance/GetDetailV2";
        protected const string GET_DETAIL_V3 = "/Balance/GetDetailV3";
        protected const string GET_CHECK_V2 = "/Balance/CheckV2";
        protected const string GET_CHECK_V3 = "/Balance/CheckV3";

        public CommerceTest() : base()
        {            
        }

        protected override string BaseUrl()
        {
            return ConfigurationManager.AppSettings[$"Commerce_{environment}"];
        }

        protected override RestClient RestClient()
        {
            var token = FetchToken();
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
                token, "Bearer"
            );
            var options = new RestClientOptions(BaseUrl())
            {
                Authenticator = authenticator
            };
            return new RestClient(options);
        }

        private string FetchToken()
        {
            var options = new RestClientOptions
            {
                Authenticator = new HttpBasicAuthenticator(ConfigurationManager.AppSettings[$"Commerce_Username"], ConfigurationManager.AppSettings[$"Commerce_Password"]),
                BaseUrl = new Uri(ConfigurationManager.AppSettings[$"Commerce_Token_{environment}"])                
            };
            var client = new RestClient(options);

            RestRequest request = new RestRequest() { Method = Method.Post };
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("grant_type", "client_credentials");

            var response = client.Execute(request);
            var responseDto = JsonConvert.DeserializeObject<AccessTokenResponse>(response.Content);
            return responseDto.AccessToken;
        }

    }
}
