using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class UnattachedDocumentsPage : HomePage
    {
        public Text UnassignedPackageCount { get; private set; }

        public Dropdown Processors { get; private set; }

        public EditField NumberOfPackagesToAssign { get; private set; }

        public Button AssignButton { get; private set; }

        public Table AssignmentHistoryTable { get; private set; }

        public Text NoPackagesMessage { get; private set; }

        public UnattachedDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            UnassignedPackageCount = new Text(driver, By.CssSelector("span[id$=\"lblNumOfPackagesValue\"]"));
            Processors = new Dropdown(driver, By.CssSelector("select[id$=\"ddlProcessor\"]"));
            NumberOfPackagesToAssign = new EditField(driver, By.CssSelector("input[id$=\"txtNumber\"]"));
            AssignButton = new Button(driver, By.CssSelector("input[id$=\"btnAssign\"]"));
            AssignmentHistoryTable = new Table(driver, By.CssSelector("table[id$=\"gvCurrentHistory\"]"));
            NoPackagesMessage = new Text(driver, By.CssSelector("span[id$=\"lblNoPackages\"]"));
        }
    }
}