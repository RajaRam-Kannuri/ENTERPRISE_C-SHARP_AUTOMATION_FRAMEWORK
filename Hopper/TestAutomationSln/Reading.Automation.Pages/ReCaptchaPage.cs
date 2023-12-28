using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class ReCaptchaPage :
        SurveyBasePage
    {

        public ReCaptchaPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
