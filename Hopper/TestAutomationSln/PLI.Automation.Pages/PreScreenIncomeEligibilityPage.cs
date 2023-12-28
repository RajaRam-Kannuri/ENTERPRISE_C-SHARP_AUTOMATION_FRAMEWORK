using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class PreScreenIncomeEligibilityPage : WizardPage
    {
        public Table IncomeGuidelines { get; private set; }

        public Radio YesButton { get; private set; }

        public Radio NoButton { get; private set; }

        public PreScreenIncomeEligibilityPage(IWebDriver driver)
            : base(driver)
        {
            IncomeGuidelines = new Table(Driver, By.Id("gvIncomeEligibilityChartPartialScholarships"));
            YesButton = new Radio(Driver, By.CssSelector("input[id$=\"_YesButton\"]"));
            NoButton = new Radio(Driver, By.CssSelector("input[id$=\"_NoButton\"]"));
        }
    }
}
