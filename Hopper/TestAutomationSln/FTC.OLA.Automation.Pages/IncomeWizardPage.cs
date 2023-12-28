using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public abstract class IncomeWizardPage : ApplicationWizardPage
    {
        public Button No { get; private set; }
        public Button Yes { get; private set; }
        public EditField IncomeAmount { get; private set; }
        public OLAWorkflowDropdown PaymentFrequencyDropdown { get; private set; }
        public OLAWorkflowDropdown2 DocumentDropdown { get; private set; }
        public Text YouMustEnterAValueMessage { get; private set; }
        public Text YouMustSelectAPayFrequencyMessage { get; private set; }
        public Text ProjectedAnnualIncomeStatement { get; private set; }
        public Text PleaseSelectAnAnswerMessage { get; private set; }
        public Text AddAnotherLink { get; private set; }

        public IncomeWizardPage(IWebDriver driver)
            : base(driver)
        {
            No = new Button(Driver, By.Id("noLabel"));
            Yes = new Button(Driver, By.Id("yesLabel"));
            IncomeAmount = new EditField(Driver, By.Id("amount-0"));
            PaymentFrequencyDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            DocumentDropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            YouMustEnterAValueMessage = new Text(Driver, By.Id("amount-error-0"));
            YouMustSelectAPayFrequencyMessage = new Text(Driver, By.Id("frequency-error-0"));
            ProjectedAnnualIncomeStatement = new Text(Driver, By.Id("annual-calculation"));
            PleaseSelectAnAnswerMessage = new Text(Driver, By.Id("hasThisSourceOfIncomeErrors"));
            AddAnotherLink = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div.col.s12.m8.offset-m2 > div > a.waves-effect.waves-light.light-blue-text.darken-1"));
        }
    }
}
