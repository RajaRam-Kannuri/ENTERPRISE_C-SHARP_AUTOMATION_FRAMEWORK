using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class Feature_CreateAssignmentPage : CommonPage
    {
        public CreateAssignmentControlSection CreateAssignmentControlSection { get; private set; }

        public Button CancelButton { get; private set; }

        public Button SaveButton { get; private set; }

        public Feature_CreateAssignmentPage(IWebDriver driver)
            : base(driver)
        {
            CreateAssignmentControlSection = new CreateAssignmentControlSection(Driver);
            CancelButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.cancel()\"]"));
            SaveButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save()\"]"));
        }
    }
}
