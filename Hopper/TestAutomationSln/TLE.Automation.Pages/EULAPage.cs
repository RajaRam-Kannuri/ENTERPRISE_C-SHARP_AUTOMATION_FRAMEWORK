using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class EULAPage : CommonPage
    {
        public Button AcceptButton { get; private set; }

        public Button DeclineButton { get; private set; }

        public EULAPage(IWebDriver driver)
            : base(driver)
        {
            AcceptButton = new Button(Driver, By.CssSelector("input[value=\"I Accept\"]"));
            DeclineButton = new Button(Driver, By.CssSelector("input[value=\"I Decline\"]"));
        }
    }
}
