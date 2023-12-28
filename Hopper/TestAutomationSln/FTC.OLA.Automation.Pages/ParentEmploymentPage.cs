using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentEmploymentPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown EmploymentStatusDropdown { get; private set; }
        public EditField EmployerName { get; private set; }
        public Text ThisFieldIsRequiredMessage { get; private set; }
        public Text CompanyNameShouldNotBeEmptyMessage { get; private set; }
        public Text CompanyNameIsNotLongEnoughMessage { get; private set; }
        public Text CompanyNameIsNotInTheCorrectFormatMessage { get; private set; }

        public ParentEmploymentPage(IWebDriver driver)
            : base(driver)
        {
            EmployerName = new EditField(Driver, By.Id("companyName"));
			EmploymentStatusDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            ThisFieldIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div.errors"));
            CompanyNameShouldNotBeEmptyMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li:nth-child(1) > p"));
            CompanyNameIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li:nth-child(2) > p"));
            CompanyNameIsNotInTheCorrectFormatMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li:nth-child(3) > p"));
        }
    }
}
