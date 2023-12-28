using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
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
            UnassignedPackageCount = new Text(Driver, By.CssSelector("span[id$=\"lblNumOfPackagesValue\"]"));
            Processors = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlProcessor\"]"));
            NumberOfPackagesToAssign = new EditField(Driver, By.CssSelector("input[id$=\"txtNumber\"]"));
            AssignButton = new Button(Driver, By.CssSelector("input[id$=\"btnAssign\"]"));
            AssignmentHistoryTable = new Table(Driver, By.CssSelector("table[id$=\"gvCurrentHistory\"]"));
            NoPackagesMessage = new Text(Driver, By.CssSelector("span[id$=\"lblNoPackages\"]"));
        }
    }
}
