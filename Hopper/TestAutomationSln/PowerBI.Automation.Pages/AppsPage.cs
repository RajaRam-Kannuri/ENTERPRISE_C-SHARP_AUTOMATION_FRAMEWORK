using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class AppsPage : PowerBIBasePage
    {
        public Button FinanceTeamButton { get; private set; }
        public Button OperationsTeamButton { get; private set; }
        public Button PAPATeamButton { get; private set; }
        public Button QATeamButton { get; private set; }

        public AppsPage(IWebDriver driver)
            : base(driver)
        {
            FinanceTeamButton = new Button(Driver, By.CssSelector("#appsLandingContainer > apps-container > main > section > content-tile-container > div > div.contentScrollSection > ul > content-tile:nth-child(1) > li > div > div > div > app-logo > div > span"));
            OperationsTeamButton = new Button(Driver, By.CssSelector("#appsLandingContainer > apps-container > main > section > content-tile-container > div > div.contentScrollSection > ul > content-tile:nth-child(2) > li > div > div > div > app-logo > div > span"));
            PAPATeamButton = new Button(Driver, By.CssSelector("#appsLandingContainer > apps-container > main > section > content-tile-container > div > div.contentScrollSection > ul > content-tile:nth-child(3) > li > div > div > div > app-logo > div > span"));
            QATeamButton = new Button(Driver, By.CssSelector("#appsLandingContainer > apps-container > main > section > content-tile-container > div > div.contentScrollSection > ul > content-tile:nth-child(4) > li > div > div > div > app-logo > div > span"));
        }
    }
}
