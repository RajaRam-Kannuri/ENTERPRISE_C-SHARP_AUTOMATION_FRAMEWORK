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
    public class FTCSLIStudentTable : WebElement
    {
        public FTCSLIStudentTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSLIStudentTable]
        public bool ClickWithdrawByStudentLastName (string name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement lastName = lineItem.FindElement(By.CssSelector("span[id$=\"lblLastName\"]"));

                    if (lastName.Text.Equals(name))
                    {
                        IWebElement btn = lineItem.FindElement(By.CssSelector("input[id$=\"btnWithdraw\"]"));
                        btn.Click();
                        return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSLIStudentTable]
        public bool ClickWithdrawForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    //IWebElement lastName = lineItem.FindElement(By.CssSelector("span[id$=\"lblLastName\"]"));

                    //if (lastName.Text.Equals(name))
                    //{
                        IWebElement btn = lineItem.FindElement(By.CssSelector("input[id$=\"btnWithdraw\"]"));
                        btn.Click();
                        return true;
                    //}
                }
            }

            return false;
        }

        [KeywordTestingFTCSLIStudentTable]
        public bool ClickRegisterByApplicationID(string id)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement appID = lineItem.FindElement(By.CssSelector("span[id$=\"lblAppId\"]"));

                    if (appID.Text.Equals(id))
                    {
                        IWebElement btn = lineItem.FindElement(By.CssSelector("input[id$=\"btnRegister\"]"));
                        btn.Click();
                        return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSLIStudentTable]
        public bool ClickRegisterForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    //IWebElement lastName = lineItem.FindElement(By.CssSelector("span[id$=\"lblLastName\"]"));

                    //if (lastName.Text.Equals(name))
                    //{
                    IWebElement btn = lineItem.FindElement(By.CssSelector("input[id$=\"btnRegister\"]"));
                    btn.Click();
                    return true;
                    //}
                }
            }

            return false;
        }
        //[KeywordTestingFTCSLIStudentTable]
        //public bool ConfirmAllStudentsAreDeniedStatus()
        //{
        //    IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

        //    foreach (var lineItem in lineItems)
        //    {
        //        if (lineItems.IndexOf(lineItem) > 0)
        //        {
        //            IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
        //            status[0].Click();

        //            if (!status[0].Text.Equals("Denied"))
        //                return false;
        //        }
        //    }
        //    return true;
        //}

        //[KeywordTestingFTCSLIStudentTable]
        //public bool ConfirmAllStudentsArePendingStatus()
        //{
        //    IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

        //    foreach (var lineItem in lineItems)
        //    {
        //        if (lineItems.IndexOf(lineItem) > 0)
        //        {
        //            IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
        //            status[0].Click();

        //            if (!status[0].Text.Equals("Pending"))
        //                return false;
        //        }
        //    }
        //    return true;
        //}
        //[KeywordTestingFTCSLIStudentTable]
        //public bool ConfirmAllStudentsAreWaitListStatus()
        //{
        //    IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

        //    foreach (var lineItem in lineItems)
        //    {
        //        if (lineItems.IndexOf(lineItem) > 0)
        //        {
        //            IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
        //            status[0].Click();

        //            if (!status[0].Text.Equals("Wait List"))
        //                return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
