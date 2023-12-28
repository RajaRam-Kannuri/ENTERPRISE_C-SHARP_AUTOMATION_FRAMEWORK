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
    public class FTCSASScholarshipStatusConfirmationModal : WebElement
    {
        public FTCSASScholarshipStatusConfirmationModal(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASScholarshipStatusConfirmationModal]
        public void ClickYESButton()
        {
            this.Click();
            this.FindElement(By.Id("btnYes")).Click();

            _driver.SwitchTo().Window(_driver.WindowHandles[0]);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(180));
            wait.Until(ExpectedConditions.ElementExists(By.Id("controls_applicationprocessing_applicationcontext_ascx162_lblApplicationID")));
        }

        [KeywordTestingFTCSASScholarshipStatusConfirmationModal]
        public void ClickNOButton()
        {
            this.Click();
            this.FindElement(By.Id("btnNo")).Click();
        }
    }
}
