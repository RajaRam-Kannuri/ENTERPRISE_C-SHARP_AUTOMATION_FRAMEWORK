using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class QATeamWorkspacePage : PowerBIBasePage
    {
        public PowerBITable ReportsTable { get; private set; }
        public EditField SearchField { get; private set; }

        public QATeamWorkspacePage(IWebDriver driver)
            : base(driver)
        {
            ReportsTable = new PowerBITable(Driver, By.Id("artifactContentList"));
            SearchField = new EditField(Driver, By.CssSelector("#mat-input-0"));
        }
    }
}
