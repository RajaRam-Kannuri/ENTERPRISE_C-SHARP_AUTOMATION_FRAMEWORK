using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class TestPage :
        SurveyBasePage
    {
        public Button OkButton { get; private set; }
        

        public TestPage(IWebDriver driver)
            : base(driver)
        {
            OkButton = new Button(Driver, By.Id("sg_SubmitButton"));

        }
    }
}
