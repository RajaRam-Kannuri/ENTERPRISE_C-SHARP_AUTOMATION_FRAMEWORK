using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberNamePage : ApplicationWizardPage
    {
        public EditField FirstName { get; private set; }
        public EditField MiddleName { get; private set; }
        public EditField LastName { get; private set; }
        public OLAWorkflowDropdown SuffixDropdown { get; private set; }
        public Text FirstNameIsRequiredMessage { get; private set; }
        public Text FirstNameInvalidCharactersMessage { get; private set; }
        public Text FirstNameNotLongEnoughMessage { get; private set; }
        public Text LastNameIsRequiredMessage { get; private set; }
        public Text LastNameInvalidCharactersMessage { get; private set; }
        public Text LastNameNotLongEnoughMessage { get; private set; }

        public NewMemberNamePage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.Id("firstName"));
            MiddleName = new EditField(Driver, By.Id("middleName"));
            LastName = new EditField(Driver, By.Id("lastName"));
            SuffixDropdown = new OLAWorkflowDropdown (Driver, By.ClassName("select-dropdown"));
            FirstNameIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div"));
            FirstNameInvalidCharactersMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div"));
            FirstNameNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div"));
            LastNameIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(3) > div"));
            LastNameInvalidCharactersMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(3) > div"));
            LastNameNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(3) > div"));
        }
    }
}
