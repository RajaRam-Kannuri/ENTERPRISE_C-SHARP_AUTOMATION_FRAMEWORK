using AutomationFramework.API.Test.Data;
using AutomationFramework.API.Test.Data.Queries.Gardiner;
using AutomationFramework.API.Test.DTO.Commerce;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomationFramework.API.Test.Data.DBConnect;

namespace AutomationFramework.API.Test.Tests.Commerce
{
    [TestFixture]
    public class BudgetCheck : CommerceTest
    {
        public BudgetCheck() : base()
        {
        }

        //[Test]
        //public async Task test()
        //{
        //    var db = new PLSAAvailableFunds();
        //    await db.GetStudentWithAvailableFunds();
        //}

        [Test]
        public void BalanceGetAvailableV2vsV3()
        {
            var queryParams = new Dictionary<string, string>
            {
                {"studentId","4"},
                {"programAlias", "Gar" }
            };
            var responseV2 = Get(GET_AVAILABLE_V2, queryParameters: queryParams);
            var responseV3 = Get(GET_AVAILABLE_V3, queryParameters: queryParams);
            Assert.AreEqual(responseV3.Content, responseV2.Content);
        }

        [Test]
        public void BalanceGetDetailV2vsV3()
        {
            var queryParams = new Dictionary<string, string>
            {
                {"studentId","4"},
                {"programAlias", "Gar" }
            };
            var responseV2 = Get(GET_DETAIL_V2, queryParameters: queryParams);
            var responseV3 = Get(GET_DETAIL_V3, queryParameters: queryParams);
            var responseV2Dto = JsonConvert.DeserializeObject<GetDetailV2Response>(responseV2.Content);
            var responseV3Dto = JsonConvert.DeserializeObject<GetDetailV3Response>(responseV3.Content);
            
            Assert.AreEqual(responseV3Dto.Adjustments, responseV2Dto.Adjustments);
            Assert.AreEqual(responseV3Dto.Available, responseV2Dto.Available);
            Assert.AreEqual(responseV3Dto.Funding, responseV2Dto.Funding);
            Assert.AreEqual(responseV3Dto.Reserved, responseV2Dto.Reserved);
            Assert.AreEqual(responseV3Dto.Spending, responseV2Dto.Spending);
        }

        [Test]
        public void BalanceCheckV2vsV3()
        {
            var requestV3 = new BalanceCheckV3Request
            {
                StudentId = "4",
                ProgramAlias = "gar",
                Amount = 22,
                Replacement = new DocumentDTOV3
                {
                    DocumentType = "Requisition",
                    DocumentNumber = "3"
                }
            };

            var requestV2 = new BalanceCheckV2Request
            {
                StudentId = "4",
                ProgramAlias = "gar",
                Amount = 22,
                Replacement = new DocumentDTOV2
                {
                    DocumentType = "Requisition",
                    DocumentNumber = "3"
                }
            };
        }
    }
}
