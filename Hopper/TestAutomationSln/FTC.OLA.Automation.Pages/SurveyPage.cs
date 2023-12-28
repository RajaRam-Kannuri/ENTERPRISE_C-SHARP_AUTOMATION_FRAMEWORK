using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class SurveyPage : BasePage
    {
        public Button StartSurveyButton { get; private set; }
        public FTCSurvey FTCSurvey { get; private set; }
        public Button ContinueButton { get; private set; }

        public SurveyPage(IWebDriver driver)
            : base(driver)
        {
            StartSurveyButton = new Button(Driver, By.XPath("//*[contains(@href, 'FTC-Survey')]"));
            FTCSurvey = new FTCSurvey(Driver, By.XPath(""));
            ContinueButton = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > survey-complete-page > div > div > div > div > div.card-content > div > div > div > a"));
        }
    }
}
