using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class IncomeCategoryPickerPage : ApplicationWizardPage
    {
        public Button EmploymentIncome { get; private set; }
        public Button UnemploymentAndCompensationIncome { get; private set; }
        public Button FamilyIncome { get; private set; }
        public Button AssistanceIncome { get; private set; }
        public Button SocialSecurityIncome { get; private set; }
        public Button OtherIncome { get; private set; }
        public Button Finish { get; private set; }

        public IncomeCategoryPickerPage(IWebDriver driver)
            : base(driver)
        {
            EmploymentIncome = new Button(Driver, By.XPath("//*[contains(@href, 'employment-income-checks')]"));
            UnemploymentAndCompensationIncome = new Button(Driver, By.XPath("//*[contains(@href, 'unemployment-income-unemployment-compensation')]"));
            FamilyIncome = new Button(Driver, By.XPath("//*[contains(@href, 'family-income-child-support')]"));
            AssistanceIncome = new Button(Driver, By.XPath("//*[contains(@href, 'assistance-public-assistance')]"));
            SocialSecurityIncome = new Button(Driver, By.XPath("//*[contains(@href, 'social-security-income-you')]"));
            OtherIncome = new Button(Driver, By.XPath("//*[contains(@href, 'other-income-cash-withdrawal')]"));
            Finish = new Button(Driver, By.XPath("//span[text() = 'Finish']"));
        }
    }
}
