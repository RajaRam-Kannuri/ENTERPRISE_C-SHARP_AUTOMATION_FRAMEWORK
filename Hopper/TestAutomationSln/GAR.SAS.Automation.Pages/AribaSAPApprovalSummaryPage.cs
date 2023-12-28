using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class AribaSAPApprovalSummaryPage : BasePage
    {
        public Button ApproveButton { get; private set; }
        public Button DenyButton { get; private set; }

        public AribaSAPApprovalSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ApproveButton = new Button(Driver, By.Id("_z7oeq"));
            DenyButton = new Button(Driver, By.Id("_rof2d"));
        }
    }
}
