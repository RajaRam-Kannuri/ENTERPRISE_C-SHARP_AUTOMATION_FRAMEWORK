using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class UtilityPage : BasePage
    {
        public CustomFTCUtilities Utilities { get; private set; }

        public UtilityPage(IWebDriver driver)
            : base(driver)
        {
            Utilities = new CustomFTCUtilities(Driver, By.XPath(""));
        }
    }
}
