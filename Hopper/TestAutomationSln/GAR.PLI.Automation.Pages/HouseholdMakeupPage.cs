using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class HouseholdMakeupPage : ApplicationWizardPage
    {
        public Text PrimaryParentName { get; private set; }

        public Button EditPrimaryParentName { get; private set; }

        public EditField EditPrimaryParentFirstName { get; private set; }

        public EditField EditPrimaryParentLastName { get; private set; }

        public Button SubmitNewPrimaryParentName { get; private set; }

        public Radio IsThereAnotherParent { get; private set; }

        public EditField EditSecondaryParentFirstName { get; private set; }

        public EditField EditSecondaryParentLastName { get; private set; }

        public Button SubmitSecondaryParentName { get; private set; }

        public Button CancelEditSecondaryParentName { get; private set; }

        public Button EditSecondaryParentName { get; private set; }

        public Button DeleteSecondaryParentName { get; private set; }

        public EditField AdditionalStudentFirstName { get; private set; }

        public EditField AdditionalStudentLastName { get; private set; }

        public EditField AdditionalStudentDateOfBirth { get; private set; }
        
        public Button SubmitAdditionalStudent { get; private set; }

        public Table StudentList { get; private set; }

        public HouseholdMakeupPage(IWebDriver driver)
            : base(driver)
        {
            PrimaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblDisplayPrimaryParent\"]"));
            EditPrimaryParentName = new Button(Driver, By.Id("btnEditPrimaryParent"));
            EditPrimaryParentFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtPrimaryParentFirstName\"]"));
            EditPrimaryParentLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtPrimaryParentLastName\"]"));
            SubmitNewPrimaryParentName = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmitPrimaryParent\"]"));
            IsThereAnotherParent = new Radio(Driver, By.Id("rbSecondaryParent"));
            EditSecondaryParentFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtSPFirstName\"]"));
            EditSecondaryParentLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtSPLastName\"]"));
            SubmitSecondaryParentName = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmitSecondaryParent\"]"));
            CancelEditSecondaryParentName = new Button(Driver, By.CssSelector("input[id$=\"btnSPCancel\"]"));
            EditSecondaryParentName = new Button(Driver, By.Id("btnEditSP"));
            DeleteSecondaryParentName = new Button(Driver, By.Id("RPMainPanel_controls_household_composition_ascx22_btnDeleteSP"));
            AdditionalStudentFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentFirstName\"]"));
            AdditionalStudentLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentLastName\"]"));
            AdditionalStudentDateOfBirth = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentDOB\"]"));
            SubmitAdditionalStudent = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmitStudent\"]"));
            StudentList = new Table(Driver, By.CssSelector("table[id$=\"_dgStudents\"]"));
        }
    }
}
