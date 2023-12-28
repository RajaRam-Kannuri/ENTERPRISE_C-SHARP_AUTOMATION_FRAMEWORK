using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace FTC.PLI.Automation.Pages
{
    public class ApplicationWelcomePage : ApplicationWizardPage
    {
        public ApplicationWelcomePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
