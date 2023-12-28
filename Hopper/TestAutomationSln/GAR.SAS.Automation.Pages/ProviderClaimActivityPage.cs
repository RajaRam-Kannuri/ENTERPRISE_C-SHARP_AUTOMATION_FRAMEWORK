using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ProviderReimbursementActivityPage : HomePage
    {
        public WebElement NoActivityMessage { get; private set; }

        public WebElement ProviderName { get; private set; }

        public WebElement ProviderId { get; private set; }

        public WebElement SchoolYear { get; private set; }

        public ProviderReimbursementActivityPage(IWebDriver driver)
            : base(driver)
        {
            NoActivityMessage = new WebElement(Driver, By.CssSelector("span[id$=\"lblMessage\"]"));
            ProviderName = new WebElement(Driver, By.CssSelector("span[id*=\"providerclaimactivity\"][id$=\"lblProviderName\"]"));
            ProviderId = new WebElement(Driver, By.CssSelector("span[id*=\"providerclaimactivity\"][id$=\"lblProviderID\"]"));
            SchoolYear = new WebElement(Driver, By.CssSelector("select[id*=\"providerclaimactivity\"][id$=\"ddlOrganizationYear\"]"));
        }

        public bool ProviderHasActivityHistory()
        {
            return NoActivityMessage.IsAvailable() || ProviderId.IsAvailable();
        }

        public string CollectProviderName()
        {
            return ProviderName.Text;
        }
    }
}
