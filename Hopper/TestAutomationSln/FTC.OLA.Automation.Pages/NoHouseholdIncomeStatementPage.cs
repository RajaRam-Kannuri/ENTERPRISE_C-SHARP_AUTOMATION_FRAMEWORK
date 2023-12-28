using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NoHouseholdIncomeStatementPage : ApplicationWizardPage
    {
        public EditField NoHouseholdIncomeExplanationTextField { get; private set; }
        public EditField PrimaryParentSignatureTextField { get; private set; }
        public Text ExplanationFieldIsRequiredMessage { get; private set; }
        public Text NameFieldIsRequiredMessage { get; private set; }
        public Text TheNameEnteredDoesNotMatchMessage { get; private set; }

        public NoHouseholdIncomeStatementPage(IWebDriver driver)
            : base(driver)
        {
            NoHouseholdIncomeExplanationTextField = new EditField(Driver, By.CssSelector("#question-form > div > div > div > textarea"));
            PrimaryParentSignatureTextField = new EditField(Driver, By.Id("primaryName"));
            ExplanationFieldIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div > div > div.errors"));
            NameFieldIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div > div > div.input-field.col.s12.m6 > div"));
            TheNameEnteredDoesNotMatchMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
        }
    }
}
