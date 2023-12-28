using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class HouseholdIncomePage : ApplicationWizardPage
    {
        public OLAHouseholdIncomeTable HouseholdIncomeTable { get; private set; }
        public Button HouseholdIncomePopupNO { get; private set; }
        public Button HouseholdIncomePopupYES { get; private set; }

        public HouseholdIncomePage(IWebDriver driver)
            : base(driver)
        {
            HouseholdIncomeTable = new OLAHouseholdIncomeTable(Driver, By.XPath("//*[@class='striped responsive-table']"));
            HouseholdIncomePopupNO = new Button(Driver, By.CssSelector("#confirmSummaryIncomeModal > div.modal-footer > a:nth-child(2)"));
            HouseholdIncomePopupYES = new Button(Driver, By.CssSelector("#confirmSummaryIncomeModal > div.modal-footer > a:nth-child(1)"));
        }
    }
}
