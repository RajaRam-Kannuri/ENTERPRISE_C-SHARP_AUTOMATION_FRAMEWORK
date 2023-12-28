using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.Provider.Automation.Pages
{
    public class HomePage : BasePage
    {
        public Link LogOutLink { get; private set; }

        public Tab HomeTab { get; private set; }

        public Tab ProviderInformationTab { get; private set; }

        public Tab ChangePasswordTab { get; private set; }

        public Tab ReimbursementRequestsTab { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            LogOutLink = new Link(Driver, By.Id("LBSignOut"));
            HomeTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=175\"]"));
            ProviderInformationTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=180\"]"));
            ChangePasswordTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=176\"]"));
            ReimbursementRequestsTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=177\"]"));
        }
    }
}
