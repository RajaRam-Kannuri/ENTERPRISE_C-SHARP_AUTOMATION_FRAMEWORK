using System;
using System.IO;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Collections.Generic;

namespace AutomationFramework
{
    public class PageMinder : IDisposable
    {
        #region SUFS Only bits

        protected const string PDFViewerURL = "ViewPDF.ashx";

        protected string WorksheetURL;

        public int LocatePDFViewerPopup()
        {
            return LocatePopupByPartialUrl(PDFViewerURL);
        }

        public int LocateWorksheetPopup()
        {
            return LocatePopupByPartialUrl(WorksheetURL);
        }

        public void UseWorksheetPopup()
        {
            int apwIndex = LocateWorksheetPopup();
            Driver.UseChild(apwIndex != -1 ? apwIndex : 0);
        }

        public void UsePDFViewerPopup()
        {
            //int pdfIndex = LocatePDFViewerPopup();
            //Driver.UseChild(pdfIndex != -1 ? pdfIndex : 0);
        }

        public void WaitForPDFPopUp(int timeout = 5)
        {
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            //wait.Until(drv => LocatePDFViewerPopup() != -1);
        }

        public void ClosePDFPopUp(int pdfViewerIndex = -1)
        {
            if (pdfViewerIndex == -1)
            {
                pdfViewerIndex = LocatePDFViewerPopup();
            }

            if (pdfViewerIndex != -1)
            {
                Driver.UseChild(pdfViewerIndex);
                Driver.Close();
            }
        }

        public void WaitForWorksheetPopUps(bool closePDFViewer = true)
        {
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            //wait.Until(drv => drv.WindowHandles.Count > 1);
            //WaitForPDFPopUp();
            //if (closePDFViewer) ClosePDFPopUp();

            //UseWorksheetPopup();
            //WaitForWorksheetPageToLoad();
        }

        protected void WaitForWorksheetPageToLoad()
        {
        }

        protected string ProgramName { get; set; }

        #endregion SUFS Only bits

        public IWebDriver Driver { get; private set; }

        public string TestUrl { get; set; }

        public static bool IsCommandLine = false;

        public PageMinder(string testUrl, string browserType)
        {
            TestUrl = testUrl;
            GetNewDriver(browserType);
        }

        // Need an empty one so that I can instantiate without opening a browser
        public PageMinder()
        {
        }

        /// <summary>
        ///  Creates a new, maximized IWebDriver instance of the given type.
        /// </summary>
        /// <param name="browserType">
        /// A string describing the browser type to use (Firefox, IE, Chrome).
        /// </param>
        /// <returns> The newly created IWebDriver instance</returns>
        public void GetNewDriver(string browserType)
        {
            switch (browserType)
            {
                case "IE":
                    Driver = new InternetExplorerDriver();
                    break;
                case "Chrome":
                    ChromeOptions chromeOptionsS = new ChromeOptions();

                    //chromeOptions.AddUserProfilePreference("download.default_directory", @"C:\TestDownloads");
                    //chromeOptions.AddArgument("--disable-popup-blocking");
                    //chromeOptions.AddArgument("--disable-extensions");
                    //chromeOptions.AddArgument("--no-sandbox");
                    //chromeOptions.AddArgument("--ignore-certificate-errors");
                    //chromeOptions.AddArgument("--allow-running-insecure-content");
                    //string chromePath = Directory.GetCurrentDirectory() + System.Configuration.ConfigurationManager.AppSettings["ChromeDriverPath"];
                    //chromePath = @"C:\Selenium Drivers";

                    if (IsCommandLine)
                    {
                        chromeOptionsS.AddArgument("--headless");
                        chromeOptionsS.AddArguments("--window-size=1920x1080");
                    }
                    string chromePath = @"C:\DevTools\Foundation-QA\Hopper\Selenium Drivers";
                    //Logger.Log(chromePath);
                    //Driver = new ChromeDriver(chromePath, chromeOptions, TimeSpan.FromSeconds(240));
                    Driver = new ChromeDriver(chromePath, chromeOptionsS);
                    break;
                //case "Remote":
                //    //DesiredCapabilities capabilities = new DesiredCapabilities();
                //    Driver = new RemoteWebDriver(capabilities);
                //    break;
                default:
					FirefoxDriverService svc = FirefoxDriverService.CreateDefaultService(@"C:\DevTools\Foundation-QA\Hopper\Selenium Drivers");
					svc.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox";
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.SetPreference("browser.download.dir", @"C:\TestDownloads");
                    firefoxOptions.SetPreference("browser.download.folderList", 2);
                    firefoxOptions.SetPreference("browser.download.useDownloadDir", true);
                    firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf");
                    firefoxOptions.SetPreference("pdfjs.previousHandler.alwaysAskBeforeHandling", false);
                    firefoxOptions.SetPreference("pdfjs.previousHandler.preferredAction", 0);
                    firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", false);
                    Driver = new FirefoxDriver(svc, firefoxOptions, TimeSpan.FromSeconds(240));
                    break;
            }

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(240);
            Driver.Manage().Window.Maximize();
            OpenTestUrl();
        }

        public void OpenTestUrl()
        {
            Driver.Navigate().GoToUrl(TestUrl);
        }

        /// <summary>
        /// Verifies that a link returns status code 200. Used primarily for testing downloads.
        /// </summary>
        /// <param name="url">The download url to be tested</param>
        /// <returns>Returns the integer status code from the response</returns>
        public int GetLinkResponse(string url)
        {
            WebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";
            request.Headers[HttpRequestHeader.Cookie] = Driver.Cookies();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return (int)response.StatusCode;
        }

        /// <summary>
        /// Collects page objects and creates definitions and initializations for each object.
        /// </summary>
        /// <returns> Nothing
        public void GatherWebElements()
        {
            AutomationUtilities.GatherObjects(Driver);
        }

        protected int LocatePopupByPartialUrl(string url)
        {
            for (int i = 0; i < Driver.WindowHandles.Count; i++)
            {
                Driver.UseChild(i);
                if (Driver.Url.Contains(url))
                    return i;
            }

            return -1;
        }

        public void UseMainWindow()
        {
            Driver.UseParent();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }

        public static void SetCommandLineFlag(bool flag)
        {
            IsCommandLine = flag;
        }
    }
}
