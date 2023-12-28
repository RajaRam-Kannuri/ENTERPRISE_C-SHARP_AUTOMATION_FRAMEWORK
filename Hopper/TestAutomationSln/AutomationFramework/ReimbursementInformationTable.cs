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
    public class ReimbursementInformationTable : WebElement
    {
        public ReimbursementInformationTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementInformationTable]
        public bool VerifyDataExistsInTable(string text)
        {
            List<IWebElement> rows = this.Body().Rows();

            if (rows.Count > 0)
                return true;

            return false;
        }
    }
}
