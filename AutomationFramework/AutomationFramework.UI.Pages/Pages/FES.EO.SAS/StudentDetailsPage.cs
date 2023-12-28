using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
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
            StudentName = new Text(driver, By.CssSelector("span[id$=\"tbStudentName\"]"));
            ApplicationNumber = new Text(driver, By.CssSelector("span[id$=\"tbApplicationNumber\"]"));
            StudentPersonID = new Text(driver, By.CssSelector("span[id$=\"tbStudentPersonId\"]"));
            ApplicationStatus = new Text(driver, By.CssSelector("span[id$=\"txtApplicationStatus\"]"));
            StudentDetailsSSN = new Text(driver, By.CssSelector("span[id$=\"txtStudentSSN\"]"));
            NumberOfDaysInStatus = new Text(driver, By.CssSelector("span[id$=\"txtNumberOfDays\"]"));
            StudentType = new Text(driver, By.CssSelector("span[id$=\"txtStudentType\"]"));
            ApplicationType = new Text(driver, By.CssSelector("span[id$=\"txtApplicationType\"]"));
            GradeLevel = new Text(driver, By.CssSelector("span[id$=\"txtGradeLevel\"]"));
            EditGradeLevel = new Button(driver, By.CssSelector("input[id$=\"btnGradeLevelEdit\"]"));
            FosterChild = new Text(driver, By.CssSelector("span[id$=\"txtFoster\"]"));
            DateOfBirth = new Text(driver, By.CssSelector("span[id$=\"txtDOB\"]"));
            OutOfHomeCare = new Text(driver, By.CssSelector("span[id$=\"txtOutOfHome\"]"));
            Gender = new Text(driver, By.CssSelector("span[id$=\"txtGender\"]"));
            FoodStampsService = new Text(driver, By.CssSelector("span[id$=\"txtFoodStampsService\"]"));
            Ethnicity = new Text(driver, By.CssSelector("span[id$=\"txtEthnicity\"]"));
            FoodStampsParent = new Text(driver, By.CssSelector("span[id$=\"txtFoodStampsParent\"]"));
            Race = new Text(driver, By.CssSelector("span[id$=\"txtRace\"]"));
            GuardianName = new Text(driver, By.CssSelector("span[id$=\"txtParentName\"]"));
            PhysicalAddress = new Text(driver, By.CssSelector("span[id$=\"txtHouseholdAddress\"]"));
            StudentStatus = new Text(driver, By.CssSelector("span[id$=\"txtScholarshipStatus\"]"));
            CityStateZip = new Text(driver, By.CssSelector("span[id$=\"txtCityStateZip\"]"));
            AwardPercent = new Text(driver, By.CssSelector("span[id$=\"txtAwardPercent\"]"));
            EditAwardPercent = new Button(driver, By.CssSelector("input[id$=\"btnAwardPercentEdit\"]"));
            County = new Text(driver, By.CssSelector("span[id$=\"txtCounty\"]"));
            AwardAmount = new Text(driver, By.CssSelector("span[id$=\"txtAwardAmount\"]"));
            HomePhone = new Text(driver, By.CssSelector("span[id$=\"txtHomePhone\"]"));
            AwardDate = new Text(driver, By.CssSelector("span[id$=\"txtAwardDate\"]"));
            EditAwardDate = new Button(driver, By.CssSelector("input[id$=\"btnAwardDateEdit\"]"));
            NewAwardDate = new EditField(driver, By.CssSelector("input[id$=\"tbxAwardDate\"]"));
            SaveNewAwardDate = new Button(driver, By.CssSelector("input[id$=\"btnSaveAwardDate\"]"));
            WorkPhone = new Text(driver, By.CssSelector("span[id$=\"txtWorkPhone\"]"));
            StudentAwardID = new Text(driver, By.CssSelector("span[id$=\"txtStudentID\"]"));
            CellPhone = new Text(driver, By.CssSelector("span[id$=\"txtCellPhone\"]"));
            EnrollmentsTable = new Table(driver, By.CssSelector("table[id$=\"GVEnrollments\"]"));
            CreateECFButton = new Button(driver, By.CssSelector("btnCreateECF"));
            NotesTable = new Table(driver, By.Id("tblNotes"));
            NoteType = new Dropdown(driver, By.CssSelector("[id$=\"ddlNoteType\"]"));
            SensistiveNote = new Checkbox(driver, By.CssSelector("[id$=\"cbIsSensitive\"]"));
            NoteText = new EditField(driver, By.CssSelector("[id$=\"tbNoteText\"]"));
            AddNoteButton = new Button(driver, By.Id("btnAddNote"));
        }
    }
}
