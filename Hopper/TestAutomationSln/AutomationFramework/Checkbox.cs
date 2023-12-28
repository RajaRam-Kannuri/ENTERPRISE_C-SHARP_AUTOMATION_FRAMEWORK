using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class Checkbox : WebElement
    {
        public Checkbox(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingCheckbox]
        public bool CollectState()
        {
            return this.Selected;
        }

        [KeywordTestingCheckbox]
        public bool VerifyChecked()
        {
            return this.Selected;
        }

        [KeywordTestingCheckbox]
        public bool VerifyUnchecked()
        {
            return !this.Selected;
        }

        [KeywordTestingCheckbox]
        public void ClickIfChecked()
        {
            if (this.Selected)
                this.Click();
        }

        [KeywordTestingCheckbox]
        public void ClickIfUnchecked()
        {
            if (!this.Selected)
                this.Click();
        }
    }
}
