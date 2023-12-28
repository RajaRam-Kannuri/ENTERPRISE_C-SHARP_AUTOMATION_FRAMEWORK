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
    public class PowerBITable : WebElement
    {
        public PowerBITable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingPowerBITable]
        public bool SelectReportByName(string text)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("a"));
            foreach (var lineItem in lineItems)
            {

                if (lineItem.Text.Equals(text))
                {
                    lineItem.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingPowerBITable]
        public bool VerifyTableColumnBySQLQuery(string sqlScript)
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

            IList<IWebElement> tables = this.FindElements(By.TagName("table"));
            IList<IWebElement> lineItems = tables[25].FindElements(By.TagName("tr"));

            var index = 0;
            var columnIndex = 0;

            foreach (var lineItem in lineItems)
            {
                IList<IWebElement> cells = lineItem.FindElements(By.TagName("td"));

                if (!cells[0].Text.Equals(""))
                {
                    if (index < 1)
                    {
                        foreach (var cell in cells)
                        {
                            if (cell.Text.Equals(column))
                            {
                                index = cells.IndexOf(cell);
                                break;
                            }
                        }
                    }

                    if (cells[index].Text.Equals(columnValues[columnIndex].ToString()))
                    {
                        columnIndex++;
                    }
                    else if(columnIndex != 0)
                        return false;
                }
            }

            return true;
        }
    }
}
