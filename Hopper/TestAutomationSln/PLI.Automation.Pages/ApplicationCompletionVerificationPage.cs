using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationCompletionVerificationPage : ApplicationWizardPage
    {
        public ApplicationCompletionVerificationPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
