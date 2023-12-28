using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class Radio : WebElement
    {
        public Radio(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingRadio]
        [KeywordTestingCollectionMethod]
        public bool CollectState()
        {
            return this.Selected;
        }

        [KeywordTestingRadio]
        [KeywordTestingVerificationMethod]
        public bool VerifyChecked()
        {
            return this.Selected;
        }

        [KeywordTestingRadio]
        [KeywordTestingVerificationMethod]
        public bool VerifyUnchecked()
        {
            return !this.Selected;
        }
    }
}
