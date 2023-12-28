using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class ApproveProviderReimbursementPage : AccountActivityPage
    {
        public ReimbursementTable ProviderReimbursementsTable { get; private set; }


        public ApproveProviderReimbursementPage(IWebDriver driver)
            : base(driver)
        {
            ProviderReimbursementsTable = new ReimbursementTable(Driver, By.CssSelector("table[id$=\"gvPendingProviderClaims\"]"));
        }
    }
}
