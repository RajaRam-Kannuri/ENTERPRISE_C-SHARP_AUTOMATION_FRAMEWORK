using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class DisplayDocumentsPage : HomePage
    {
        public Button ViewDocuments { get; private set; }

        public DisplayDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            ViewDocuments = new Button(driver, By.CssSelector("input[id$=\"btnDownload\"]"));
        }
    }
}
