using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class AddAStudentPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public EditField ApplicationId { get; private set; }

        public Table StudentsTable { get; private set; }

        public Button AddNewStudentButton { get; private set; }

        public StudentInformationSection StudentInformation { get; private set; }

        public Button SaveNewStudentButton { get; private set; }

        public Button CancelNewStudentButton { get; private set; }

        public WebElement ConfirmationModal { get; private set; }

        public Button ConfirmSaveButton { get; private set; }

        public Button CancelSaveButton { get; private set; }

        public WebElement SaveSuccessMessage { get; private set; }

        public AddAStudentPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
            ApplicationId = new EditField(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            StudentsTable = new Table(Driver, By.CssSelector("table[id$=\"grdChildren\"]"));
            AddNewStudentButton = new Button(Driver, By.CssSelector("input[id$=\"_btnAddStudent\"]"));
            StudentInformation = new StudentInformationSection(Driver);
            SaveNewStudentButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveNewStudent\"]"));
            CancelNewStudentButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancelNewStudent\"]"));
            ConfirmationModal = new Modal(Driver, By.CssSelector("div[id$=\"popConfirmSave_PW-1\"]"));
            ConfirmSaveButton = new Button(Driver, By.CssSelector("input[id$=\"btnConformSaveStudent\"]"));
            CancelSaveButton = new Button(Driver, By.CssSelector("input[id$=\"btnConfirmCancel\"]"));
            SaveSuccessMessage = new Text(Driver, By.CssSelector("span[id$=\"lblSaveStudentSuccess\"]"));
        }
    }
}
