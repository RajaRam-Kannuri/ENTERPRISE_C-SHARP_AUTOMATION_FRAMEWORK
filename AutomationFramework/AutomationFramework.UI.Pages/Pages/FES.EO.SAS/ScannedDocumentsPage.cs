using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class ScannedDocumentsPage : HomePage
    {
        public Table DocumentsTable { get; private set; }

        public Button ViewAllDocumentsButton { get; private set; }

        public ScannedDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            DocumentsTable = new Table(driver, By.CssSelector("table[id$=\"gvScannedDocumentList\"]"));
            ViewAllDocumentsButton = new Button(driver, By.CssSelector("input[id$=\"btnViewAll\"]"));
        }
    }
}
