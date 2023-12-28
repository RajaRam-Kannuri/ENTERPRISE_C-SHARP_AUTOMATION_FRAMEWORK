using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ApplicationFormPrintingPage : HomePage
    {
        public Text ApplicationId { get; private set; }

        public Text ApplicationSubmissionType { get; private set; }

        public Text ApplicationSubmissionDate { get; private set; }

        public Checkbox ApplicationTypeNew { get; private set; }

        public Checkbox ApplicationTypeRenewal { get; private set; }

        public Button SaveApplicationTypeButton { get; private set; }

        public Text HouseholdLanguage { get; private set; }

        public Text PhysicalAddress1 { get; private set; }

        public Text PhysicalAddress2 { get; private set; }

        public Text CityStateZip { get; private set; }

        public Text County { get; private set; }

        public Text HomePhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text CellPhone { get; private set; }

        public Table StudentInfoTable { get; private set; }

        public Table StudentTableAFP { get; private set; }

        public ApplicationFormPrintingPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationId = new Text(driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            ApplicationSubmissionType = new Text(driver, By.CssSelector("span[id$=\"lblApplicationSubmissionTypeValue\"]"));
            ApplicationSubmissionDate = new Text(driver, By.CssSelector("span[id$=\"lblApplicationSubmissionDateValue\"]"));
            ApplicationTypeNew = new Checkbox(driver, By.CssSelector("input[id$=\"cblApplicationType_0\"]"));
            ApplicationTypeRenewal = new Checkbox(driver, By.CssSelector("input[id$=\"cblApplicationType_1\"]"));
            SaveApplicationTypeButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveApplicationType\"]"));
            HouseholdLanguage = new Text(driver, By.CssSelector("span[id$=\"lblHouseholdLanguageValue\"]"));
            PhysicalAddress1 = new Text(driver, By.CssSelector("span[id$=\"lblFirstLine\"]"));
            PhysicalAddress2 = new Text(driver, By.CssSelector("span[id$=\"lblSecondLine\"]"));
            CityStateZip = new Text(driver, By.CssSelector("span[id$=\"lblThirdLine\"]"));
            County = new Text(driver, By.CssSelector("span[id$=\"lblFourthLine\"]"));
            HomePhone = new Text(driver, By.CssSelector("span[id$=\"lblHomePhoneNumber\"]"));
            WorkPhone = new Text(driver, By.CssSelector("span[id$=\"lblWorkPhoneNumber\"]"));
            CellPhone = new Text(driver, By.CssSelector("span[id$=\"lblMobilePhoneNumber\"]"));
            StudentInfoTable = new Table(driver, By.XPath("//*[@id='controls_applicationprocessing_applicationforms_ascx163_GVLetters']/tbody"));
            StudentTableAFP = new Table(driver, By.XPath("//*[@id='controls_applicationprocessing_applicationforms_ascx163_GVLetters']/tbody"));
        }
    }
}
