using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class ClassPage : CommonPage
    {
        public Button AddAnnouncementButton { get; private set; }

        public Modal AnnouncementModal { get; private set; }

        public EditField AnnouncementText { get; private set; }

        public Button FileUpload { get; private set; }

        public Text ListOfFilesToUpload { get; private set; }

        public Button CloseModal { get; private set; }

        public Button SaveAnnouncementButton { get; private set; }

        public Link ClassGradesLink { get; private set; }

        public Link EditClassLink { get; private set; }

        public Link DeleteClassLink { get; private set; }

        public Text Standards { get; private set; }

        public Text SchoolYear { get; private set; }

        public Text Teacher { get; private set; }

        public Text EnrollmentCount { get; private set; }

        public Link TakeAttendanceLink { get; private set; }

        public Link IdentifyInstructionalStrategiesForYearLink { get; private set; }

        public Link CreateSummerLearningPlanLink { get; private set; }

        public Link AttendanceReportLink { get; private set; }

        public Link ViewEditGradeLevelStandardsLink { get; private set; }

        public Link CreateEditUnitPlansLink { get; private set; }

        public Link AddStudentsLink { get; private set; }

        public Table EnrolledStudentsTable { get; private set; }

        public Modal InstructionalStrategiesModal { get; private set; }

        public Button SaveInstructionalStrategies { get; private set; }

        public Modal SummerLearningPlanModal { get; private set; }

        public EditField SummerLearningPlanDescription { get; private set; }

        public Button SaveSummearLearningPlan { get; private set; }

        public Modal AddStudentsModal { get; private set; }

        public EditField StudentFilterLastName { get; private set; }

        public Dropdown StudentFilterGradeLevel { get; private set; }

        public Dropdown StudentFilterExistingClasses { get; private set; }

        public Button StudentFilterSearchButton { get; private set; }

        public Table StudentFilterResults { get; private set; }

        public Button StudentFilterSaveButton { get; private set; }

        public Button StudentFilterCloseButton { get; private set; }

        public Text StrategyFlyout { get; private set; }

        #region Keyword Driven Testing Additions

        [KeywordTestingRequiresStoredElement]
        public Checkbox StudentSearchResultsSelectStudent { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown StudentSearchResultsStandardLevel { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link PLPLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link StandardsLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link StudentInfoLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link EditLink { get; private set; }

        #endregion Keyword Driven Testing Additions
        public ClassPage(IWebDriver driver)
            : base(driver)
        {
            AddAnnouncementButton = new Button(Driver, By.CssSelector("a[ng-click=\"vm.addAnnouncement()\"]"));
            AnnouncementModal = new Modal(Driver, By.ClassName("modal-dialog"));
            AnnouncementText = new EditField(Driver, By.CssSelector("textarea[ng-model=\"modalCtrl.announcement\"]"));
            FileUpload = new Button(Driver, By.CssSelector("input[type=\"file\"]"));
            ListOfFilesToUpload = new Text(Driver, By.CssSelector("span[ng-repeat=\"file in modalCtrl.files\"]"));
            CloseModal = new Button(Driver, By.CssSelector("button[ng-click=\"modalCtrl.close()\"]"));
            SaveAnnouncementButton = new Button(Driver, By.CssSelector("button[ng-click=\"modalCtrl.save()\"]"));
            ClassGradesLink = new Link(Driver, By.Id("btnClassGrades"));
            EditClassLink = new Link(Driver, By.Id("btnEditClass"));
            DeleteClassLink = new Link(Driver, By.Id(" btndeleteclass"));
            Standards = new Text(Driver, By.CssSelector(".standards"));
            SchoolYear = new Text(Driver, By.CssSelector(".schooYear"));
            Teacher = new Text(Driver, By.CssSelector(".teacher"));
            EnrollmentCount = new Text(Driver, By.CssSelector(".enrollmentCount"));
            TakeAttendanceLink = new Link(Driver, By.Id("btnAttendance"));
            IdentifyInstructionalStrategiesForYearLink = new Link(Driver, By.Id("btnEditClassInstructionMethods"));
            CreateSummerLearningPlanLink = new Link(Driver, By.Id("btnSummerLearningPlans"));
            AttendanceReportLink = new Link(Driver, By.Id("btnAttendanceReport"));
            ViewEditGradeLevelStandardsLink = new Link(Driver, By.Id("btnEditClassCcss"));
            CreateEditUnitPlansLink = new Link(Driver, By.Id("btnUnitPlans"));
            AddStudentsLink = new Link(Driver, By.Id("btnCreateEnrollment"));
            EnrolledStudentsTable = new Table(Driver, By.CssSelector(".enrolledStudents"));
            InstructionalStrategiesModal = new Modal(Driver, By.Id("instructionalMethodsModal"));
            SummerLearningPlanModal = new Modal(Driver, By.Id("summerLearningModal"));
            SummerLearningPlanDescription = new EditField(Driver, By.Id("taSummerLearning"));
            SaveSummearLearningPlan = new Button(Driver, By.Id("btnSaveSummerLearning"));
            SaveInstructionalStrategies = new Button(Driver, By.Id("btnSaveMethods"));
            AddStudentsModal = new Modal(Driver, By.Id("createEnrollmentModal"));
            StudentFilterLastName = new EditField(Driver, By.Id("StudentSearchForm_LastName"));
            StudentFilterGradeLevel = new Dropdown(Driver, By.Id("StudentSearchForm_GradeLevelId"));
            StudentFilterExistingClasses = new Dropdown(Driver, By.Id("StudentSearchForm_TeacherClassRoomId"));
            StudentFilterSearchButton = new Button(Driver, By.Id("btnSearchStudents"));
            StudentFilterResults = new Table(Driver, By.Id("studentSearchResults"));
            StudentFilterSaveButton = new Button(Driver, By.Id("btnSave"));
            StudentFilterCloseButton = new Button(Driver, By.CssSelector(".cancelEnrollment"));
            #region Keyword Driven Testing Additions
            StudentSearchResultsSelectStudent = new Checkbox(Driver, By.CssSelector(".enrollment"));
            StudentSearchResultsStandardLevel = new Dropdown(Driver, By.CssSelector("select[id^=\"EnrollmentGradeLevel\"]"));
            PLPLink = new Link(Driver, By.CssSelector(".studentPlp"));
            StandardsLink = new Link(Driver, By.CssSelector(".studentStandards"));
            StudentInfoLink = new Link(Driver, By.CssSelector(".studentInfo"));
            EditLink = new Link(Driver, By.CssSelector(".btnEnrollment"));
            #endregion Keyword Driven Testing Additions
        }
    }
}
