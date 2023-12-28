using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ProviderSearchResultsSection : ControlSection
    {
        public Table ProviderTable { get; private set; }

        public ProviderSearchResultsSection(IWebDriver driver)
            : base(driver)
        {
            ProviderTable = new Table(Driver, By.Id("tblResults"));
        }
    }
}
