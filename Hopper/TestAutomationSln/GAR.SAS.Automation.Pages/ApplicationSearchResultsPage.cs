using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ApplicationSearchResultsPage : BasePage
    {
        public ApplicationTable ApplicationTable { get; private set; }

        public Link NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinApplicationResults { get; private set; }

        public ApplicationSearchResultsPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationTable = new ApplicationTable(Driver, By.Id("tblResults"));
            NumberofEntriesToShow = new Link(Driver, By.Name("tblResults_length"));
            SearchWithinApplicationResults = new EditField(Driver, By.Id("tblResults_filter"));
        }
    }
}
