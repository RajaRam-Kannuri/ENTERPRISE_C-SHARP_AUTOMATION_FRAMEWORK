using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class SurveyTermsAndConditionsPage :
        SurveyBasePage
    {
        public EditField SignatureField { get; private set; }
        public EditField SignatureTextBox { get; private set; }

        public SurveyTermsAndConditionsPage(IWebDriver driver)
            : base(driver)
        {
            SignatureField = new EditField(Driver, By.TagName("canvas"));
            SignatureTextBox = new EditField(Driver, By.CssSelector("#sgE-5397639-16-154-name"));
        }
    }
}
