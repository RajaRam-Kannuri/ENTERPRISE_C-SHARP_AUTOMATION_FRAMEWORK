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
    public class AribaOrderRequestPage : AribaApplicationWizardPage
    {
        public Text SASNumber { get; private set; }

        public AribaOrderRequestPage(IWebDriver driver)
            : base(driver)
        {
            SASNumber = new Text(Driver, By.CssSelector("#gbsection > div:nth-child(5) > div > div.panel-heading.text-black > span > span > span > span.po-dropdown-ord > span:nth-child(1) > a"));
        }
    }
}
