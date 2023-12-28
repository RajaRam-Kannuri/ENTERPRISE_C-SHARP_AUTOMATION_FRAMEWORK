using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberSharedExpensesPage : ApplicationWizardPage
    {
        public Button NoSharedExpenses { get; private set; }
        public Button YesSharedExpenses { get; private set; }
        public Text YouMustSelectYesOrNoMessage { get; private set; }

        public NewMemberSharedExpensesPage(IWebDriver driver)
            : base(driver)
        {
            NoSharedExpenses = new Button(Driver, By.CssSelector("#question-form > div > div.col.s6.right-align.no-radio-container > div > label"));
            YesSharedExpenses = new Button(Driver, By.CssSelector("#question-form > div > div:nth-child(2) > label"));
            YouMustSelectYesOrNoMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div > div"));
        }
    }
}
