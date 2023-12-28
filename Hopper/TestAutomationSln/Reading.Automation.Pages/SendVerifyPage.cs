using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class SendVerifyPage : OLABasePage
    {
        public Text HavingProblemsLink { get; private set; }

        public SendVerifyPage(IWebDriver driver)
            : base(driver)
        {
            HavingProblemsLink = new Text(Driver, By.CssSelector("body > div.container.card-container.ids-container.sendverify-container > div > div > div > div > p:nth-child(4) > a"));
        }
    }
}
