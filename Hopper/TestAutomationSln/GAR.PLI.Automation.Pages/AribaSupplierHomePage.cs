using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class AribaSupplierHomePage : BasePage
    {
        public AribaOrdersTable OrderTable { get; private set; }

        public AribaSupplierHomePage(IWebDriver driver)
            : base(driver)
        {
            OrderTable = new AribaOrdersTable(Driver, By.Id("_mfdx8b"));
        }
    }
}
