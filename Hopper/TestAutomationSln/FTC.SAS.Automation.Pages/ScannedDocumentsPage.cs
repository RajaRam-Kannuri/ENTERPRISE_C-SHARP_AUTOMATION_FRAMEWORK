using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class ScannedDocumentsPage : HomePage
    {
        public Table DocumentsTable { get; private set; }

        public Button ViewAllDocumentsButton { get; private set; }

        public ScannedDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            DocumentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvScannedDocumentList\"]"));
            ViewAllDocumentsButton = new Button(Driver, By.CssSelector("input[id$=\"btnViewAll\"]"));
        }
    }
}
