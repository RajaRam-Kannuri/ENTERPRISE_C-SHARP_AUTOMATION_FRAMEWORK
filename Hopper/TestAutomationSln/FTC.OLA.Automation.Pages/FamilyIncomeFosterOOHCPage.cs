using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FamilyIncomeFosterOOHCPage : IncomeWizardPage
    {
        //public Button No { get; private set; }
        //public Button Yes { get; private set; }
        //public EditField IncomeAmount { get; private set; }
        //public OLAWorkflowDropdown PaymentFrequencyDropdown { get; private set; }
        //public OLAWorkflowDropdown2 DocumentDropdown { get; private set; }
        //public Text YouMustEnterAValueMessage { get; private set; }
        //public Text YouMustSelectAPayFrequencyMessage { get; private set; }
        //public Text AddAnotherLink { get; private set; }
        //public Text ProjectedAnnualIncomeStatement { get; private set; }

        public FamilyIncomeFosterOOHCPage(IWebDriver driver)
            : base(driver)
        {
            //No = new Button(Driver, By.CssSelector("label[for$=\"no\"]"));
            //Yes = new Button(Driver, By.CssSelector("label[for$=\"yes\"]"));
            //IncomeAmount = new EditField(Driver, By.Id("income"));
            //PaymentFrequencyDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            //DocumentDropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            //YouMustEnterAValueMessage = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div:nth-child(1) > income-component > div > form > div.row.section.no-margin-top.input-field.income-errors > div > div > p:nth-child(1)"));
            //YouMustSelectAPayFrequencyMessage = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div:nth-child(1) > income-component > div > form > div.row.section.no-margin-top.input-field.income-errors > div > div > p:nth-child(2)"));
            //AddAnotherLink = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div.col.s12.m8.offset-m2 > div > a.waves-effect.waves-light.light-blue-text.darken-1"));
            //ProjectedAnnualIncomeStatement = new Text(Driver, By.XPath("//*[contains(@p, 'Based on what you entered')]"));
        }
    }
}