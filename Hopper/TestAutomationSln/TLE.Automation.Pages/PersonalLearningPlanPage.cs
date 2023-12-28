using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class PersonalLearningPlanPage : CommonPage
    {
        public Link PublishLink { get; private set; }

        public Text Name { get; private set; }

        public Text School { get; private set; }

        public Text SchoolYear { get; private set; }

        public Text StandardsRange { get; private set; }

        public Text StudentId { get; private set; }

        public Text Grade { get; private set; }

        public Text GradingPeriod { get; private set; }

        public Button ConferenceDateSelectorButton { get; private set; }

        public Button ConferenceDeclinedDateSelectorButton { get; private set; }

        public Button ConferenceSecondDeclinedDateSelectorButton { get; private set; }

        public Text ConferenceDate { get; private set; }

        public Text ConferenceDeclinedDate { get; private set; }

        public Text ConferenceSecondDeclinedDate { get; private set; }

        public WebElement ConferenceDatePicker  { get; private set; }

        public Checkbox NoShowCheckbox { get; private set; }

        public Tab StrengthsTab { get; private set; }

        public EditField StrengthsField { get; private set; }

        public Button SaveStrengthsButton { get; private set; }

        public Tab ConcernsTab { get; private set; }

        public EditField ConcernsField { get; private set; }

        public Button SaveConcernsButton { get; private set; }

        public EditField AdditionalCommentsField { get; private set; }

        public Button SaveAdditionalComments { get; private set; }

        public Text CoreStandardsList { get; private set; }

        public PersonalLearningPlanPage(IWebDriver driver)
            : base(driver)
        {
            PublishLink = new Link(Driver, By.CssSelector("a[href*=\"/LearningCompact/Publish\"]"));
            Name = new Text(Driver, By.CssSelector(""));
            School = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Text(Driver, By.CssSelector(""));
            StandardsRange = new Text(Driver, By.CssSelector(""));
            StudentId = new Text(Driver, By.CssSelector(""));
            Grade = new Text(Driver, By.CssSelector(""));
            GradingPeriod = new Text(Driver, By.CssSelector(""));
            ConferenceDate = new Text(Driver, By.Id("ConferenceDateContainer"));
            ConferenceDeclinedDate = new Text(Driver, By.Id("DeclinedDateContainer"));
            ConferenceSecondDeclinedDate = new Text(Driver, By.Id("SecondDeclinedDateContainer"));
            ConferenceDatePicker = new WebElement(Driver, By.Id("ui-datepicker-div"));
            NoShowCheckbox = new Checkbox(Driver, By.Id("StudentLearningCompact_IsNoShow_Icon"));
            StrengthsTab = new Tab(Driver, By.CssSelector("a[href=\"#studentTab\"]"));
            StrengthsField = new EditField(Driver, By.Id("txtStudentStrengths"));
            SaveStrengthsButton = new Button(Driver, By.Id("btnSaveStudentStrengths"));
            ConcernsTab = new Tab(Driver, By.CssSelector("a[href=\"#parentTab\"]"));
            ConcernsField = new EditField(Driver, By.Id("txtParentConcerns"));
            SaveConcernsButton = new Button(Driver, By.Id("btnSaveParentConcerns"));
            AdditionalCommentsField = new EditField(Driver, By.Id("txtAcademicAchievementComment"));
            SaveAdditionalComments = new Button(Driver, By.Id("btnSaveComment"));
            CoreStandardsList = new Text(Driver, By.CssSelector(".coreStandardsContent"));
        }
    }
}
