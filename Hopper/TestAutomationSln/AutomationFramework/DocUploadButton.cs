using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class DocUploadButton : CustomWebElement
    {
        public DocUploadButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingDocUploadButton]
        public void ClickButton()
        {
            IWebElement element = LocateAndEnsureUsable();
            //element.SendKeys(@"I:\Hopper\borat1.jpg");
            element.SendKeys(@"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\borat1.jpg");
        }

        [KeywordTestingDocUploadButton]
		public void ClickButtonAndSendImage(String text)
		{
            IWebElement element = LocateAndEnsureUsable();
            element.SendKeys(text);
        }
    }
}
