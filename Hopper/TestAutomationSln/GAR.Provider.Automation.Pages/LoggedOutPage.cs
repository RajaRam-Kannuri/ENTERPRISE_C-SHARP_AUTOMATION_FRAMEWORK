using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.Provider.Automation.Pages
{
    public class LoggedOutPage : BasePage
    {
        public Tab WelcomeTab { get; private set; }

        public Tab ProviderAccountTab { get; private set; }

        public LoggedOutPage(IWebDriver driver)
            : base(driver)
        {
            WelcomeTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=191\"]"));
            ProviderAccountTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=173\"]"));
        }
    }
}
