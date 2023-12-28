using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class CustomDropdown : WebElement
    {
        public CustomDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
