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
    public class DetailReportTable : WebElement
    {
        public By _locateBy;
        public DetailReportTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _locateBy = locateBy;
        }

        [KeywordTestingDetailReportTable]
        public string CollectAppIdByAppType(string type)
        {
            List<String> lineString = new List<String>();

            List<IWebElement> rows = this.Body().Rows();

           foreach (var row in rows)
           {
               var lineItems = row.FindElements(By.TagName("td"));

               if (lineItems[5].Text.Equals(type))
                   return lineItems[1].Text;
           }

            return string.Empty;
        }

        [KeywordTestingDetailReportTable]
        public string CollectAppIdByAppStatus(string type)
        {
            List<String> lineString = new List<String>();

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {
                var lineItems = row.FindElements(By.TagName("td"));

                if (lineItems[3].Text.Equals(type))
                    return lineItems[1].Text;
            }

            return string.Empty;
        }
    }
}
