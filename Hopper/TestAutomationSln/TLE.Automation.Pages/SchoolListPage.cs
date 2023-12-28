using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class SchoolListPage : CommonPage
    {
        public Table SchoolTable { get; private set; }

        public SchoolListPage(IWebDriver driver)
            : base(driver)
        {
            SchoolTable = new Table(Driver, By.CssSelector(".patt.table.table-bordered"));
        }
    }
}
