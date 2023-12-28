using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class DisplayDocumentsPage : HomePage
    {
        public Button ViewDocuments { get; private set; }

        public DisplayDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            ViewDocuments = new Button(Driver, By.CssSelector("input[id$=\"btnDownload\"]"));
        }
    }
}
