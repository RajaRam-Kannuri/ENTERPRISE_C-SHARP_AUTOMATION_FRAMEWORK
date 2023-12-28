using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationSurveyPage : ApplicationWizardPage
    {
        public Radio HowIHeardAboutSUFS { get; private set; } 

        public EditField Description { get; private set; }

        public ApplicationSurveyPage(IWebDriver driver)
            : base(driver)
        {
            HowIHeardAboutSUFS = new Radio(Driver, By.CssSelector("input[value=\"71\"]"));
            Description = new EditField(Driver, By.Id("RPMainPanel_controls_survey_marketingsurvey_ascx51_tbMarketingSourceDescription"));
        }
    }
}
