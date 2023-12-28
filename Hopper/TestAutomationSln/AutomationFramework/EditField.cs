using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class EditField : WebElement
    {
        public EditField(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingEditField]
        [KeywordTestingCollectionMethod]
        public string CollectValue()
        {
            return this.Value();
        }

        [KeywordTestingEditField]
        [KeywordTestingVerificationMethod]
        public bool VerifyTextEquals(string expectedValue)
        {
            return CollectValue() == expectedValue;
        }

        [KeywordTestingEditField]
        [KeywordTestingVerificationMethod]
        public bool VerifyTextDoesNotEqual(string expectedValue)
        {
            return CollectValue() != expectedValue;
        }

        [KeywordTestingEditField]
        [KeywordTestingVerificationMethod]
        public bool VerifyTextPartiallyEquals(string expectedValue)
        {
            return CollectValue().Contains(expectedValue);
        }

        [KeywordTestingEditField]
        public void SetTextIfFieldEnabled(object data)
        {
            if (data == null) return;

            if (_driver.ElementExists(this) && this.Locate().Enabled)
            {
                this.SendKeys(Keys.Control + "a");
                this.SendKeys(Keys.Delete);
                this.SendKeys(data.ToString());
            }
        }
    }
}
