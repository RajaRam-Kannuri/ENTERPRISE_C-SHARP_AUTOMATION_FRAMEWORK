using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using AutomationFramework;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.TestManagement.WebApi;
using Xunit;
using System.Net;

namespace KWDT.Core.TestExecution
{
	public static class TestResultLogger
	{
        private static string testCaseName;
        private static string setName;
		private static string suiteName;
		private static string suiteType;
        private static string testStatus;
        public static string filePath;
		public static ExtentReports extent;
		public static ExtentHtmlReporter htmlReporter;
        public static ExtentHtmlReporter sharedHtmlReporter;
        public static ExtentTest test;
		public static string previousPage = "";
		public static int stepCounter = 1;
        public static int testCaseCounter;
        public static int failedTestCaseCounter;
        public static string path;
		public static string logPath;
        public static string sharedPath;
        public static string sharedLogPath;
        public static string pageLoadTime;

		public static void ResetStepCounter()
		{
			stepCounter = 1;
		}

        public static void SetTestCaseName(String name)
        {
            testCaseName = name;
        }

        public static void SetTestSetName(String name)
		{
			setName = name;
		}

		public static void SetSuiteName(String name)
		{
			suiteName = name;
		}

        public static void SetTestStatus(String status)
        {
            testStatus = status;
        }

        public static string GetTestCaseName()
        {
            return testCaseName;
        }

        public static int GetTestCaseCounter()
        {
            return testCaseCounter;
        }

        public static int GetFailedTestCaseCounter()
        {
            return failedTestCaseCounter;
        }

        public static string GetSuiteName()
		{
			return suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy");
		}

		public static void SetSuiteType(String type)
		{
			suiteType = type;
		}

		public static string GetSuiteType()
		{
			return suiteType;
		}

        public static void SetPageLoadTime(string loadTime)
        {
            pageLoadTime = loadTime;
        }

