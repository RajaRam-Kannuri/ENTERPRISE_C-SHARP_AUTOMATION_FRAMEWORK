using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class IncomeConfirmationSummaryPage : ApplicationWizardPage
    {
        public Button ConfirmAndSignButton { get; private set; }
        public Button SummaryButton { get; private set; }
        public OLAOtherMembersTable HouseholdIncomeTable { get; private set; }
        public Text TotalAnnualIncomeAmount { get; private set; }

        public IncomeConfirmationSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ConfirmAndSignButton = new Button(Driver, By.XPath("//span[text() = 'Confirm & Sign']"));
            SummaryButton = new Button(Driver, By.XPath("//span[text() = 'Summary']"));
            HouseholdIncomeTable = new OLAOtherMembersTable(Driver, By.XPath("//*[contains(@class, 'striped responsive-table')]"));
            TotalAnnualIncomeAmount = new Text(Driver, By.XPath("//span[text() = 'Confirm & Sign']"));
        }
    }
}
