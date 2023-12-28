using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SLI.Automation.Pages
{
    public class TuitionFeesPage : SchoolInfoPage
    {
        public Dropdown KeepLastYearsData { get; private set; }

        public Table FeeScheduleTable { get; private set; }

        public EditField SchoolStartDate { get; private set; }

        public EditField SchoolEndDate { get; private set; }

        public EditField FeeScheduleSchoolComplianceDate { get; private set; }

        public Dropdown StandardizedTestGiven { get; private set; }

        public EditField StandardizedTestStartDate { get; private set; }

        public EditField StandardizedTestEndDate { get; private set; }

        public Dropdown MultiSiblingDiscountsAvailable { get; private set; }

        public Dropdown AffiliationDiscountsAvailable { get; private set; }

        public Button SubmitTuitionAndFeesDataForVerificationButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public TuitionFeesPage(IWebDriver driver)
            : base(driver)
        {
            KeepLastYearsData = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSameTuition\"]"));
            FeeScheduleTable = new Table(Driver, By.CssSelector("table[id$=\"_gvFeeSchedule\"]"));
            SchoolStartDate = new EditField(Driver, By.CssSelector("input[id$=\"_tbStartDate\"]"));
            SchoolEndDate = new EditField(Driver, By.CssSelector("input[id$=\"_tbEndDate\"]"));
            FeeScheduleSchoolComplianceDate = new EditField(Driver, By.CssSelector("input[id$=\"_tbComplianceDate\"]"));
            StandardizedTestGiven = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlTestGiven\"]"));
            StandardizedTestStartDate = new EditField(Driver, By.CssSelector("input[id$=\"_tbTestStartDate\"]"));
            StandardizedTestEndDate = new EditField(Driver, By.CssSelector("input[id$=\"_tbTestEndDate\"]"));
            MultiSiblingDiscountsAvailable = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlMultiSiblingDiscounts\"]"));
            AffiliationDiscountsAvailable = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlAffiliationDiscounts\"]"));
            SubmitTuitionAndFeesDataForVerificationButton = new Button(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            StatusMessage = new Text(Driver, By.CssSelector("span[id$=\"ErrorMessage\"]"));
        }
    }
}
