using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FoodStampsPage : ApplicationWizardPage
    {
        public Button No { get; private set; }
        public Button Yes { get; private set; }
        public OLAWorkflowDropdown DocumentDropdown { get; private set; }

        public FoodStampsPage(IWebDriver driver)
            : base(driver)
        {
            No = new Button(Driver, By.CssSelector("label[for$=\"no\"]"));
            Yes = new Button(Driver, By.CssSelector("label[for$=\"yes\"]"));
            DocumentDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
        }
    }
}