using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationSummaryPage : ApplicationWizardPage
    {
        public Table ParentsTable { get; private set; }

        public Table ChildrenTable { get; private set; }

        public Checkbox ConfirmHouseholdCount { get; private set; }

        public Checkbox ConfirmHouseholdIncome { get; private set; }

        public ApplicationSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ParentsTable = new Table(Driver, By.Id("gvParentGaurdian"));
            ChildrenTable = new Table(Driver, By.Id("gvChild"));
            ConfirmHouseholdCount = new Checkbox(Driver, By.CssSelector("input[id$=\"_cbConfirmNumberOfHousehold\"]"));
            ConfirmHouseholdIncome = new Checkbox(Driver, By.CssSelector("input[id$=\"_cbConfirmHouseholdIncome\"]"));
        }
    }
}
