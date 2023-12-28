using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class OLADocUploadButton : CustomWebElement
    {
        public OLADocUploadButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingOLADocUploadButton]
        public void ClickButton()
        {
            IWebElement element = LocateAndEnsureUsable();
            element.Click();
        }

		[KeywordTestingOLADocUploadButton]
		public void ClickButtonAndSendImage(String path)
		{
            IWebElement element = LocateAndEnsureUsable();

            if (String.IsNullOrEmpty(path))
                //path = @"I:\QA Tools\Hopper\Images\JPG - Test Doc for jpg.jpg";
                //path = @"U:\IT\Restricted\QA Tools\Hopper\Images\JPG - Test Doc for jpg.jpg";
                path = @"\\AZ-PC-QA1\KWDT Temp Repo\QA Tools\Images\JPG - Test Doc for jpg.jpg";

            element.Click();
            Thread.Sleep(3000);

            try
            {
                System.Windows.Forms.SendKeys.SendWait(path);
                Thread.Sleep(3000);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");

            }
            catch { }

            Thread.Sleep(3000);
        }
    }
}
