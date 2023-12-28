using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class BatchProcessingWorksheetPage : HomePage
    {
        public Dropdown YearDropdown { get; private set; }
        public Dropdown ApplicationWorkflowStatusDropdown { get; private set; }
        public Dropdown NewStudentDropdown { get; private set; }
        public Dropdown FosterOutOfHomeCareDropdown { get; private set; }
        public Dropdown KindergartenFirstGradeDropdown { get; private set; }
        public Dropdown SixthNinthGradeDropdown { get; private set; }
        public Dropdown NewAdultDropdown { get; private set; }
        public Dropdown ApplicationTypeDropdown { get; private set; }
        public Dropdown HouseholdSizeDropdown { get; private set; }
        public Dropdown IncomeChangePercentageDropdown { get; private set; }
        public Dropdown PercentOfGuidelinesDropdown { get; private set; }
        public Dropdown DirectCertificationDropdown { get; private set; }
        public Button SearchButton { get; private set; }
        public Button ResetSearchButton { get; private set; }
        public Button SetAllToReviewCompleteButton { get; private set; }
        public Button SetAllToPendingProcessingButton { get; private set; }
        public Button UpdateButton { get; private set; }
        public Button YesButton { get; private set; }
        public Button NoButton { get; private set; }

        public BatchProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            YearDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(1) > td > bindable-dropdown > div"));
            ApplicationWorkflowStatusDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(2) > td > bindable-dropdown > div"));
            NewStudentDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(3) > td > bindable-dropdown > div"));
            FosterOutOfHomeCareDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(4) > td > bindable-dropdown > div"));
            KindergartenFirstGradeDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(5) > td > bindable-dropdown > div"));
            SixthNinthGradeDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(6) > td > bindable-dropdown > div"));
            NewAdultDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(7) > td > bindable-dropdown > div"));
            ApplicationTypeDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(1) > td > bindable-dropdown > div"));
            HouseholdSizeDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(2) > td > bindable-dropdown > div"));
            IncomeChangePercentageDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(3) > td > bindable-dropdown > div"));
            PercentOfGuidelinesDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(4) > td > bindable-dropdown > div"));
            DirectCertificationDropdown = new Dropdown(driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(5) > td > bindable-dropdown > div"));
            SearchButton = new Button(driver, By.XPath("//button[text() = 'Search']"));
            ResetSearchButton = new Button(driver, By.XPath("//button[text() = 'Reset Search']"));
            SetAllToReviewCompleteButton = new Button(driver, By.CssSelector("#searchResults > tfoot > tr > td > div > label:nth-child(1)"));
            SetAllToPendingProcessingButton = new Button(driver, By.CssSelector("#searchResults > tfoot > tr > td > div > label:nth-child(2)"));
            UpdateButton = new Button(driver, By.XPath("//button[text() = 'Update']"));
            YesButton = new Button(driver, By.XPath("//button[text() = 'Yes']"));
            NoButton = new Button(driver, By.XPath("//button[text() = 'No']"));
        }
    }
}
