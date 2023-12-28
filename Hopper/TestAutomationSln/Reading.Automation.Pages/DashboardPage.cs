using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class DashboardPage :
        OLABasePage
    {
        public ButtonWithLink StartANewApplicationButton { get; private set; }
        public Text ClickHereLink { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            StartANewApplicationButton = new ButtonWithLink(Driver, By.CssSelector("body > app-root > div:nth-child(2) > conditional > reading > div > div > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div > div > a"));
            ClickHereLink = new Text(Driver, By.XPath("//*[contains(@href, 'reading-scholarship/how-the-scholarship-works/')]"));
        }
    }
}
