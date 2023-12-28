using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class UpdateWaitListPage : HomePage
    {
        public Dropdown Year { get; private set; }
        public Button Save { get; private set; }
        public RadioButton NewApplicationsOFF { get; private set; }
        public RadioButton NewApplicationsON { get; private set; }
        public RadioButton NewApplicationsNewStudentsOFF { get; private set; }
        public RadioButton NewApplicationsNewStudentsON { get; private set; }
        public RadioButton NewApplicationsRenewalStudentsOFF { get; private set; }
        public RadioButton NewApplicationsRenewalStudentsON { get; private set; }
        public RadioButton RenewalApplicationsOFF { get; private set; }
        public RadioButton RenewalApplicationsON { get; private set; }
        public RadioButton RenewalApplicationsNewStudentsOFF { get; private set; }
        public RadioButton RenewalApplicationsNewStudentsON { get; private set; }
        public RadioButton RenewalApplicationsRenewalStudentsOFF { get; private set; }
        public RadioButton RenewalApplicationsRenewalStudentsON { get; private set; }
        public Dropdown NewStudentScholarshipStatus { get; private set; }
        public EditField NumberOfStudentsTextbox { get; private set; }
        public Button UpdateStatus { get; private set; }

        public UpdateWaitListPage(IWebDriver driver)
            : base(driver)
        {
            Year = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            Save = new Button(driver, By.CssSelector("input[id$=\"btnUpdateWaitlistSettings\"]"));
            NewApplicationsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsOff\"]"));
            NewApplicationsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsOn\"]"));
            NewApplicationsNewStudentsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsNewStudentsOff\"]"));
            NewApplicationsNewStudentsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsNewStudentsOn\"]"));
            NewApplicationsRenewalStudentsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsRenewalStudentsOff\"]"));
            NewApplicationsRenewalStudentsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbNewApplicationsRenewalStudentsOn\"]"));
            RenewalApplicationsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsOff\"]"));
            RenewalApplicationsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsOn\"]"));
            RenewalApplicationsNewStudentsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOff\"]"));
            RenewalApplicationsNewStudentsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOn\"]"));
            RenewalApplicationsRenewalStudentsOFF = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsRenewalStudentsOff\"]"));
            RenewalApplicationsRenewalStudentsON = new RadioButton(driver, By.CssSelector("input[id$=\"rbRenewalApplicationsNewStudentsOn\"]"));
            NewStudentScholarshipStatus = new Dropdown(driver, By.CssSelector("select[id$=\"ddlScholarshipStatus\"]"));
            NumberOfStudentsTextbox = new EditField(driver, By.CssSelector("input[id$=\"txtNumberOfStudents\"]"));
            UpdateStatus = new Button(driver, By.CssSelector("input[id$=\"btnUpdateStatus\"]"));
        }
    }
}
