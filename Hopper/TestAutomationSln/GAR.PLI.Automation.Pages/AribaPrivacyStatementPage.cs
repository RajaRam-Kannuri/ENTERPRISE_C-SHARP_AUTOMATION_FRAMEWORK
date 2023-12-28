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
    public class AribaPrivacyStatementPage : BasePage
    {
        public Checkbox IHaveReadTheCookieNoticeCheckbox { get; private set; }
        public Button OKButton { get; private set; }
        public Button CancelButton { get; private set; }

        public AribaPrivacyStatementPage(IWebDriver driver)
            : base(driver)
        {
            IHaveReadTheCookieNoticeCheckbox = new Checkbox(Driver, By.CssSelector("#_in0upb > div > div > div > table > tbody > tr:nth-child(3) > td > label > div > label"));
            OKButton = new Button(Driver, By.Id("_ieyj1c"));
            CancelButton = new Button(Driver, By.Id("_ctcgab"));
        }
    }
}
