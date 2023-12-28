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
    public class OLAStudentsTable : WebElement
    {
        public OLAStudentsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingOLAStudentsTable]
        public bool ClickUpdateByStudentName(string text)
        {
            IList<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                    buttons[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingOLAStudentsTable]
        public bool DeleteAllNewStudents(string text)
        {
            IList<IWebElement> lineItems = LocateAll(10);

            while (lineItems != null)
            {
                foreach (var lineItem in lineItems)
                {
                    try
                    {
                        IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                        buttons[1].Click();
                        _driver.FindElement(By.XPath("//a[text() = 'Delete']")).Click();
                    }
                    catch { }
                }

                lineItems = LocateAll(5);
            }

            return true;
        }

        [KeywordTestingOLAStudentsTable]
        public bool ClickReviewByStudentName(string text)
        {
            IList<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                    buttons[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingOLAStudentsTable]
        public bool ClickDeleteByStudentName(string text)
        {
            IList<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                    buttons[1].Click();
                    return true;
                }
            }

            return false;
        }

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent1UncheckTheRest(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				foreach (var lineItem in lineItems)
				{
                    if (lineItems.IndexOf(lineItem) > 0)
                    {
                        IList<IWebElement> elem = lineItem.FindElements(By.TagName("label"));
                        elem[0].Click();
                    }
				}

				IList<IWebElement> buttons = lineItems[0].FindElements(By.TagName("a"));
				buttons[0].Click();
                return true;
            }

			return false;
		}

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent1(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				IList<IWebElement> buttons = lineItems[0].FindElements(By.TagName("a"));
				buttons[0].Click();
				return true;
			}

			return false;
		}

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent2(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				IList<IWebElement> buttons = lineItems[1].FindElements(By.TagName("a"));
				buttons[0].Click();
				return true;
			}

			return false;
		}

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent3(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				IList<IWebElement> buttons = lineItems[2].FindElements(By.TagName("a"));
				buttons[0].Click();
				return true;
			}

			return false;
		}

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent4(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				IList<IWebElement> buttons = lineItems[3].FindElements(By.TagName("a"));
				buttons[0].Click();
				return true;
			}

			return false;
		}

		[KeywordTestingOLAStudentsTable]
		public bool ClickReviewStudent5(string text)
		{
			IList<IWebElement> lineItems = LocateAll();

			if (lineItems.Count >= 1)
			{
				IList<IWebElement> buttons = lineItems[4].FindElements(By.TagName("a"));
				buttons[0].Click();
				return true;
			}

			return false;
		}
	}
}
