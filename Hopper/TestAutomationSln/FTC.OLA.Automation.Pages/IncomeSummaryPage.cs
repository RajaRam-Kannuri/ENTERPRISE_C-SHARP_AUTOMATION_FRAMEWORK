using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class IncomeSummaryPage : ApplicationWizardPage
    {
        public Button AddEmploymentIncome { get; private set; }
        public Button AddUnemploymentAndCompensationIncome { get; private set; }
        public Button AddFamilyIncome { get; private set; }
        public Button AddAssistanceIncome { get; private set; }
        public Button AddSocialSecurityIncome { get; private set; }
        public Button AddOtherIncome { get; private set; }
        public Text TotalAnnualIncomeAmount { get; private set; }
        public Text EmploymentIncomeAmount { get; private set; }
        public Text UnemploymentAndCompensationIncomeAmount { get; private set; }
        public Text FamilyIncomeAmount { get; private set; }
        public Text AssistanceIncomeAmount { get; private set; }
        public Text SocialSecurityIncomeAmount { get; private set; }
        public Text OtherIncomeAmount { get; private set; }

        public IncomeSummaryPage(IWebDriver driver)
            : base(driver)
        {
            AddEmploymentIncome = new Button(Driver, By.XPath("//*[contains(@href, 'employment-income-summary')]"));
            AddUnemploymentAndCompensationIncome = new Button(Driver, By.XPath("//*[contains(@href, 'unemployment-income-unemployment-compensation')]"));
            AddFamilyIncome = new Button(Driver, By.XPath("//*[contains(@href, 'child-support')]"));
            //AddAssistanceIncome = new Button(Driver, By.XPath("//*[contains(@href, 'assistance-public-assistance')]"));
            AddAssistanceIncome = new Button(Driver, By.XPath("//*[contains(@href, 'assistance-cash')]"));
            AddSocialSecurityIncome = new Button(Driver, By.XPath("//*[contains(@href, 'social-security-income-you')]"));
            AddOtherIncome = new Button(Driver, By.XPath("//*[contains(@href, 'other-income-cash-withdrawal')]"));
            TotalAnnualIncomeAmount = new Text(Driver, By.Id("totalAnnualIncome"));
            EmploymentIncomeAmount = new Text(Driver, By.Id("employment-income-total-income"));
            UnemploymentAndCompensationIncomeAmount = new Text(Driver, By.Id("unemployment-income-total-income"));
            FamilyIncomeAmount = new Text(Driver, By.Id("family-income-total-income"));
            AssistanceIncomeAmount = new Text(Driver, By.Id("assistance-income-total-income"));
            SocialSecurityIncomeAmount = new Text(Driver, By.Id("social-security-income-total-income"));
            OtherIncomeAmount = new Text(Driver, By.Id("other-income-total-income"));
        }
    }
}
