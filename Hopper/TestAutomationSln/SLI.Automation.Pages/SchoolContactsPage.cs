using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class SchoolContactsPage : SchoolInfoPage
    {
        public Table SchoolContactTable { get; private set; }

        public Button AddNewContact { get; private set; }

        public Dropdown ContactTitle { get; private set; }

        public EditField ContactFirstName { get; private set; }

        public EditField ContactMiddleName { get; private set; }

        public EditField ContactLastName { get; private set; }

        public Checkbox ContactIsPrimary { get; private set; }

        public EditField ContactEmail { get; private set; }

        public EditField ContactPhysicalAddress1 { get; private set; }

        public EditField ContactPhysicalAddress2 { get; private set; }

        public Dropdown ContactPhysicalCity { get; private set; }

        public Dropdown ContactPhysicalState { get; private set; }

        public EditField ContactPhysicalZip { get; private set; }

        public EditField ContactMailingAddress1 { get; private set; }

        public EditField ContactMailingAddress2 { get; private set; }

        public Dropdown ContactMailingCity { get; private set; }

        public Dropdown ContactMailingState { get; private set; }

        public EditField ContactMailingZip { get; private set; }

        public Table ContactPhoneNumbers { get; private set; }

        public Button ContactAddPhoneNumber { get; private set; }

        public Button SaveChanges { get; private set; }

        public Modal NewPhoneNumberModal { get; private set; }

        public EditField NewPhoneNumber { get; private set; }

        public EditField NewPhoneExtension { get; private set; }

        public Checkbox NewPhoneIsPrimary { get; private set; }

        public Dropdown NewPhoneType { get; private set; }

        public Button SaveNewPhone { get; private set; }

        public Button CancelAddNewPhone { get; private set; }

        public SchoolContactsPage(IWebDriver driver)
            : base(driver)
        {
            SchoolContactTable = new Table(Driver, By.CssSelector("table[id$=\"_dlSchoolContacts\"]"));
            AddNewContact = new Button(Driver, By.CssSelector("input[id$=\"_btnAdd\"]"));
            ContactTitle = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlContactTitle\"]"));
            ContactFirstName = new EditField(Driver, By.CssSelector("input[id$=\"tbFirstName\"]"));
            ContactMiddleName = new EditField(Driver, By.CssSelector("input[id$=\"tbMiddleName\"]"));
            ContactLastName = new EditField(Driver, By.CssSelector("input[id$=\"tbLastName\"]"));
            ContactIsPrimary = new Checkbox(Driver, By.CssSelector("input[id$=\"cbPrimaryContact\"]"));
            ContactEmail = new EditField(Driver, By.CssSelector("input[id$=\"tbContactEmail\"]"));
            ContactPhysicalAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"_ctl00_tbAddress1Value\"]"));
            ContactPhysicalAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"_ctl00_tbAddress2Value\"]"));
            ContactPhysicalCity = new Dropdown(Driver, By.CssSelector("select[id$=\"_ctl00_ddlCity\"]"));
            ContactPhysicalState = new Dropdown(Driver, By.CssSelector("select[id$=\"_ctl00_ddlState\"]"));
            ContactPhysicalZip = new EditField(Driver, By.CssSelector("input[id$=\"_ctl00_tbZip\"]"));
            ContactMailingAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"_ctl01_tbAddress1Value\"]"));
            ContactMailingAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"_ctl01_tbAddress2Value\"]"));
            ContactMailingCity = new Dropdown(Driver, By.CssSelector("select[id$=\"_ctl01_ddlCity\"]"));
            ContactMailingState = new Dropdown(Driver, By.CssSelector("select[id$=\"_ctl01_ddlState\"]"));
            ContactMailingZip = new EditField(Driver, By.CssSelector("input[id$=\"_ctl01_tbZip\"]"));
            ContactPhoneNumbers = new Table(Driver, By.CssSelector("input[id$=\"_tblRepPhone\"]"));
            ContactAddPhoneNumber = new Button(Driver, By.CssSelector("input[id$=\"btnAddPhone\"]"));
            SaveChanges = new Button(Driver, By.CssSelector("input[id$=\"_btnUpdateSchoolContact\"]"));
            NewPhoneNumberModal = new Modal(Driver, By.CssSelector("div[id$=\"_panAddPhone\"]"));
            NewPhoneNumber = new EditField(Driver, By.CssSelector("input[id$=\"_tbAddNumber\"]"));
            NewPhoneExtension = new EditField(Driver, By.CssSelector("input[id$=\"_tbAddNumberExtension\"]"));
            NewPhoneIsPrimary = new Checkbox(Driver, By.CssSelector("input[id$=\"_cbAddPrimary\"]"));
            NewPhoneType = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPhoneType\"]"));
            SaveNewPhone = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmitPhone\"]"));
            CancelAddNewPhone = new Button(Driver, By.CssSelector("input[id$=\"_btnCancel\"]"));
        }
    }
}
