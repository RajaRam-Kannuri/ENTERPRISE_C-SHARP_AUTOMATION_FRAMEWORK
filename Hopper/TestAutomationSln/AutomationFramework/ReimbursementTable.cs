using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using AutomationFramework;

namespace AutomationFramework
{
    [KeywordTesting]
    public class ReimbursementTable : WebElement
    {
        public ReimbursementTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementTable]
        public bool ClickApproveByReimbursementID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    try
                    {
                        _driver.FindElement(By.CssSelector("a[href$='" + text + "']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingReimbursementTable]
        public bool ClickLinkByReimbursementID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    try
                    {
                        _driver.FindElement(By.CssSelector("a[ID$='lbClaimID']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    int index = 0;

                    while (_driver.WindowHandles.Count < 3)
                    {
                        Thread.Sleep(1000);
                        index++;

                        if (index > 5)
                            break;
                    }

                    foreach (String handle in _driver.WindowHandles)
                    {
                        _driver.SwitchTo().Window(handle);
                        if (_driver.Title.Contains("Worksheet"))
                            break;
                    }

                    return true;
                }
            }

            return false;
        }

		[KeywordTestingReimbursementTable]
		public bool ClickLinkByRequestStatus(string text)
		{
			List<IWebElement> rows = this.Body().Rows();
			for (int i = 0; i < rows.Count; i++)
			{
				if (rows[i].Text.Contains(text))
				{
					_driver.FindElement(By.CssSelector("a[ID$='lbClaimID']")).Click();

					int index = 0;

					while (_driver.WindowHandles.Count < 3)
					{
						Thread.Sleep(1000);
						index++;

						if (index > 5)
							break;
					}

					foreach (String handle in _driver.WindowHandles)
					{
						_driver.SwitchTo().Window(handle);
						if (_driver.Title.Contains("Worksheet"))
							break;
					}

					return true;
				}
			}

			return false;
		}

		[KeywordTestingReimbursementTable]
		public bool ClickLinkByRequestStatusAndValidateAlertMessageAppears(string text)
		{
			List<IWebElement> rows = this.Body().Rows();
			for (int i = 0; i < rows.Count; i++)
			{
				if (rows[i].Text.Contains(text))
				{
					_driver.FindElement(By.CssSelector("a[ID$='lbClaimID']")).Click();

					int index = 0;

					while (_driver.WindowHandles.Count < 3)
					{
						Thread.Sleep(1000);
						index++;

						if (index > 5)
							break;
					}

					if (_driver.WindowHandles.Count == 2)
					{
						_driver.SwitchTo().Window(_driver.WindowHandles[1]).Close();
						_driver.SwitchTo().Window(_driver.WindowHandles[0]);
						return true;
					}
				}
			}

			return false;
		}

        [KeywordTestingReimbursementTable]
        public bool ClickLinkByRequestStatusAndValidateAlertMessageDoesNOTAppear(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    _driver.FindElement(By.CssSelector("a[ID$='lbClaimID']")).Click();

                    int index = 0;

                    while (_driver.WindowHandles.Count < 3)
                    {
                        Thread.Sleep(1000);
                        index++;

                        if (index > 5)
                            break;
                    }

                    if (_driver.WindowHandles.Count == 2)
                    {
                        _driver.SwitchTo().Window(_driver.WindowHandles[1]).Close();
                        _driver.SwitchTo().Window(_driver.WindowHandles[0]);
                        return false;
                    }
                }
            }

            return true;
        }

        [KeywordTestingReimbursementTable]
        public bool ClickDetailsByReimbursementID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    try
                    {
                        _driver.FindElement(By.CssSelector("a[href$='openClaimDetails(" + text + ")']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingReimbursementTable]
        public bool VerifyActionIsRequiredByReimbursementID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    if (_driver.ElementExists(By.CssSelector("img[alt$='Requires Action']")))
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }

            return false;
        }

        [KeywordTestingReimbursementTable]
        public bool VerifyActionIsNotRequiredByReimbursementID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    if (!_driver.ElementExists(By.CssSelector("img[alt$='Requires Action']")))
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }

            return false;
        }
    }
}
