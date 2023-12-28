using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class StudentSearchResultsSection : ControlSection
    {
        public Table StudentTable { get; private set; }

        public Dropdown NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinStudentResults { get; private set; }

        public StudentSearchResultsSection(IWebDriver driver)
            : base(driver)
        {
            StudentTable = new Table(Driver, By.Id("tblResults"));
            NumberofEntriesToShow = new Dropdown(Driver, By.Name("tblResults_length"));
            SearchWithinStudentResults = new EditField(Driver, By.Id("tblResults_filter"));
        }
    }
}
