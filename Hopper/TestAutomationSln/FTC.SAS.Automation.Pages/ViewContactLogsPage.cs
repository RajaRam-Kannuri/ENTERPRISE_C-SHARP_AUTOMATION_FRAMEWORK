using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class ViewContactLogsPage : HomePage
    {
        public Table ContactLogTable { get; private set; }

        public WebElement ResultsFilter { get; private set; }

        public ViewContactLogsPage(IWebDriver driver)
            : base(driver)
        {
            ContactLogTable = new Table(Driver, By.Id("tblNotes"));
            ResultsFilter = new WebElement(Driver, By.Id("tblNotes_filter"));
        }
    }
}
