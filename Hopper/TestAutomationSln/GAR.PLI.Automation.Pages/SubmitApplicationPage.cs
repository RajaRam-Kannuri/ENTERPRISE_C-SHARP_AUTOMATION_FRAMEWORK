using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class SubmitApplicationPage : ApplicationWizardPage
    {
        public SubmitApplicationPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
