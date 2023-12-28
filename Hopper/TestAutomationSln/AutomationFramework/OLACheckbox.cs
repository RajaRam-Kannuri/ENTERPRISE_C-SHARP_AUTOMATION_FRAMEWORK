using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    [KeywordTesting]
    public class OLACheckbox : WebElement
    {
        public OLACheckbox(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

        [KeywordTestingOLACheckbox]
        public void ClickIfCheckboxIsEmpty()
        {
            EditField MailingAddress = new EditField(_driver, By.Id("mailingStreetAddress"));

            if (_driver.ElementExists(MailingAddress))
                this.Click();
        }

        [KeywordTestingOLACheckbox]
        public void ClickIfCheckboxIsChecked()
        {
            EditField MailingAddress = new EditField(_driver, By.Id("mailingStreetAddress"));

            if (!_driver.ElementExists(MailingAddress))
                this.Click();
        }
    }
}
