using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Data.SqlClient;

namespace AutomationFramework
{
    [KeywordTesting]
    public class OLAAccountActivation
    {
        public OLAAccountActivation(IWebDriver driver, By locateBy, int index = 0)
        {
        }

        [KeywordTestingOLAAccountActivation]
        public void ExecuteAccountActivationQuery()
        {
            //FileInfo file = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryActivateAccountFTCOLA.sql");
            //FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryActivateAccountFTCOLA.sql");
            FileInfo file = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryActivateAccountFTCOLA.sql");

            string sqlCmd = file.OpenText().ReadToEnd();

            String connectionString;

            connectionString = @"Data Source = tcp:sufssqlservertest.database.windows.net,1433; Initial Catalog = identityserver; User Id = IdentityServerWebUser; Password = qwYAHSTUQS5x; Connect Timeout = 45; ConnectRetryCount = 4; ConnectRetryInterval = 10;";
            //connectionString = @"Data Source = tcp:sufssqlserveruat.database.windows.net,1433; Initial Catalog = identityserver; User Id = IdentityServerWebUser; Password = qwYAHSTUQS5x; Connect Timeout = 45; ConnectRetryCount = 4; ConnectRetryInterval = 10;";

            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(sqlCmd, sqlCon);
                cmd.CommandTimeout = 120;
                var reader = cmd.ExecuteReader();
            }
        }
    }
}

