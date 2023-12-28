using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public abstract class SurveyBasePage : BasePage
    {
        public Button NextButton { get; private set; }
        public Button BackButton { get; private set; }

        public SurveyBasePage(IWebDriver driver)
            : base(driver)
        {
            NextButton = new Button(Driver, By.Id("sg_NextButton"));
            BackButton = new Button(Driver, By.Id("sg_BackButton"));
        }
	}
}
