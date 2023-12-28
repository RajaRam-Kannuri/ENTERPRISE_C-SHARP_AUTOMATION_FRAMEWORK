using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class ApplicationStatusPage : StudentInfoPage
    {
        public Table Students { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            Students = new Table(Driver, By.CssSelector("table[id$=\"_gvApplicationStatus\"]"));
        }
    }
}
