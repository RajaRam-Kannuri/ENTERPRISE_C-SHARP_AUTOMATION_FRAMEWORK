using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class IncomeConfirmationBasedOnMaritalStatusPage : ApplicationWizardPage
    {
        public Checkbox NoSocialSecurityIncomeForParentYESCheckbox { get; private set; }
        //public Button NoSocialSecurityIncomeForParentAddIncomeButton { get; private set; }
        public Checkbox NoSocialSecurityIncomeForChildYESCheckbox { get; private set; }
        //public Button NoSocialSecurityIncomeForChildAddIncomeButton { get; private set; }
        public Checkbox NoChildSupportIncomeForParentYESCheckbox { get; private set; }
        //public Button NoChildSupportIncomeForParentAddIncomeButton { get; private set; }
        public Checkbox NoAlimonyIncomeForParentYESCheckbox { get; private set; }

        public IncomeConfirmationBasedOnMaritalStatusPage(IWebDriver driver)
            : base(driver)
        {
            NoSocialSecurityIncomeForParentYESCheckbox = new Checkbox(Driver, By.CssSelector("label[for*=\"socialSecurityYouConfirmed\"]"));
            //NoSocialSecurityIncomeForParentAddIncomeButton = new Button(Driver, By.Id("password-icon"));
            NoSocialSecurityIncomeForChildYESCheckbox = new Checkbox(Driver, By.CssSelector("label[for*=\"socialSecurityYourChildrenConfirmed\"]"));
            //NoSocialSecurityIncomeForChildAddIncomeButton = new Button(Driver, By.Id("back-to-login"));
            NoChildSupportIncomeForParentYESCheckbox = new Checkbox(Driver, By.CssSelector("label[for*=\"childSupportConfirmed\"]"));
            //NoChildSupportIncomeForParentAddIncomeButton = new Button(Driver, By.CssSelector("#question-form > div.row.section.ng-star-inserted > div.col.s6.m3.button > button"));
            NoAlimonyIncomeForParentYESCheckbox = new Checkbox(Driver, By.CssSelector("label[for*=\"alimonyConfirmed\"]"));
        }
    }
}

