using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class InvalidInfoButton : WebElement
    {

        protected readonly IWebDriver _driver;

        public InvalidInfoButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _driver = driver;
        }

        //[KeywordTestingInvalidInfoButton]
        //public void ClickOkay(string expectedValue)
        //{
        //    if (this.Exists())
        //    {
        //        _driver.FindElement(By.XPath("//*[@id='ValidationPopup_ModalContentTemplateLabelValidationPopup']/table/tbody/tr/td[2]/input[1]")).Click();
        //        this.Click();
        //        _driver.FindElement(By.Id("RPMainPanel_BtnNext")).Click();
        //    }
        //}

        [KeywordTestingInvalidInfoButton]
        public void ClickOkay(string expectedValue)
        {
            try
            {
                _driver.FindElement(By.XPath("//*[@id='ValidationPopup_ModalContentTemplateLabelValidationPopup']/table/tbody/tr/td[2]/input[1]")).Click();
                this.Click();
                _driver.FindElement(By.Id("RPMainPanel_BtnNext")).Click();
            }
            catch (Exception exception)
            {
                // These are the ones we want to eat. If it's not one of them, send it on up the line.
                if (!(exception is NoSuchElementException || exception is ElementNotVisibleException))
                {
                    throw;
                }
            }
        }
    }
}
