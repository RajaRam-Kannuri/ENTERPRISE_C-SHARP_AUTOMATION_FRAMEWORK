using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
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
            TnFSchoolYear = new Table(Driver, By.CssSelector("select[id*=\"schoolfeeschedule\"][id$=\"ddlSchoolYear\"]"));
            FeeScheduleTable = new Table(Driver, By.CssSelector("table[id$=\"gvFeeSchedule\"]"));
            SchoolStartDate = new EditField(Driver, By.CssSelector("input[id$=\"tbStartDate\"]"));
            SchoolEndDate = new EditField(Driver, By.CssSelector("input[id$=\"tbEndDate\"]"));
            FeeScheduleSchoolComplianceDate = new EditField(Driver, By.CssSelector("input[id$=\"txtComplianceDate\"]"));
            StandardizedTestGiven = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlTestGiven\"]"));
            StandardizedTestStartDate = new EditField(Driver, By.CssSelector("input[id$=\"tbTestStartDate\"]"));
            StandardizedTestEndDate = new EditField(Driver, By.CssSelector("input[id$=\"tbTestEndDate\"]"));
            MultiSiblingDiscountsAvailable = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMultiSiblingDiscounts\"]"));
            AffiliationDiscountsAvailable = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAffiliationDiscounts\"]"));
            SaveTuitionAndFeeScheduleButton = new Button(Driver, By.CssSelector("input[id$=\"_btnSave\"]"));
            StatusMessage = new Text(Driver, By.CssSelector(""));
            SentDate = new EditField(Driver, By.CssSelector("input[id$=\"tbSentDate\"]"));
            Type = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlDocumentSource\"]"));
            SupportingDocumentTypes = new Table(Driver, By.CssSelector("table[id$=\"cblSchoolSupportingDocumentType\"]"));
            SaveTuitionAndFeeWorkflowDocumentsButton = new Button(Driver, By.Id("ibtnSave"));
            SupportingDocumentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            ViewAllDocumentsButton = new Button(Driver, By.CssSelector("input[id$=\"btnViewAll\"]"));
        }
    }
}
