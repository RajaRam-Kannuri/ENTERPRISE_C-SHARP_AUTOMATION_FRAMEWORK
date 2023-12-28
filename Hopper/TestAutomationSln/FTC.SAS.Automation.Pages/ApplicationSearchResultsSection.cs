using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class ApplicationSearchResultsSection : ControlSection
    {
        public Table ApplicationTable { get; private set; }

        public Dropdown NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinApplicationResults { get; private set; }

        #region Keyword Testing Additions

        [KeywordTestingRequiresStoredElement]
        public Link ApplicationSearchResultsScanLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link ApplicationSearchResultsProcessLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link ApplicationSearchResultsContactLink { get; private set; }

        #endregion Keyword Testing Additions

        public ApplicationSearchResultsSection(IWebDriver driver)
            : base(driver)
        {
            ApplicationTable = new Table(Driver, By.Id("tblResults"));
            NumberofEntriesToShow = new Dropdown(Driver, By.Name("tblResults_length"));
            SearchWithinApplicationResults = new EditField(Driver, By.Id("tblResults_filter"));
            #region Keyword Testing Additions
            ApplicationSearchResultsScanLink = new Link(Driver, By.CssSelector("a[id$=\"lbScan\"]"));
            ApplicationSearchResultsProcessLink = new Link(Driver, By.CssSelector("a[id$=\"lbProcess\"]"));
            ApplicationSearchResultsContactLink = new Link(Driver, By.CssSelector("a[id$=\"lbContact\"]"));
            #endregion Keyword Testing Additions
        }
    }
}
