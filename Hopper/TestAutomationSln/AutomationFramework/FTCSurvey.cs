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
    public class FTCSurvey : WebElement
    {
        public FTCSurvey(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
		[KeywordTestingFTCSurvey]
		public bool CompleteAndSubmitSurvey(String data)
		{
            try
            {
                _driver.FindElement(By.CssSelector("label[for$=\"sgE-3846737-1-5-10096\"]")).Click();
                _driver.FindElement(By.CssSelector("label[for$=\"sgE-3846737-1-6-10104\"]")).Click();
                _driver.FindElement(By.CssSelector("label[for$=\"sgE-3846737-1-2-10001\"]")).Click();
                _driver.FindElement(By.Id("sg_SubmitButton")).Click();
            }
            catch
            {
                return false;
            }

			return true;
		}
	}
}
