using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationSubmitApplicationPage : ApplicationWizardPage
    {

        public ApplicationSubmitApplicationPage(IWebDriver driver)
            : base(driver) { }
    }
}
