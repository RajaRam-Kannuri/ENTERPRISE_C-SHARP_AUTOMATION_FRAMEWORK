using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class LandingPage : FTCPLIBasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Link HomePageLink { get; private set; }

        public LandingPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"lnkHomePageddlOrgYears\"]"));
            HomePageLink = new Link(Driver, By.CssSelector("a[id$=\"lnkHomePage\"]"));
        }
    }
}
