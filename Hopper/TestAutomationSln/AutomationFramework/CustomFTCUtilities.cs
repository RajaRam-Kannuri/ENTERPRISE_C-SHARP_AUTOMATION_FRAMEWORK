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
//using System.Net;
//using Newtonsoft.Json;
//using System.Net.Http;
//using System.Web.Http;
//using System.Net.Http.Headers;
//using RestSharp;
//using System.Dynamic;
//using Newtonsoft.Json.Linq;
//using System.Text.RegularExpressions;
using System.Diagnostics;

namespace AutomationFramework
{
    [KeywordTesting]
    public class CustomFTCUtilities : WebElement
    {
        public CustomFTCUtilities(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
		[KeywordTestingCustomFTCUtilities]
		public bool SubmitFTCAppViaAPI(String data)
		{
            try
            {
                bool appIDexists = true;
                int appID = new int();

                while (appIDexists)
                {
                    bool rowFound = false;
                    Random rnd = new Random();
                    appID = rnd.Next(1000000, 100000000);
                    //FileInfo file = new FileInfo(@"I:\QA Tools\SQL Queries - Hopper\ReturnAllCurrentFTCApplicationIDs.sql");
                    //FileInfo file = new FileInfo(@"U:\IT\Restricted\QA Tools\SQL Queries - Hopper\ReturnAllCurrentFTCApplicationIDs.sql");
                    FileInfo file = new FileInfo(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\SQL Queries - Hopper\ReturnAllCurrentFTCApplicationIDs.sql");

                    string sqlCmd = file.OpenText().ReadToEnd();
                    String connectionString = @"Data Source=.; Trusted_Connection=True;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";

                    var updatedCmd = sqlCmd.Replace("'randomAppID'", "'" + appID + "'");

                    using (var sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        var cmd = new SqlCommand(updatedCmd, sqlCon);
                        cmd.CommandTimeout = 120;
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            rowFound = true;
                            break;
                        }

                        if(rowFound == true)
                            appIDexists = true;
                        else
                            appIDexists = false;
                    }
                }

                //update C:\DevTools\Foundation-QA\Hopper\PostmanCollections postman collection json file instead

                StreamReader r = new StreamReader("C:\\DevTools\\Foundation-QA\\Hopper\\JsonApps\\testApp.json");
                string jsonString = r.ReadToEnd();


                //update C:\DevTools\Foundation-QA\Hopper\PostmanCollections postman collection json file instead
                string updatedJsonString = jsonString.Replace("\"applicationId\": \"string\"" , "\"applicationId\": \"" + appID + "\"");
            }
            catch
            {
                return false;
            }

			return true;
		}


        [KeywordTestingCustomFTCUtilities]
        public bool SubmitFTCAppViaAPItest(String cmdName)
        {
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                //start.FileName = @"C:\DevTools\Foundation-QA\Hopper\PostmanCollections\Application_Intake.cmd"; // Specify exe name.
                start.FileName = @"C:\DevTools\Foundation-QA\Hopper\PostmanCollections\" + cmdName; // Specify exe name.
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        if (result.Contains("200 OK"))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        //[KeywordTestingCustomFTCUtilities]
        //public bool SubmitFTCAppViaAPItest2(String data)
        //{
        //    try
        //    {
        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"https://sufsdevapim.azure-api.net/dev/development/api/v1/ApplicationProcessing/ProcessApplication");
        //        httpWebRequest.Method = "POST";
        //        httpWebRequest.ContentType = "application/json";
        //        //httpWebRequest.Timeout = -1;
        //        httpWebRequest.Headers.Add("program-type", "1");
        //        httpWebRequest.Headers.Add("ApiKey", "8A1FEB354C6F428XB3A36D30E47A2BC3");
        //        httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", "1a427f4245764d91b5286a3ca4a6d8ee");
        //        //httpWebRequest.Timeout = new TimeSpan(0, 0, 1, 0);


        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        //        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //        {
        //            var json = System.IO.File.ReadAllText("C:\\DevTools\\SUFS\\QA\\Hopper\\JsonApps\\testApp.json");
        //            string jsonData = JsonConvert.SerializeObject(json);
        //            var data2 = new StringContent(jsonData, Encoding.UTF8, "application/json");

        //            streamWriter.Write(data2);
        //            streamWriter.Flush();
        //            streamWriter.Close();
        //        }

        //        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //        {
        //            var result = streamReader.ReadToEnd();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //[KeywordTestingCustomFTCUtilities]
        //public bool SubmitFTCAppViaAPItest3(String data)
        //{
        //    try
        //    {
        //        //var client = new RestClient("https://sufsdevapim.azure-api.net/dev/development/api/v1/ApplicationProcessing/ProcessApplication");
        //        //var request = new RestRequest();
        //        //request.Method = Method.Post;
        //        //request.AddHeader("program-type", "1");
        //        //request.AddHeader("ApiKey", "8A1FEB354C6F428XB3A36D30E47A2BC3");
        //        //request.AddHeader("Ocp-Apim-Subscription-Key", "1a427f4245764d91b5286a3ca4a6d8ee");
        //        //request.AddHeader("Content-Type", "application/json");
        //        //var json = System.IO.File.ReadAllText("C:\\DevTools\\SUFS\\QA\\Hopper\\JsonApps\\testApp.json");
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //[KeywordTestingCustomFTCUtilities]
        //public bool SubmitFTCAppViaAPItest(String data)
        //{
        //    try
        //    {
        //        //System.Diagnostics.Process.Start("CMD.exe", "/K newman run " + "Application_Intake.postman_collection.json");





        //        ProcessStartInfo start = new ProcessStartInfo();
        //        start.FileName = @"C:\DevTools\Foundation-QA\Hopper\PostmanCollections\Application_Intake.cmd"; // Specify exe name.
        //        start.UseShellExecute = false;
        //        start.RedirectStandardOutput = true;
        //        //
        //        // Start the process.
        //        //
        //        using (Process process = Process.Start(start))
        //        {
        //            //
        //            // Read in all the text from the process with the StreamReader.
        //            //
        //            using (StreamReader reader = process.StandardOutput)
        //            {
        //                string result = reader.ReadToEnd();
        //                if (result.Contains("Status code is 400"))
        //                {
        //                    return true;
        //                }
        //            }
        //        }



        //        //Process p = new Process();
        //        //ProcessStartInfo info = new ProcessStartInfo();
        //        //info.FileName = "cmd.exe";
        //        //info.RedirectStandardInput = true;
        //        //info.UseShellExecute = false;
        //        //info.Verb = "runas";
        //        //p.StartInfo = info;
        //        //p.Start();
        //        //// We start StreamWriter to add multiple CMD lines instead of user input.
        //        //using (StreamWriter sw = p.StandardInput)
        //        //{
        //        //    if (sw.BaseStream.CanWrite)
        //        //    {
        //        //        // Sets folder to "C:\Windows\SysWOW64"
        //        //        sw.WriteLine(@"cd C:\DevTools\Foundation-QA\Hopper\PostmanCollections");
        //        //        // Registers "MSWinSck.ocx"
        //        //        sw.WriteLine("newman run " + "\"Application_Intake.postman_collection.json\"");

        //        //    }
        //        //}

        //        //using (StreamReader sr = p.StandardOutput)
        //        //{
        //        //    if (sr.BaseStream.CanRead)
        //        //    {
        //        //        // Sets folder to "C:\Windows\SysWOW64"
        //        //        var sdfdsf = sr.ReadToEnd();
        //        //    }
        //        //}



        //        //Process p = new Process();
        //        //// Redirect the output stream of the child process.
        //        //p.StartInfo.UseShellExecute = false;
        //        //p.StartInfo.RedirectStandardInput = true;
        //        //p.StartInfo.RedirectStandardOutput = true;
        //        //p.StartInfo.FileName = "cmd.exe";
        //        //p.Start();
        //        //// Read the output stream first and then wait.
        //        //p.StandardInput.WriteLine(@"cd C:\DevTools\SUFS\QA\Hopper\PostmanCollections");
        //        //p.StandardInput.WriteLine(@"newman run " + "Application_Intake.postman_collection.json");
        //        //p.StandardInput.WriteLine("exit");
        //        //string output = p.StandardOutput.ReadToEnd();
        //        //p.WaitForExit();


        //        //using (Process process = new Process())
        //        //{
        //        //    process.StartInfo.UseShellExecute = false;
        //        //    process.StartInfo.RedirectStandardOutput = true;
        //        //    process.StartInfo.RedirectStandardError = true;
        //        //    process.StartInfo.WorkingDirectory = @"C:\DevTools\SUFS\QA\Hopper\PostmanCollections";
        //        //    process.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "cmd.exe");

        //        //    // Redirects the standard input so that commands can be sent to the shell.
        //        //    process.StartInfo.RedirectStandardInput = true;
        //        //    // Runs the specified command and exits the shell immediately.
        //        //    process.StartInfo.Arguments = @"/c ""dir""";

        //        //    //process.OutputDataReceived += ProcessOutputDataHandler;
        //        //    //process.ErrorDataReceived += ProcessErrorDataHandler;

        //        //    process.Start();
        //        //    process.BeginOutputReadLine();
        //        //    process.BeginErrorReadLine();

        //        //    // Send a directory command and an exit command to the shell
        //        //    process.StandardInput.WriteLine("dir");
        //        //    process.StandardInput.WriteLine("exit");

        //        //    process.WaitForExit();
        //        //}








        //        ////var command = "/c newman run " + "\"Application Intake.postman_collection.json\"";
        //        //var cmdsi = new ProcessStartInfo("cmd.exe");
        //        //cmdsi.Arguments = @"/c cd C:\DevTools\SUFS\QA\Hopper\PostmanCollections";
        //        //cmdsi.RedirectStandardOutput = true;
        //        //cmdsi.UseShellExecute = true;

        //        //var cmd = Process.Start(cmdsi);

        //        //var output2 = cmd.StandardOutput.ReadToEnd();

        //        //cmd.WaitForExit();

        //        //var stringdsf =  output2;
        //        //    RedirectStandardOutput = true,
        //        //    RedirectStandardInput = true,
        //        //    UseShellExecute = false
        //        //};
        //        //var pNpmRun = Process.Start(psiNpm);
        //        ////pNpmRun.StandardInput.WriteLine("npm install -g newman");
        //        ////pNpmRun.StandardInput.WriteLine("newman run " +
        //        ////    "\"C:\\Postman\\Test.postman.json\" " +
        //        ////    "--folder \"TestSearch\" " +
        //        ////    "--environment \"C:\\Postman\\postman_environment.json\" " +
        //        ////    "--disable-unicode");
        //        //pNpmRun.StandardInput.WriteLine(@"cd C:\DevTools\SUFS\QA\Hopper\PostmanCollections");
        //        //pNpmRun.StandardInput.WriteLine("newman run " + "\"Application Intake.postman_collection.json\"");
        //        //pNpmRun.StandardInput.WriteLine("exit");

        //        //pNpmRun.WaitForExit();
        //        //pNpmRun.StandardOutput.ReadToEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}
