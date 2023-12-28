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
    public class CommodityCodeTable : WebElement
    {
        public CommodityCodeTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
        }

        //[KeywordTestingCommodityCodeTable]
        //public bool VerifyEnabledNObyCommodityCode(string text)
        //{
        //    Thread.Sleep(3000);

        //    List<IWebElement> rows = this.Body().Rows();
        //    for (int i = 0; i < rows.Count; i++)
        //    {
        //        if (rows[i].Text.Contains(text))
        //        {
        //            try
        //            {
        //                var enabled = _driver.FindElement(By.XPath("//*[@id='result - table']/table/tbody/tr[" + (i+1) + "]/td[3]"));
        //                if (enabled.Text.Equals("No"))
        //                    return true;
        //                else
        //                    break;
        //            }
        //            catch
        //            {
        //                break;
        //            }
        //        }
        //    }

        //    return false;
        //}

        [KeywordTestingCommodityCodeTable]
        public bool VerifyEnabledNObyCommodityCode()
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {

                var fields = row.FindElements(By.TagName("td"));

                if (fields[2].Text.Equals("No"))
                    return true;
            }

            return false;
        }

        //[KeywordTestingCommodityCodeTable]
        //public bool VerifyEnabledYESbyCommodityCode(string text)
        //{
        //    List<IWebElement> rows = this.Body().Rows();
        //    for (int i = 0; i < rows.Count; i++)
        //    {
        //        if (rows[i].Text.Contains(text))
        //        {
        //            try
        //            {
        //                var enabled = _driver.FindElement(By.XPath("//*[@id='result - table']/table/tbody/tr[" + (i + 1) + "]/td[3]"));
        //                if (enabled.Text.Equals("Yes"))
        //                    return true;
        //                else
        //                    break;
        //            }
        //            catch
        //            {
        //                break;
        //            }
        //        }
        //    }

        //    return false;
        //}

        [KeywordTestingCommodityCodeTable]
        public bool VerifyEnabledYESbyCommodityCode()
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {

                var fields = row.FindElements(By.TagName("td"));

                if (fields[2].Text.Equals("Yes"))
                    return true;
            }

            return false;
        }

        [KeywordTestingCommodityCodeTable]
        public bool ClickUpdateByCommodityCode(string text)
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    try
                    {
                        rows[i].FindElement(By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_rptCommodityCodes_ctl0" + i + "_btnUpdate']")).Click();
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

        [KeywordTestingCommodityCodeTable]
        public bool VerifyFirstRowCategoryByText(string text)
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {

                var fields = row.FindElements(By.TagName("td"));

                if (fields[3].Text.Equals(text))
                    return true;
            }

            return false;
        }

        [KeywordTestingCommodityCodeTable]
        public bool VerifyFirstRowCategoryIsEmpty()
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {

                var fields = row.FindElements(By.TagName("td"));

                if (fields[3].Text.Equals(""))
                    return true;
            }

            return false;
        }
    }
}
