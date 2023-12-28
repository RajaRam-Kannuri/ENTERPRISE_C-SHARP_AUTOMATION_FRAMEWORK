using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class UpdateWaitListPage : HomePage
    {
        public Dropdown Year { get; private set; }
        public ButtonWithAlert Save { get; private set; }
        public Radio NewApplicationsOFF { get; private set; }
        public Radio NewApplicationsON { get; private set; }
        public Radio NewApplicationsNewStudentsOFF { get; private set; }
        public Radio NewApplicationsNewStudentsON { get; private set; }
        public Radio NewApplicationsRenewalStudentsOFF { get; private set; }
        public Radio NewApplicationsRenewalStudentsON { get; private set; }
        public Radio RenewalApplicationsOFF { get; private set; }
        public Radio RenewalApplicationsON { get; private set; }
        public Radio RenewalApplicationsNewStudentsOFF { get; private set; }
        public Radio RenewalApplicationsNewStudentsON { get; private set; }
        public Radio RenewalApplicationsRenewalStudentsOFF { get; private set; }
        public Radio RenewalApplicationsRenewalStudentsON { get; private set; }
        public Dropdown NewStudentScholarshipStatus { get; private set; }
        public EditField NumberOfStudentsTextbox { get; private set; }
        public Button UpdateStatus { get; private set; }

        public UpdateWaitListPage(IWebDriver driver)
            : base(driver)
        {
            Year = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            Save = new ButtonWithAlert(Driver, By.CssSelector("input[id$=\"btnUpdateWaitlistSettings\"]"));
            NewApplicationsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsOff\"]"));
            NewApplicationsON = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsOn\"]"));
            NewApplicationsNewStudentsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsNewStudentsOff\"]"));
            NewApplicationsNewStudentsON = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsNewStudentsOn\"]"));
            NewApplicationsRenewalStudentsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsRenewalStudentsOff\"]"));
            NewApplicationsRenewalStudentsON = new Radio(Driver, By.CssSelector("input[id$=\"rbNewApplicationsRenewalStudentsOn\"]"));
            RenewalApplicationsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsOff\"]"));
            RenewalApplicationsON = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsOn\"]"));
            RenewalApplicationsNewStudentsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOff\"]"));
            RenewalApplicationsNewStudentsON = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOn\"]"));
            RenewalApplicationsRenewalStudentsOFF = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsRenewalStudentsOff\"]"));
            RenewalApplicationsRenewalStudentsON = new Radio(Driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOn\"]"));
            NewStudentScholarshipStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipStatus\"]"));
            NumberOfStudentsTextbox = new EditField(Driver, By.CssSelector("input[id$=\"txtNumberOfStudents\"]"));
            UpdateStatus = new Button(Driver, By.CssSelector("input[id$=\"btnUpdateStatus\"]"));
        }
    }
}
