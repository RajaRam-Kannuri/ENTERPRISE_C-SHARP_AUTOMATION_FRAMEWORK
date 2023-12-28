using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class DivTable : WebElement
    {
        private WebElement LeftSide { get; }

        private WebElement RightSide { get; }

        public DivTable(IWebDriver driver, By locateBy)
            : base(driver, locateBy)
        {
            LeftSide = new WebElement(_driver, By.CssSelector(".left.ui-grid-render-container"));
            RightSide = new WebElement(_driver, By.CssSelector(":not(.left).ui-grid-render-container"));
        }

        public int RowCount()
        {
            return LeftSide.FindElements(By.CssSelector("div[role='row'][ui-grid-row='row']")).Count;
        }

        [KeywordTestingDivTable]
        [KeywordTestingFindRowNumber]
        public int FindRowWithData(string text)
        {
            List<IWebElement> divRows = LeftSide.FindElements(By.CssSelector("div[role='row'][ui-grid-row='row']")).ToList();
            for (int i = 0; i < divRows.Count; i++)
            {
                if (divRows[i].Text.Contains(text))
                    return i;
            }
            
            return -1;
        }

        [KeywordTestingDivTable]
        [KeywordTestingFindColumnNumber]
        public int FindColumnWithData(string text)
        {
            //List<IWebElement> columnHeaders = RightSide.FindElements(By.CssSelector(".ui-grid-header-cell")).Where(colHeader => colHeader.Text != String.Empty).ToList();
            List<IWebElement> columnHeaders = RightSide.FindElements(By.CssSelector("div[role='columnheader']")).Where(colHeader => colHeader.Text != string.Empty).ToList();
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                IWebElement columnHeaderLink = columnHeaders[i].FindElement(By.TagName("a"));
                if (columnHeaderLink.Text.Contains(text))
                    return i;
            }

                return -1;
        }

        public void ActivateCell(int row, int column)
        {
            //RightSide.Rows()[row].Cells()[column].Click();
            IWebElement divRow = RightSide.FindElements(By.CssSelector("div[role='row'][ui-grid-row='row']"))[row];
            IWebElement cell = divRow.FindElements(By.CssSelector("div[role='gridcell']"))[column];
            cell.Click();
        }
    }
}