        public static void CreateReport()
		{
            testCaseCounter = 0;
            failedTestCaseCounter = 0;
            extent = new ExtentReports();
			path = "C:\\KWDT Temp Repo\\Test Results\\" + suiteType + "s\\";
			logPath = "C:\\KWDT Temp Repo\\Test Results\\Logs\\";
            //sharedPath = "I:\\QA Tools\\Hopper\\Test Results\\" + suiteType + "s\\";
            //sharedLogPath = "I:\\QA Tools\\Hopper\\Test Results\\Logs\\";
            //sharedPath = "U:\\IT\\Restricted\\QA Tools\\Hopper\\Test Results\\" + suiteType + "s\\";
            //sharedLogPath = "U:\\IT\\Restricted\\QA Tools\\Hopper\\Test Results\\Logs\\";
            sharedPath = @"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\Test Results" + suiteType + "s\\";
            sharedLogPath = @"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\Test Results\Logs\";

            Directory.CreateDirectory(path);
			Directory.CreateDirectory(logPath);

            try
            {
                Directory.CreateDirectory(sharedPath);
                Directory.CreateDirectory(sharedLogPath);
            }
            catch { }

            htmlReporter = new ExtentHtmlReporter(path + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".html");
            sharedHtmlReporter = new ExtentHtmlReporter(sharedPath + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".html");

            using (StreamWriter writetext = new StreamWriter(logPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt"))
			{
				writetext.WriteLine(suiteType + ": " + suiteName);
			}

            try
            {
                using (StreamWriter writetext = new StreamWriter(sharedLogPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt"))
                {
                    writetext.WriteLine(suiteType + ": " + suiteName);
                }
            }
            catch { }

            extent.AttachReporter(htmlReporter);
            extent.AttachReporter(sharedHtmlReporter);
            extent.AddSystemInfo("Env", "Set Environment");
			extent.AddSystemInfo("User", "Set User");
            htmlReporter.Configuration().DocumentTitle = "Hopper Report";
            htmlReporter.Configuration().ReportName = suiteType + ": " + suiteName;
            sharedHtmlReporter.Configuration().DocumentTitle = "Hopper Report";
            sharedHtmlReporter.Configuration().ReportName = suiteType + ": " + suiteName;

            if (GetSuiteName().Contains("- BASELINE"))
            {
                if (Directory.Exists("C:\\KWDT Temp Repo\\Test Results\\Baseline Screenshots\\" + suiteType + "s\\" + suiteName))
                    Directory.Delete("C:\\KWDT Temp Repo\\Test Results\\Baseline Screenshots\\" + suiteType + "s\\" + suiteName, true);
            }
        }

		public static void CreateTest(String name)
		{
            test = extent.CreateTest(name);

			test.Log(Status.Info, "<table style = 'width:100%'><tr><td>" + "Test Set: " + setName + "<br>" + "Browser: " + Utilities.GetBrowser() + "<br>" + "Environment: " + Utilities.GetEnvironment() + "</td></tr></table>");
			using (StreamWriter writetext = new StreamWriter(logPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
			{
                writetext.WriteLine();
                writetext.WriteLine(name);
			}

            try
            {
                using (StreamWriter writetext = new StreamWriter(sharedLogPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
                {
                    writetext.WriteLine();
                    writetext.WriteLine(name);
                }
            }
            catch { }

            testCaseCounter++;
		}

        public static void Pass(String message, String page, String entity)
		{
            string program = page.Replace(" ", "_");
            //test.Log(Status.Pass, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + ".\\..\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + ".\\..\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");
            //test.Log(Status.Pass, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + "\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + "\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");
            test.Log(Status.Pass, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + ".\\Screenshots\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + ".\\Screenshots\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");

            using (StreamWriter writetext = new StreamWriter(logPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
			{
				writetext.WriteLine("PASS - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss - ") + message.Replace("<br>", " || "));
            }

            try
            {
                using (StreamWriter writetext = new StreamWriter(sharedLogPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
                {
                    writetext.WriteLine("PASS - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss - ") + message.Replace("<br>", " || "));
                }
            }
            catch { }

			stepCounter++;

            SetTestStatus("passed");
        }

        public static void Fail(String message, String page, String entity)
		{
            string program = page.Replace(" ", "_");
            string stackTrace = System.Environment.StackTrace.ToString();
            //test.Log(Status.Fail, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='file:///" + "..\\..\\..\\..\\..\\..\\..\\..\\C:\\KWDT Temp Repo\\Test Results\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src = 'file:///" + "..\\..\\..\\..\\..\\..\\..\\..\\C:\\KWDT Temp Repo\\Test Results\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");
            //test.Log(Status.Fail, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + ".\\..\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + ".\\..\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");
            //test.Log(Status.Fail, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + "\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + "\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");
            test.Log(Status.Fail, "<table style = 'width:100%'><tr><td width='600'>" + message + "<br>" + "Page Load Time: " + pageLoadTime + "</td><td>" + "<a href='" + ".\\Screenshots\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' target='_blank'><img src ='" + ".\\Screenshots\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png' height='100' width='150'></a>" + "</td></tr></table>");

            using (StreamWriter writetext = new StreamWriter(logPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
			{
				writetext.WriteLine("FAIL - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss - ") + message.Replace("<br>", " || "));
            }

            try
            {
                using (StreamWriter writetext = new StreamWriter(sharedLogPath + suiteType + " - " + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".txt", true))
                {
                    writetext.WriteLine("FAIL - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss - ") + message.Replace("<br>", " || "));
                }
            }
            catch { }

			stepCounter++;

            SetTestStatus("failed");
            failedTestCaseCounter++;
        }

		public static void Info(String message, String name)
		{
			test.Log(Status.Info, message);
        }

        public static void CloseReport()
		{
            try
            {
                extent.Flush();
            }
            catch { }
        }

        public static void Screenshot(IWebDriver driver, String page, String entity)
		{
            string program = page.Replace(" ", "_");

			try
			{
				var ss = ((ITakesScreenshot)driver).GetScreenshot();
                //System.IO.Directory.CreateDirectory(StringConstants.ScreenshotsResultsFolder + suiteType + "s\\" + GetSuiteName());
                //ss.SaveAsFile(StringConstants.ScreenshotsResultsFolder + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png", ScreenshotImageFormat.Png);
                //ss.SaveAsFile(".\\..\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png", ScreenshotImageFormat.Png);

                //System.IO.Directory.CreateDirectory("\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName());
                //ss.SaveAsFile("\\\\hopper\\testresults\\Screenshots\\" + suiteType + "s\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png", ScreenshotImageFormat.Png);

                System.IO.Directory.CreateDirectory("C:\\KWDT Temp Repo\\Test Results\\" + suiteType + "s\\" + "Screenshots\\" + GetSuiteName());
                ss.SaveAsFile("C:\\KWDT Temp Repo\\Test Results\\" + suiteType + "s\\" + "Screenshots\\" + GetSuiteName() + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png", ScreenshotImageFormat.Png);

                if (GetSuiteName().Contains("- BASELINE"))
				{
                    System.IO.Directory.CreateDirectory("C:\\KWDT Temp Repo\\Test Results\\Baseline Screenshots\\" + suiteType + "s\\" + suiteName);
					ss.SaveAsFile("C:\\KWDT Temp Repo\\Test Results\\Baseline Screenshots\\" + suiteType + "s\\" + suiteName + "\\ Step " + stepCounter + " - " + program + "_" + entity + ".png", ScreenshotImageFormat.Png);
				}
			}
			catch { }
		}

		public static void DropFile(IWebDriver driver, String filePath, IWebElement target, int offsetX, int offsetY)
		{
			IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

			String JS_DROP_FILE =
				"var target = arguments[0]," +
				"    offsetX = arguments[1]," +
				"    offsetY = arguments[2]," +
				"    document = target.ownerDocument || document," +
				"    window = document.defaultView || window;" +
				"" +
				"var input = document.createElement('INPUT');" +
				"input.type = 'file';" +
				"input.style.display = 'none';" +
				"input.onchange = function () {" +
				"  var rect = target.getBoundingClientRect()," +
				"      x = rect.left + (offsetX || (rect.width >> 1))," +
				"      y = rect.top + (offsetY || (rect.height >> 1))," +
				"      dataTransfer = { files: this.files };" +
				"" +
				"  ['dragenter', 'dragover', 'drop'].forEach(function (name) {" +
				"    var evt = document.createEvent('MouseEvent');" +
				"    evt.initMouseEvent(name, !0, !0, window, 0, 0, 0, x, y, !1, !1, !1, !1, 0, null);" +
				"    evt.dataTransfer = dataTransfer;" +
				"    target.dispatchEvent(evt);" +
				"  });" +
				"" +
				"  setTimeout(function () { document.body.removeChild(input); }, 25);" +
				"};" +
				"document.body.appendChild(input);" +
				"return input;";
			IWebElement input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
			input.SendKeys(filePath);
		}

		public static void ScreenshotCompare(IWebDriver driver, String screenshotName)
		{
			try
			{
				var ss = ((ITakesScreenshot)driver).GetScreenshot();
				System.IO.Directory.CreateDirectory("C:\\KWDT Temp Repo\\Test Results\\Screenshot Comparison Results\\" + suiteType + "s\\" + suiteName + "\\");
				ss.SaveAsFile("C:\\KWDT Temp Repo\\Test Results\\Screenshot Comparison Results\\" + suiteType + "s\\" + suiteName + "\\" + screenshotName, ScreenshotImageFormat.Png);
			}
			catch { }
		}

        public static bool IdenticalImages(String image1Path, String image2Path)
        {
            byte[] image1Bytes;
            byte[] image2Bytes;
            Bitmap image1 = new Bitmap(image1Path);
            Bitmap image2 = new Bitmap(image2Path);

            using (var mstream = new MemoryStream())
            {
                image1.Save(mstream, image1.RawFormat);
                image1Bytes = mstream.ToArray();
            }

            using (var mstream = new MemoryStream())
            {
                image2.Save(mstream, image2.RawFormat);
                image2Bytes = mstream.ToArray();
            }

            var image164 = Convert.ToBase64String(image1Bytes);
            var image264 = Convert.ToBase64String(image2Bytes);

            return string.Equals(image164, image264);
        }

        public static void AttachReportToVSTSItem()
        {
            //if (Utilities.GetVSTSItemID() != null)
            //{
            //    string filePath = path + suiteName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".html";
            //    var uri = new Uri("https://sufs.visualstudio.com");
            //    //put VSTS key here
            //    VssCredentials cred = new VssCredentials(new VssBasicCredential(string.Empty, ""));
            //    var connection = new VssConnection(uri, cred);
            //    WorkItemTrackingHttpClient workitemClient = connection.GetClient<WorkItemTrackingHttpClient>();
            //    AttachmentReference attachmentReference = workitemClient.CreateAttachmentAsync(filePath).Result;
            
            //    var document = new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchDocument
            //    {
            //        new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
            //        {
            //            Path = "/relations/-",
            //            Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
            //            Value = new
            //            {
            //                rel = "AttachedFile",
            //                url = attachmentReference.Url,
            //                attributes = new { comment = "Test Run Report" }
            //            }
            //        }
            //    };

            //    workitemClient.UpdateWorkItemAsync(document, (int)Utilities.GetVSTSItemID());
            //}
        }

        public static void CreateTestRunInVSTS()
        {
            if (Utilities.GetTestPlanID() != null && Utilities.GetTestPointID() != null)
            {
                System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var uri = new Uri("https://sufs.visualstudio.com");
                VssCredentials cred = new VssCredentials(new VssBasicCredential(string.Empty, "om2obhzx2fhs5g52lgrtjpxlo6z4jy6mxnpmc5no2snwaapvaapa"));

                var connection = new VssConnection(uri, cred);
                var testClient = connection.GetClient<TestManagementHttpClient>();
                int testpointid = (int)Utilities.GetTestPointID();
                string teamProject = "Agile Project";
                RunCreateModel run = new RunCreateModel(
                    name: testCaseName,
                    plan: new ShallowReference(""+ Utilities.GetTestPlanID() + ""),
                    pointIds: new int[] { testpointid }
                    );
                TestRun testrun = testClient.CreateTestRunAsync(run, teamProject).Result;

                TestCaseResult caseResult = new TestCaseResult() { State = "Completed", Outcome = testStatus, Id = 100000 };

                //sets test run to completed and test case passed
                var testResults = testClient.UpdateTestResultsAsync(new TestCaseResult[] { caseResult }, teamProject, testrun.Id).Result;

                RunUpdateModel runmodel = new RunUpdateModel(state: "Completed");
                TestRun testRunResult = testClient.UpdateTestRunAsync(runmodel, teamProject, testrun.Id).Result;
            }
        }
    }
}
