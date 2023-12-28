using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class StudentDetailsPage : HomePage
    {
        public Text StudentName { get; private set; }

        public Text ApplicationNumber { get; private set; }

        public Text StudentPersonID { get; private set; }

        public Text ApplicationStatus { get; private set; }

        public Text StudentDetailsSSN { get; private set; }

        public Text NumberOfDaysInStatus { get; private set; }

        public Text StudentType { get; private set; }

        public Text ApplicationType { get; private set; }

        public Text GradeLevel { get; private set; }

        public Button EditGradeLevel { get; private set; }

        public Text FosterChild { get; private set; }

        public Text DateOfBirth { get; private set; }

        public Text OutOfHomeCare { get; private set; }

        public Text Gender { get; private set; }

        public Text FoodStampsService { get; private set; }

        public Text Ethnicity { get; private set; }

        public Text FoodStampsParent { get; private set; }

        public Text Race { get; private set; }

        public Text GuardianName { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text StudentStatus { get; private set; }

        public Text CityStateZip { get; private set; }

        public Text AwardPercent { get; private set; }

        public Button EditAwardPercent { get; private set; }

        public Text County { get; private set; }

        public Text AwardAmount { get; private set; }

        public Text HomePhone { get; private set; }

        public Text AwardDate { get; private set; }

        public Button EditAwardDate { get; private set; }

        public EditField NewAwardDate { get; private set; }

        public Button SaveNewAwardDate { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text StudentAwardID { get; private set; }

        public Text CellPhone { get; private set; }

        public Table EnrollmentsTable { get; private set; }

        public Button CreateECFButton { get; private set; }

        public Table NotesTable { get; private set; }

        public Dropdown NoteType { get; private set; }

        public Checkbox SensistiveNote { get; private set; }

        public EditField NoteText { get; private set; }

        public Button AddNoteButton { get; private set; }

        public StudentDetailsPage(IWebDriver driver)
            : base(driver)
        {
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"tbStudentName\"]"));
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"tbApplicationNumber\"]"));
            StudentPersonID = new Text(Driver, By.CssSelector("span[id$=\"tbStudentPersonId\"]"));
            ApplicationStatus = new Text(Driver, By.CssSelector("span[id$=\"txtApplicationStatus\"]"));
            StudentDetailsSSN = new Text(Driver, By.CssSelector("span[id$=\"txtStudentSSN\"]"));
            NumberOfDaysInStatus = new Text(Driver, By.CssSelector("span[id$=\"txtNumberOfDays\"]"));
            StudentType = new Text(Driver, By.CssSelector("span[id$=\"txtStudentType\"]"));
            ApplicationType = new Text(Driver, By.CssSelector("span[id$=\"txtApplicationType\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"txtGradeLevel\"]"));
            EditGradeLevel = new Button(Driver, By.CssSelector("input[id$=\"btnGradeLevelEdit\"]"));
            FosterChild = new Text(Driver, By.CssSelector("span[id$=\"txtFoster\"]"));
            DateOfBirth = new Text(Driver, By.CssSelector("span[id$=\"txtDOB\"]"));
            OutOfHomeCare = new Text(Driver, By.CssSelector("span[id$=\"txtOutOfHome\"]"));
            Gender = new Text(Driver, By.CssSelector("span[id$=\"txtGender\"]"));
            FoodStampsService = new Text(Driver, By.CssSelector("span[id$=\"txtFoodStampsService\"]"));
            Ethnicity = new Text(Driver, By.CssSelector("span[id$=\"txtEthnicity\"]"));
            FoodStampsParent = new Text(Driver, By.CssSelector("span[id$=\"txtFoodStampsParent\"]"));
            Race = new Text(Driver, By.CssSelector("span[id$=\"txtRace\"]"));
            GuardianName = new Text(Driver, By.CssSelector("span[id$=\"txtParentName\"]"));
            PhysicalAddress = new Text(Driver, By.CssSelector("span[id$=\"txtHouseholdAddress\"]"));
            StudentStatus = new Text(Driver, By.CssSelector("span[id$=\"txtScholarshipStatus\"]"));
            CityStateZip = new Text(Driver, By.CssSelector("span[id$=\"txtCityStateZip\"]"));
            AwardPercent = new Text(Driver, By.CssSelector("span[id$=\"txtAwardPercent\"]"));
            EditAwardPercent = new Button(Driver, By.CssSelector("input[id$=\"btnAwardPercentEdit\"]"));
            County = new Text(Driver, By.CssSelector("span[id$=\"txtCounty\"]"));
            AwardAmount = new Text(Driver, By.CssSelector("span[id$=\"txtAwardAmount\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"txtHomePhone\"]"));
            AwardDate = new Text(Driver, By.CssSelector("span[id$=\"txtAwardDate\"]"));
            EditAwardDate = new Button(Driver, By.CssSelector("input[id$=\"btnAwardDateEdit\"]"));
            NewAwardDate = new EditField(Driver, By.CssSelector("input[id$=\"tbxAwardDate\"]"));
            SaveNewAwardDate = new Button(Driver, By.CssSelector("input[id$=\"btnSaveAwardDate\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"txtWorkPhone\"]"));
            StudentAwardID = new Text(Driver, By.CssSelector("span[id$=\"txtStudentID\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"txtCellPhone\"]"));
            EnrollmentsTable = new Table(Driver, By.CssSelector("table[id$=\"GVEnrollments\"]"));
            CreateECFButton = new Button(Driver, By.CssSelector("btnCreateECF"));
            NotesTable = new Table(Driver, By.Id("tblNotes"));
            NoteType = new Dropdown(Driver, By.CssSelector("[id$=\"ddlNoteType\"]"));
            SensistiveNote = new Checkbox(Driver, By.CssSelector("[id$=\"cbIsSensitive\"]"));
            NoteText = new EditField(Driver, By.CssSelector("[id$=\"tbNoteText\"]"));
            AddNoteButton = new Button(Driver, By.Id("btnAddNote"));
        }
    }
}
