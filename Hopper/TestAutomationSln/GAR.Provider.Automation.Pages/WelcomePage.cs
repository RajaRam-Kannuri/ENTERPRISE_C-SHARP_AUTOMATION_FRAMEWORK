using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.Provider.Automation.Pages
{
    public class WelcomePage : LoggedOutPage
    {
        public Link NewProviderLink { get; private set; }
        public Link NewProviderLinkProd { get; private set; }

        public WelcomePage(IWebDriver driver)
            : base(driver)
        {
            NewProviderLink = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=186\"]"));
            NewProviderLinkProd = new Link(Driver, By.CssSelector("a[href=\"https://providers.sufs.org/Control.aspx?OSP=186\"]"));
        }
    }
}
