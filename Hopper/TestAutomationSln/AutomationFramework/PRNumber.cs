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
    public class PRNumber : WebElement
    {
        public By _locateBy;
        public PRNumber(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _locateBy = locateBy;
        }

        [KeywordTestingPRNumber]
        public string CollectPRNumber()
        {
            string text = this.Text;
            string[] splitText = text.Split(' ');

            return splitText[6];
        }
    }
}
