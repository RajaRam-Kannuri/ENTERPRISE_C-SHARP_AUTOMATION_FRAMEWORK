using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class WelcomePage : BasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Button GoToApplicationButton { get; private set; }

        public Button GoToParentLoginButton { get; private set; }

        public Button ContinueButton { get; private set; }

        public WelcomePage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlOrgYears\"]"));
            GoToApplicationButton = new Button(Driver, By.CssSelector("input[id$=\"_btnToApplication\"]"));
            GoToParentLoginButton = new Button(Driver, By.CssSelector("input[id$=\"_btnToParentLogin\"]"));
            ContinueButton = new Button(Driver, By.CssSelector("input[id$=\"_btnToApplication\"]"));
        }
    }
}
