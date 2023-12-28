using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class PDFViewerPage : BasePage
    {
        public Text PDFViewer { get; private set; }

        public PDFViewerPage(IWebDriver driver)
            : base(driver)
        {
            PDFViewer = new Text(driver, By.CssSelector("embed[id=\"plugin\"]"));
        }
    }
}