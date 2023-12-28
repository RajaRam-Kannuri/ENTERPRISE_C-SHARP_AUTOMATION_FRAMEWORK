using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SLI.Automation.Pages
{
    public class RegisterNewStudentPage : StudentInfoPage
    {
        public EditField StudentAwardID { get; private set; }

        public EditField StudentFirstName { get; private set; }

        public EditField StudentLastName { get; private set; }

        public EditField ApplicationId { get; private set; }

        public Button SearchForStudent { get; private set; }

        public Table StudentList { get; private set; }

        public Text NoResultsMessage { get; private set; }

        public Dropdown SchoolYearDropdown { get; private set; }

        public RegisterNewStudentPage(IWebDriver driver)
            : base(driver)
        {
            StudentAwardID = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentAwardId\"]"));
            StudentFirstName = new EditField(Driver, By.CssSelector("input[id$=\"txtFirstName\"]"));
            StudentLastName = new EditField(Driver, By.CssSelector("input[id$=\"txtLastName\"]"));
            ApplicationId = new EditField(Driver, By.CssSelector("input[id$=\"txtApplicationId\"]"));
            SearchForStudent = new Button(Driver, By.CssSelector("input[id$=\"btnSearchStudent\"]"));
            StudentList = new Table(Driver, By.CssSelector("table[id$=\"GVStudents\"]"));
            NoResultsMessage = new Text(Driver, By.CssSelector("span[id$=\"lblNoResult\"]"));
            SchoolYearDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
        }
    }
}
