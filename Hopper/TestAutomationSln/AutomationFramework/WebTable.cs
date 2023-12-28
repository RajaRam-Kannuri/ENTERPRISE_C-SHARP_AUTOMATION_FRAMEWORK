using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class WebTable : WebElement
    {
        public WebTable(IWebDriver driver, By locateBy) : base(driver, locateBy) { }

        public Dictionary<string, string> CollectCells(IWebElement row, int fromCell = 0, int toCell = -1)
        {
            var headers = ColumnNames();
            var rowData = new Dictionary<string, string>();
            // A toRow of -1 means all, so update accordingly
            if (toCell == -1) toCell = row.Cells().Count - 1;
            for (var i = fromCell; i <= toCell; i++)
            {
                rowData.Add(!String.IsNullOrEmpty(headers[i]) ? headers[i] : i.ToString(), row.Cells()[i].Text);
            }
            return rowData;
        }

        public List<Dictionary<string, string>> CollectRows(int fromRow = 0, int toRow = -1)
        {
            var collectedRows = new List<Dictionary<string, string>>();
            var rows = this.Body().Rows();
            if (rows.Count == 0) return collectedRows;

            // A toRow of -1 means all, so update accoringly
            if (toRow == -1) toRow = rows.Count - 1;
            rows.Skip(fromRow).Take(toRow - fromRow + 1).ToList().ForEach(row => collectedRows.Add(CollectCells(row)));
            return collectedRows;
        }

        public List<Dictionary<string, string>> CollectAllRows()
        {
            return CollectRows();
        }

        public Dictionary<string, string> CollectFirstRow()
        {
            return CollectRows(0, 0).First();
        }

        public Dictionary<string, string> CollectRow(int row)
        {
            return CollectRows(row, row).First();
        }

        public List<string> ColumnNames()
        {
            var colNames = new List<string>();
            var headers = this.HeaderCells();
            headers.ForEach(hdr => colNames.Add(hdr.Text));
            return colNames;
        }

        public List<string> CollectColumn(string colName, int startingRow = 1, int endingRow = -1)
        {
            return CollectColumn(ColumnNames().IndexOf(colName), startingRow, endingRow);
        }

        public List<string> CollectColumnByPartialHeaderText(string colName, int startingRow = 1, int endingRow = -1)
        {
            var headerCell = GetHeaderCellByPartialText(colName);
            return CollectColumn(this.HeaderCells().IndexOf(headerCell), startingRow, endingRow);
        }

        public List<string> CollectColumn(int colNumber, int startingRow = 1, int endingRow = -1)
        {
            var colData = new List<string>();
            var rows = this.Body().Rows();
            if (rows.Count == 0) return colData;
            if (colNumber < 0 || colNumber >= rows[0 + startingRow].Cells().Count) return colData;
            if (endingRow == -1) endingRow = this.Body().Rows().Count - 1;

            for (int i = startingRow; i < endingRow; i++)
            {
                colData.Add(rows[i].Cells()[colNumber].Text);
            }

            //rows.Skip(1).ToList().ForEach(row => colData.Add(row.Cells()[colNumber].Text));

            return colData;
        }

        public IWebElement GetHeaderCellByText(string colName)
        {
            var headerCells = this.Header().HeaderCells();
            return headerCells.Where(cell => cell.Text == colName).FirstOrDefault();
        }

        public IWebElement GetHeaderCellByPartialText(string colName)
        {
            var headerCells = this.Header().HeaderCells();
            return headerCells.Where(cell => cell.Text.Contains(colName)).FirstOrDefault();
        }

        public List<IWebElement> FindRowsContainingText(string searchText, string colName = null)
        {
            return Locate().Rows().Where(row => row.Text.Contains(searchText)).ToList();
        }
    }
}
