using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ReimbursementSearchResultsPage : HomePage
    {
        public ReimbursementTable ReimbursementTable { get; private set; }

        public ReimbursementSearchResultsPage(IWebDriver driver)
            : base(driver)
        {
            ReimbursementTable = new ReimbursementTable(Driver, By.Id("tblResults"));
        }
    }
}
