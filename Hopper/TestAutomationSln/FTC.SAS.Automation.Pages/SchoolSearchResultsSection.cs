using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class SchoolSearchResultsSection : ControlSection
    {
        public Table SchoolTable { get; private set; }

        public Dropdown NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinSchoolResults { get; private set; }

        public Button DownloadToExcel { get; private set; }

        public Button SendEmailToSchools { get; private set; }

        #region Keyword Testing Additions

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsLoginLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsProfileLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsContactLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsAppStatusLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsTuitionFeesLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link SchoolSearchResultsViewVRLink { get; private set; }

        #endregion Keyword Testing Additions

        public SchoolSearchResultsSection(IWebDriver driver)
            : base(driver)
        {
            SchoolTable = new Table(Driver, By.Id("tblSchoolSearch"));
            NumberofEntriesToShow = new Dropdown(Driver, By.Name("tblSchoolSearch_length"));
            SearchWithinSchoolResults = new EditField(Driver, By.Id("tblSchoolSearch_filter"));
            DownloadToExcel = new Button(Driver, By.Id("ToolTables_tblSchoolSearch_0"));
            SendEmailToSchools = new Button(Driver, By.Id("ToolTables_tblSchoolSearch_1"));
            #region Keyword Testing Additions
            SchoolSearchResultsLoginLink = new Link(Driver, By.CssSelector("a[id$=\"lbLogin\"]"));
            SchoolSearchResultsProfileLink = new Link(Driver, By.CssSelector("a[id$=\"lbProfile\"]"));
            SchoolSearchResultsContactLink = new Link(Driver, By.CssSelector("a[id$=\"lbContact\"]"));
            SchoolSearchResultsAppStatusLink = new Link(Driver, By.CssSelector("a[id$=\"lbAppStatus\"]"));
            SchoolSearchResultsTuitionFeesLink = new Link(Driver, By.CssSelector("a[id$=\"lbTuitionFees\"]"));
            SchoolSearchResultsViewVRLink = new Link(Driver, By.CssSelector("a[id$=\"lbViewVR\"]"));
            #endregion Keyword Testing Additions
        }
    }
}
