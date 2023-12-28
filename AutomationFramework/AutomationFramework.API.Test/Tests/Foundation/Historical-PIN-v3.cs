using AutomationFramework.API.Test.DTO.Foundation;
using AutomationFramework.API.Test.Tests.Foundation;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace AutomationFramework.API.Test.Foundation
{
    [TestFixture]
    class Historical_PIN_v3 : FoundationTest
    {
        public Historical_PIN_v3() : base()
        {
        }

        private static IEnumerable<TestCaseData> GetTestData()
        {
            var environment = ConfigurationManager.AppSettings["Environment"];
            // Define test case data based on the environment
            if (environment == "TEST")
            {
                yield return new TestCaseData("kyrf456@gmail.com", "SGVsbG8xMjMu", "1");
                yield return new TestCaseData("jessica.loewy@gmail.com", "SGVsbG8xMjM=", "5");
            }
            else if (environment == "UAT")
            {
                yield return new TestCaseData("00manoele@gmail.com", "SGVsbG8xMjMu", "1");
                //yield return new TestCaseData("johrami504@live.com", "SGVsbG8xMjM=", "5");
            }
        }



        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void ValidCredentials(string email, string encodedPassword, string program)
        {

            var requestBody = new HistoricalV3Request
            {
                Email = email,
                EncodedPassword = encodedPassword,
                Program = program
            };

            // Serialize the request body to JSON
            var jsonBody = JsonConvert.SerializeObject(requestBody);

            var response = Post(AUTHENTICATING_GUARDIAN_V3, jsonBody, AuthorizationHeaders());
            var responseDto = JsonConvert.DeserializeObject<HistoricalV3Response>(response.Content);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(responseDto.Success);
            Assert.AreEqual($"Guardian Email: {requestBody.Email}", responseDto.Message);
            Assert.IsFalse(string.IsNullOrEmpty(responseDto.PIN));
            Assert.DoesNotThrow(() =>
            {
                new Guid(responseDto.PIN);
            });
        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void ValidEmailWrongPassword(string email, string encodedPassword, string program)
        {
            var requestBody = new HistoricalV3Request
            {
                Email = email,
                EncodedPassword = $"{encodedPassword}Incorrect",
                Program = program
            };

            // Serialize the request body to JSON
            var jsonBody = JsonConvert.SerializeObject(requestBody);

            var response = Post(AUTHENTICATING_GUARDIAN_V3, jsonBody, AuthorizationHeaders());
            var responseDto = JsonConvert.DeserializeObject<HistoricalV3Response>(response.Content);

            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
            Assert.IsFalse(responseDto.Success);
            Assert.AreEqual("Invalid Credentials provided", responseDto.Message);
            Assert.AreEqual("Unauthorized", responseDto.Reason);
        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void ValidEmailBlankPassword(string email, string encodedPassword, string program)
        {
            var requestBody = new HistoricalV3Request
            {
                Email = email,
                EncodedPassword = "",
                Program = program
            };

            // Serialize the request body to JSON
            var jsonBody = JsonConvert.SerializeObject(requestBody);

            var response = Post(AUTHENTICATING_GUARDIAN_V3, jsonBody, AuthorizationHeaders());
            var responseDto = JsonConvert.DeserializeObject<HistoricalV3Response>(response.Content);

            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
            Assert.IsFalse(responseDto.Success);
            Assert.AreEqual("Invalid Credentials provided", responseDto.Message);
            Assert.AreEqual("Unauthorized", responseDto.Reason);
        }

        [Test]
        public void NullCredentials()
        {
            var requestBody = new HistoricalV3Request
            {
                Email = null,
                EncodedPassword = null,
                Program = null
            };

            // Serialize the request body to JSON
            var jsonBody = JsonConvert.SerializeObject(requestBody);

            var response = Post(AUTHENTICATING_GUARDIAN_V3, jsonBody, AuthorizationHeaders());
            var responseDto = JsonConvert.DeserializeObject<HistoricalV3Response>(response.Content);

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.AreEqual("ContentInvalid", responseDto.Reason);
        }
    }
}
