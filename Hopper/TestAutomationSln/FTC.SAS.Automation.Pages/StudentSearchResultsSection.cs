using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class StudentSearchResultsSection : ControlSection
    {
        public Table StudentTable { get; private set; }

        public Dropdown NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinStudentResults { get; private set; }

        #region Keyword Testing Additions

        public Link StudentSearchResultsStudentDetailsLink { get; private set; }

        public Link StudentSearchResultsSCFLink { get; private set; }

        public Link StudentSearchResultsConfirmEnrollmentLink { get; private set; }

        #endregion Keyword Testing Additions

        public StudentSearchResultsSection(IWebDriver driver)
            : base(driver)
        {
            StudentTable = new Table(Driver, By.Id("tblResults"));
            NumberofEntriesToShow = new Dropdown(Driver, By.Name("tblResults_length"));
            SearchWithinStudentResults = new EditField(Driver, By.Id("tblResults_filter"));
            #region Keyword Testing Additions
            StudentSearchResultsStudentDetailsLink = new Link(Driver, By.CssSelector("a[id$=\"lbStudentDetail\"]"));
            StudentSearchResultsSCFLink = new Link(Driver, By.CssSelector("a[id$=\"lbSCF\"]"));
            StudentSearchResultsConfirmEnrollmentLink = new Link(Driver, By.CssSelector("a[id$=\"lbConfirmEnrollment\"]"));
            #endregion Keyword Testing Additions
        }
    }
}
