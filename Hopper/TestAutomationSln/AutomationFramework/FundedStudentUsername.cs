using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace AutomationFramework
{
    [KeywordTesting]
    public class FundedStudentUsername : CustomWebElement
    {
        public FundedStudentUsername(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        //[KeywordTestingFundedStudentUsername]
        //public bool SetEmailAddressForFundedStudent()
        //{
        //    //FileInfo file = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
        //    //FileInfo fileEpi = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore.sql");
        //    FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
        //    FileInfo fileEpi = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore.sql");

        //    string sqlCmd = file.OpenText().ReadToEnd();
        //    string sqlCmdEpi = fileEpi.OpenText().ReadToEnd();

        //    String connectionString;
        //    String connectionStringEpi;

        //    //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-UC-UATEPISQ1; Database=Epicor102300";

        //    //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
        //    //connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
        //    connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=EpicorERP";
        //    connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";

        //    //connectionString = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=dev-sqlc1n1\test; Database=SUFS";

        //    string tableValue = null;
        //    int counter = 1;
        //    string column = "EMailAddress";
        //    List<string> emailAddressesEpi = new List<string>();

        //    using (var sqlCon = new SqlConnection(connectionStringEpi))
        //    {
        //        sqlCon.Open();
        //        var cmd = new SqlCommand(sqlCmdEpi, sqlCon);
        //        cmd.CommandTimeout = 120;
        //        var reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            tableValue = reader[column].ToString();
        //            emailAddressesEpi.Add(tableValue);

        //            counter++;

        //            if (counter > 100)
        //                break;
        //        }
        //    }

        //    emailAddressesEpi = emailAddressesEpi.OrderBy(a => Guid.NewGuid()).ToList();
        //    string sqlTemp = string.Empty;

        //    foreach (var address in emailAddressesEpi)
        //    {
        //        sqlTemp = sqlCmd.Replace(@"hm.EmailAddress = ' '", @"hm.EmailAddress = '" + address + @"'");

        //        counter = 1;
        //        tableValue = null;

        //        column = "EmailAddress";
        //        List<string> emailAddresses = new List<string>();

        //        using (var sqlCon = new SqlConnection(connectionString))
        //        {
        //            sqlCon.Open();
        //            var cmd = new SqlCommand(sqlTemp, sqlCon);
        //            cmd.CommandTimeout = 60;
        //            var reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                tableValue = reader[column].ToString();
        //                emailAddresses.Add(tableValue);
        //                break;
        //            }

        //            if (emailAddresses.Count >= 1)
        //            {
        //                this.SendKeys(emailAddresses[0]);
        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //}

        [KeywordTestingFundedStudentUsername]
        public bool SetEmailAddressForFundedStudent()
        {
            //FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            //FileInfo fileEpi = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicoreOver2000.sql");
            FileInfo fileEpi = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicoreOver2000.sql");

            //string sqlCmd = file.OpenText().ReadToEnd();
            string sqlCmdEpi = fileEpi.OpenText().ReadToEnd();

            //String connectionString;
            String connectionStringEpi;

            //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-UC-UATEPISQ1; Database=Epicor102300";

            //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
            //connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
            //connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=EpicorERP";
            connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ3; Database=EpicorERP";
            //connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";

            //connectionString = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=dev-sqlc1n1\test; Database=SUFS";

            string tableValue = null;
            int counter = 1;
            string column = "EMailAddress";
            List<string> emailAddressesEpi = new List<string>();

            using (var sqlCon = new SqlConnection(connectionStringEpi))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(sqlCmdEpi, sqlCon);
                cmd.CommandTimeout = 120;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tableValue = reader[column].ToString();
                    emailAddressesEpi.Add(tableValue);

                    counter++;

                    if (counter > 100)
                        break;
                }
            }

            emailAddressesEpi = emailAddressesEpi.OrderBy(a => Guid.NewGuid()).ToList();
            //string sqlTemp = string.Empty;

            //foreach (var address in emailAddressesEpi)
            //{
            //    sqlTemp = sqlCmd.Replace(@"hm.EmailAddress = ' '", @"hm.EmailAddress = '" + address + @"'");

            //    counter = 1;
            //    tableValue = null;

            //    column = "EmailAddress";
            //    List<string> emailAddresses = new List<string>();

            //    using (var sqlCon = new SqlConnection(connectionString))
            //    {
            //        sqlCon.Open();
            //        var cmd = new SqlCommand(sqlTemp, sqlCon);
            //        cmd.CommandTimeout = 60;
            //        var reader = cmd.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            tableValue = reader[column].ToString();
            //            emailAddresses.Add(tableValue);
            //            break;
            //        }

            //        if (emailAddresses.Count >= 1)
            //        {
            //            this.SendKeys(emailAddresses[0]);
            //            return true;
            //        }
            //    }
            //}

            if (emailAddressesEpi.Count >= 1)
            {
                this.SendKeys(emailAddressesEpi[0]);
                return true;
            }

            return false;
        }

        [KeywordTestingFundedStudentUsername]
        public bool SetEmailAddressForFundedStudentWhoNeverOrdered()
        {
            //FileInfo file = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            //FileInfo fileEpi = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore2.sql");
            //FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            //FileInfo fileEpi = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore2.sql");
            FileInfo file = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            FileInfo fileEpi = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore2.sql");

            string sqlCmd = file.OpenText().ReadToEnd();
            string sqlCmdEpi = fileEpi.OpenText().ReadToEnd();

            String connectionString;
            String connectionStringEpi;

            //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-UC-UATEPISQ1; Database=Epicor102300";

            //connectionStringEpi = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
            connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=Epicor102300";
            connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";

            //connectionString = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=dev-sqlc1n1\test; Database=SUFS";

            string tableValue = null;
            int counter = 1;
            string column = "EMailAddress";
            List<string> emailAddressesEpi = new List<string>();

            using (var sqlCon = new SqlConnection(connectionStringEpi))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(sqlCmdEpi, sqlCon);
                cmd.CommandTimeout = 120;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tableValue = reader[column].ToString();
                    emailAddressesEpi.Add(tableValue);

                    counter++;

                    if (counter > 100)
                        break;
                }
            }

            string sqlTemp = string.Empty;

            foreach (var address in emailAddressesEpi)
            {
                sqlTemp = sqlCmd.Replace(@"hm.EmailAddress = ' '", @"hm.EmailAddress = '" + address + @"'");

                counter = 1;
                tableValue = null;

                column = "EmailAddress";
                List<string> emailAddresses = new List<string>();

                using (var sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    var cmd = new SqlCommand(sqlTemp, sqlCon);
                    cmd.CommandTimeout = 60;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tableValue = reader[column].ToString();
                        emailAddresses.Add(tableValue);
                        break;
                    }

                    if (emailAddresses.Count >= 1)
                    {
                        this.SendKeys(emailAddresses[0]);
                        return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFundedStudentUsername]
        public bool SetEmailAddressForFundedStudentNoTNF(string quarter)
        {
            //FileInfo file = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            //FileInfo fileEpi = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore.sql");
            //FileInfo fileTnF = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\SQLQueryFindNotFundedStudent.sql");
            //FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            //FileInfo fileEpi = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore.sql");
            //FileInfo fileTnF = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\SQLQueryFindNotFundedStudent.sql");
            FileInfo file = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindEligibleFundedStudentsGarPLI.sql");
            FileInfo fileEpi = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindAvailableFundsFromEpicore.sql");
            FileInfo fileTnF = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\SQLQueryFindNotFundedStudent.sql");

            string sqlCmd = file.OpenText().ReadToEnd();
            string sqlCmdEpi = fileEpi.OpenText().ReadToEnd();
            string sqlCmdTnF = fileTnF.OpenText().ReadToEnd();

            String connectionString;
            String connectionStringEpi;
            String connectionStringTnF;

            connectionStringEpi = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=AZ-TC-TSTEPISQ1; Database=EpicorERP";
            connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";
            connectionStringTnF = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=PLSA";

            string tableValue = null;
            int counter = 1;
            string column = "EMailAddress";
            string column2 = "PersonID";
            List<string> emailAddressesEpi = new List<string>();
            List<string> PersonIDs = new List<string>();

            using (var sqlCon = new SqlConnection(connectionStringEpi))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(sqlCmdEpi, sqlCon);
                cmd.CommandTimeout = 120;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tableValue = reader[column].ToString();
                    emailAddressesEpi.Add(tableValue);
                    //tableValue = reader[column2].ToString();
                    //PersonIDs.Add(tableValue);
                    
                    counter++;

                    if (counter > 100)
                        break;
                }
            }

            emailAddressesEpi = emailAddressesEpi.OrderBy(a => Guid.NewGuid()).ToList();
            string sqlTemp = string.Empty;
            string sqlTnF = string.Empty;

            foreach (var address in emailAddressesEpi)
            {
                sqlTemp = sqlCmd.Replace(@"hm.EmailAddress = ' '", @"hm.EmailAddress = '" + address + @"'");

                counter = 1;
                tableValue = null;

                column = "EmailAddress";
                List<string> emailAddresses = new List<string>();
                string personID = string.Empty;
                //string personID = PersonIDs[emailAddressesEpi.IndexOf(address)];

                using (var sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    var cmd = new SqlCommand(sqlTemp, sqlCon);
                    cmd.CommandTimeout = 60;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tableValue = reader[column].ToString();
                        personID = reader[column2].ToString();

                        emailAddresses.Add(tableValue);
                        break;
                    }

                    if (emailAddresses.Count >= 1)
                    {
                        using (var sqlCon2 = new SqlConnection(connectionStringTnF))
                        {
                            sqlCon2.Open();
                            var cmd2 = new SqlCommand(sqlCmdTnF, sqlCon2);
                            cmd2.CommandTimeout = 60;
                            var reader2 = cmd2.ExecuteReader();

                            while (reader2.Read())
                            {
                                if (personID.Equals(reader2[column2].ToString()))
                                {
                                    this.SendKeys(emailAddresses[0]);
                                    return true;
                                }

                            }

                        }
                    }
                }
            }

            return false;
        }
    }
}
