using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class SubmitPreAuthorizationRequestPage : AccountActivityPage
    {
        public Dropdown StudentList { get; private set; }

        public Text StudentName { get; set; }

        public Text StudentId { get; set; }

        public Dropdown SelectProvider { get; private set; }

        public EditField ProviderTypeAheadTextField { get; private set; }

        public Dropdown ProviderTypeAheadList { get; private set; }

        public EditField ProviderName { get; private set; }

        public EditField ProviderLicense { get; private set; }

        public EditField PreAuthorizationTitle { get; private set; }

        public EditField BenefitToTheStudent { get; private set; }

        public Dropdown LineItemCategory { get; private set; }

        public Dropdown LineItemType { get; private set; }

        public Dropdown LineItemDetail { get; private set; }

        public EditField LineItemDescription { get; private set; }

        public Button SaveThisItemButton { get; private set; }

        public Table LineItemsTable { get; private set; }

        public Button CancelButton { get; private set; }

        public Button SubmitButton { get; private set; }

        public Text IneligibleAccountMessage { get; private set; }

        public Text SuccessMessage { get; private set; }

        public SubmitPreAuthorizationRequestPage(IWebDriver driver)
            : base(driver)
        {
            StudentList = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"lblStudentValue\"]"));
            StudentId = new Text(Driver, By.CssSelector("span[id$=\"lblStudentIDValue\"]"));
            SelectProvider = new Dropdown(Driver, By.CssSelector("span[id$=\"ddlProvider-container\"]"));
            ProviderTypeAheadTextField = new EditField(Driver, By.CssSelector(".select2-search__field"));
            ProviderTypeAheadList = new Dropdown(Driver, By.CssSelector("ul[id$=\"ddlProvider-results\"]"));
            ProviderName = new EditField(Driver, By.CssSelector("input[id$=\"tbProviderName\"]"));
            ProviderLicense = new EditField(Driver, By.CssSelector("input[id$=\"tbProviderLicense\"]"));
            PreAuthorizationTitle = new EditField(Driver, By.CssSelector("input[id$=\"tbClaimDescription\"]"));
            BenefitToTheStudent = new EditField(Driver, By.CssSelector("textarea[id$=\"tbEducationalBenefit\"]"));
            LineItemCategory = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlItemCategory\"]"));
            LineItemType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlItemType\"]"));
            LineItemDetail = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlItemDetail\"]"));
            LineItemDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"tbItemDescription\"]"));
            SaveThisItemButton = new Button(Driver, By.CssSelector("input[id$=\"btnAdd\"]"));
            LineItemsTable = new Table(Driver, By.Id("tblClaimItems"));
            CancelButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancel\"]"));
            SubmitButton = new Button(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            IneligibleAccountMessage = new Text(Driver, By.CssSelector("div[id$=\"divIneligibleAccount\"]"));
            SuccessMessage = new Text(Driver, By.CssSelector("div[id$=\"divPostClaim\"]"));
        }
    }
}
