using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class IncomeConfirmationPage : ApplicationWizardPage
    {
        public Text EmploymentIncomeAmount { get; private set; }
        public Text UnemploymentAndCompensationIncomeAmount { get; private set; }
        public Text FamilyIncomeAmount { get; private set; }
        public Text AssistanceIncomeAmount { get; private set; }
        public Text SocialSecurityIncomeAmount { get; private set; }
        public Text OtherIncomeAmount { get; private set; }
        public Text TotalIncomeAmount { get; private set; }

        public IncomeConfirmationPage(IWebDriver driver)
            : base(driver)
        {
            EmploymentIncomeAmount = new Text(Driver, By.XPath("//span[text() = 'Confirm & Sign']"));
        }
    }
}
