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
    public class ApplicationHouseholdMakeupPage : ApplicationWizardPage
    {
        public Text PrimaryParentName { get; private set; }

        public Text SecondaryParentName { get; private set; }

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

        public Button SubmitAdditionalStudent { get; private set; }

        public Table StudentList { get; private set; }

        public Radio AddOtherChildren { get; private set; }

        public EditField AdditionalChildFirstName { get; private set; }

        public EditField AdditionalChildLastName { get; private set; }

        public Button SubmitAdditionalChild { get; private set; }

        public Button CancelAdditionalChild { get; private set; }

        public Table AdditionalChildren { get; private set; }

        public Radio AddOtherAdults { get; private set; }

        public Radio HaveRoommateYes { get; private set; }

        public Radio HaveRoommateNo { get; private set; }

        public Dropdown NumberOfRoommates { get; private set; }

        public EditField AdditionalAdultFirstName { get; private set; }

        public EditField AdditionalAdultLastName { get; private set; }

        public Button SubmitAdditionalAdult { get; private set; }

        public Button CancelAdditionalAdult { get; private set; }

        public Table AdditionalAdults { get; private set; }
        
        public Text PrimaryParentCount { get; private set; }

        public Text SecondaryParentCount { get; private set; }

        public Text StudentsCount { get; private set; }

        public Text OtherChildrenCount { get; private set; }

        public Text OtherAdultsCount { get; private set; }

        public Text TotaHouseholdMembersCount { get; private set; }

        public ApplicationHouseholdMakeupPage(IWebDriver driver)
            : base(driver)
        {
            PrimaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblDisplayPrimaryParent\"]"));
            SecondaryParentName = new Text(Driver, By.CssSelector("span[id$=\"lblSecondaryParent\"]"));
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
            DeleteSecondaryParentName = new Button(Driver, By.CssSelector("input[id$=\"_btnDeleteSP\"]"));
            AdditionalStudentFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentFirstName\"]"));
            AdditionalStudentLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentLastName\"]"));
            SubmitAdditionalStudent = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmitStudent\"]"));
            StudentList = new Table(Driver, By.CssSelector("table[id$=\"_dgStudents\"]"));
            AddOtherChildren = new Radio(Driver, By.Id("rbOtherChildren"));
            AdditionalChildFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtOtherChildFirstName\"]"));
            AdditionalChildLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtOtherChildLastName\"]"));
            SubmitAdditionalChild = new Button(Driver, By.CssSelector("input[id$=\"_btnAddOtherChildren\"]"));
            CancelAdditionalChild = new Button(Driver, By.CssSelector("input[id$=\"_btnCancelOtherChildren\"]"));
            AdditionalChildren = new Table(Driver, By.CssSelector("table[id$=\"_dgStudents\"]"));
            AddOtherAdults = new Radio(Driver, By.Id("rbOtherAdults"));
            HaveRoommateYes = new Radio(Driver, By.CssSelector("input[id$=\"_rblRoommates_0\"]"));
            HaveRoommateNo = new Radio(Driver, By.CssSelector("input[id$=\"_rblRoommates_1\"]"));
            NumberOfRoommates = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlRoommates\"]"));
            AdditionalAdultFirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtOtherAdultFirstName\"]"));
            AdditionalAdultLastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtOtherAdultLastName\"]"));
            SubmitAdditionalAdult = new Button(Driver, By.CssSelector("input[id$=\"_btnAddOtherAdult\"]"));
            CancelAdditionalAdult = new Button(Driver, By.CssSelector("input[id$=\"_btnCancelOtherAdult\"]"));
            AdditionalAdults = new Table(Driver, By.CssSelector("table[id$=\"_gvOtherAdults\"]"));
        }
    }
}
