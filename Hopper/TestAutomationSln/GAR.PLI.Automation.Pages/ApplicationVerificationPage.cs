using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class ApplicationVerificationPage : ApplicationWizardPage
    {
        public Table ApplicationErrors { get; private set; }

        public ApplicationVerificationPage(IWebDriver driver) : base(driver)
        {
            ApplicationErrors = new Table(Driver, By.CssSelector("table[id$=\"gvApplicationError\"]"));
        }
    }
}
