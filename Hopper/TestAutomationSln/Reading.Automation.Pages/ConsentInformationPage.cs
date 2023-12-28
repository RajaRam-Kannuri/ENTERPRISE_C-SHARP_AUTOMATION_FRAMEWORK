using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class ConsentInformationPage :
        SurveyBasePage
    {
        public Radio ConsentYESRadioButton { get; private set; }
        public Radio ConsentNORadioButton { get; private set; }
        public Radio AuthorizeYESRadioButton { get; private set; }
        public Radio AuthorizeNORadioButton { get; private set; }

        public ConsentInformationPage(IWebDriver driver)
            : base(driver)
        {
            ConsentYESRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-11-150-10472\"]"));
            ConsentNORadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-11-150-10473\"]"));
            AuthorizeYESRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-11-149-10468\"]"));
            AuthorizeNORadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-11-149-10469\"]"));
        }
    }
}
