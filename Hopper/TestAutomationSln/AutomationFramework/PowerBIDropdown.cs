using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Data.SqlClient;


namespace AutomationFramework
{
    [KeywordTesting]
    public class PowerBIDropdown : WebElement
    {
        public PowerBIDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

		[KeywordTestingPowerBIDropdown]
        public bool SelectByPartialText(String item)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("span"));

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(item))
                {
                    lineItem.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingPowerBIDropdown]
        public bool SelectByPartialTextIfDisplayed(String item)
        {
            try
            {
                IList<IWebElement> lineItems = this.FindElements(By.TagName("span"));

                foreach (var lineItem in lineItems)
                {
                    if (lineItem.Text.Contains(item))
                    {
                        lineItem.Click();
                        return true;
                    }
                }
            }
            catch { }

            return false;
        }

        [KeywordTestingPowerBIDropdown]
        public bool VerifyOptionExistsByPartialText(String item)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("span"));

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(item))
                {
                    return true ;
                }
            }

            return false;
        }

        [KeywordTestingPowerBIDropdown]
        public bool VerifyDropdownListWithSQLResults(String sqlScript)
        {   
            String[] separator = { "+,&" };

            string[] attributes = sqlScript.Split(separator, StringSplitOptions.None);

            string connectionString = @"Data Source=.;Initial Catalog=SUFS;Integrated Security=SSPI;Server=" + attributes[2] + "; Database=SUFS";

            string tableValue = null;
            int counter = 1;
            string column = attributes[1];
            List<string> columnValues = new List<string>();

            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(attributes[0], sqlCon);
                cmd.CommandTimeout = 120;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tableValue = reader[column].ToString();
                    columnValues.Add(tableValue);

                    counter++;

                    if (counter > 1000)
                        break;
                }
            }

            IList<IWebElement> lineItems = this.FindElements(By.TagName("span"));

            foreach (var columnValue in columnValues)
            {
                foreach (var lineItem in lineItems)
                {
                    if (lineItem.Text.Equals(columnValue))
                    {
                        break;
                    }
                    if (lineItem.Equals(lineItems.LastOrDefault()))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
