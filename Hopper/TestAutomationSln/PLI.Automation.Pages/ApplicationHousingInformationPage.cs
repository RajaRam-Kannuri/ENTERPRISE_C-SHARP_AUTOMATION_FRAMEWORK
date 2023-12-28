using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationHousingInformationPage : ApplicationWizardPage
    {
        public Dropdown HousingPaymentType { get; private set; }

        public ApplicationHousingInformationPage(IWebDriver driver)
            : base(driver)
        {
            HousingPaymentType = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlHousePaymentType\"]"));
        }
    }
}
