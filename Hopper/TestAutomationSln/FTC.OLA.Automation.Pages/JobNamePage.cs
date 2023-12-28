using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class JobNamePage : ApplicationWizardPage
    {
        public Button IWorkHereRadioButton { get; private set; }
        public Button IOwnThisBusinessRadioButton { get; private set; }
        public EditField JobNameTextbox { get; private set; }
        public Text PleaseIndicateWhetherYouWorkHereMessage { get; private set; }
        public Text JobNameMustBeAtLeast2CharactersMessage { get; private set; }
        public Text JobNameIsRequiredMessage { get; private set; }

        public JobNamePage(IWebDriver driver)
            : base(driver)
        {
            IWorkHereRadioButton = new Button(Driver, By.CssSelector("label[for$=\"no\"]"));
            IOwnThisBusinessRadioButton = new Button(Driver, By.CssSelector("label[for$=\"yes\"]"));
            //IWorkHereRadioButton = new Button(Driver, By.Id("no"));
            //IOwnThisBusinessRadioButton = new Button(Driver, By.Id("yes"));
            JobNameTextbox = new EditField(Driver, By.Id("jobName"));
            PleaseIndicateWhetherYouWorkHereMessage = new Text(Driver, By.Id("jobTypeRequired"));
            JobNameMustBeAtLeast2CharactersMessage = new Text(Driver, By.Id("jobNameErrors"));
            JobNameIsRequiredMessage = new Text(Driver, By.Id("jobNameErrors"));
        }
    }
}