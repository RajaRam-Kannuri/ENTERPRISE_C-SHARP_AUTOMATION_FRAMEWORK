using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class ReportsPage : PowerBIBasePage
    {
        public PowerBIMenu Menu { get; private set; }
        public PowerBIReport Report { get; private set; }
        public Text ReportNameText { get; private set; }

        public ReportsPage(IWebDriver driver)
            : base(driver)
        {
            Menu = new PowerBIMenu(Driver, By.CssSelector("#appNavPane > app-navigation-list > mat-list"));
            Report = new PowerBIReport(Driver, By.ClassName("visualContainerHost"));
            ReportNameText = new Text(Driver, By.CssSelector("#navBar > header > div.topNavLeft.ng-star-inserted > modern-breadcrumbs > nav > ul > li:nth-child(3) > span"));
        }
    }
}
