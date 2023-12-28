using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework
{
    [KeywordTesting]
    public class ContactLogsTable : WebElement
    {
        public ContactLogsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingContactLogsTable]
        public bool VerifyNewEntryWasCreated()
        {
            List<IWebElement> rows = this.Body().Rows();
            if (rows.Last().Text.Contains(DateTime.Now.ToString("HH:mm")) || rows.Last().Text.Contains((DateTime.Now.AddMinutes(-1)).ToString("HH:mm")))
                return true;

            return false;
        }
    }
}
