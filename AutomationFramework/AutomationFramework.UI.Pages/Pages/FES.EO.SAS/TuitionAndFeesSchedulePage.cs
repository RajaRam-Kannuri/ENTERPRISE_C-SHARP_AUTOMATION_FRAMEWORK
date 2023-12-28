using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class TuitionAndFeesSchedulePage : HomePage
    {
        public Table TnFSchoolYear { get; private set; }

        public Table FeeScheduleTable { get; private set; }

        public EditField SchoolStartDate { get; private set; }

        public EditField SchoolEndDate { get; private set; }

        public EditField FeeScheduleSchoolComplianceDate { get; private set; }

        public Dropdown StandardizedTestGiven { get; private set; }

        public EditField StandardizedTestStartDate { get; private set; }

        public EditField StandardizedTestEndDate { get; private set; }

        public Dropdown MultiSiblingDiscountsAvailable { get; private set; }

        public Dropdown AffiliationDiscountsAvailable { get; private set; }

        public Button SaveTuitionAndFeeScheduleButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public EditField SentDate { get; private set; }

        public Dropdown Type { get; private set; }

        public Table SupportingDocumentTypes { get; private set; }

        public Button SaveTuitionAndFeeWorkflowDocumentsButton { get; private set; }

        public Table SupportingDocumentsTable { get; private set; }

        public Button ViewAllDocumentsButton { get; private set; }

        public TuitionAndFeesSchedulePage(IWebDriver driver)
            : base(driver)
        {
            TnFSchoolYear = new Table(driver, By.CssSelector("select[id*=\"schoolfeeschedule\"][id$=\"ddlSchoolYear\"]"));
            FeeScheduleTable = new Table(driver, By.CssSelector("table[id$=\"gvFeeSchedule\"]"));
            SchoolStartDate = new EditField(driver, By.CssSelector("input[id$=\"tbStartDate\"]"));
            SchoolEndDate = new EditField(driver, By.CssSelector("input[id$=\"tbEndDate\"]"));
            FeeScheduleSchoolComplianceDate = new EditField(driver, By.CssSelector("input[id$=\"txtComplianceDate\"]"));
            StandardizedTestGiven = new Dropdown(driver, By.CssSelector("select[id$=\"ddlTestGiven\"]"));
            StandardizedTestStartDate = new EditField(driver, By.CssSelector("input[id$=\"tbTestStartDate\"]"));
            StandardizedTestEndDate = new EditField(driver, By.CssSelector("input[id$=\"tbTestEndDate\"]"));
            MultiSiblingDiscountsAvailable = new Dropdown(driver, By.CssSelector("select[id$=\"ddlMultiSiblingDiscounts\"]"));
            AffiliationDiscountsAvailable = new Dropdown(driver, By.CssSelector("select[id$=\"ddlAffiliationDiscounts\"]"));
            SaveTuitionAndFeeScheduleButton = new Button(driver, By.CssSelector("input[id$=\"_btnSave\"]"));
            StatusMessage = new Text(driver, By.CssSelector(""));
            SentDate = new EditField(driver, By.CssSelector("input[id$=\"tbSentDate\"]"));
            Type = new Dropdown(driver, By.CssSelector("select[id$=\"ddlDocumentSource\"]"));
            SupportingDocumentTypes = new Table(driver, By.CssSelector("table[id$=\"cblSchoolSupportingDocumentType\"]"));
            SaveTuitionAndFeeWorkflowDocumentsButton = new Button(driver, By.Id("ibtnSave"));
            SupportingDocumentsTable = new Table(driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            ViewAllDocumentsButton = new Button(driver, By.CssSelector("input[id$=\"btnViewAll\"]"));
        }
    }
}
