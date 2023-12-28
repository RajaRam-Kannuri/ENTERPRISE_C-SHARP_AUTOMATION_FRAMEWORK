using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class ApplicationStatusPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public EditField SearchWithinResults { get; private set; }

        public Table StudentsTable { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"DdlScholarshipApplicationYear\"]"));
            SearchWithinResults = new EditField(Driver, By.Id("tblResults_filter"));
            StudentsTable = new Table(Driver, By.Id("tblResults"));
        }
    }
}
