using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class Text : WebElement
    {
        public Text(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingText]
        [KeywordTestingCollectionMethod]
        public string CollectValue()
        {
            return this.Text;
        }


        [KeywordTestingText]
        [KeywordTestingVerificationMethod]
        public bool VerifyTextEquals(string text)
        {
            return this.Text == text;
        }

        [KeywordTestingText]
        [KeywordTestingVerificationMethod]
        public bool VerifyByPartialText(string text)
        {
            return this.Text.Contains(text);
        }
    }
}
