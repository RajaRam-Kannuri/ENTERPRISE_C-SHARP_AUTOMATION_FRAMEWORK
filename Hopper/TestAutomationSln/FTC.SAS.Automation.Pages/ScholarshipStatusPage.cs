using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class ScholarshipStatusPage : HomePage
    {
        public Table ScholarshipStatusTable { get; private set; }

        public Dropdown StudentScholarshipStatus { get; private set; }

        public Button UpdateStudentScholarshipStatusButton { get; private set; }

        public ScholarshipStatusPage(IWebDriver driver)
            : base(driver)
        {
            ScholarshipStatusTable = new Table(Driver, By.Id("tblHistoricalStatus"));
            StudentScholarshipStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipStatus\"]"));
            UpdateStudentScholarshipStatusButton = new Button(Driver, By.CssSelector("input[id$=\"btnUpdateStatus\"]"));
        }
    }
}
