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
    public class CreateNewSuperintendentPage : CommonPage
    {
        public EditField Username { get; private set; }

        public EditField FirstName { get; private set; }

        public EditField LastName { get; private set; }

        public EditField SaveButton { get; private set; }

        public EditField CancelButton { get; private set; }

        public CreateNewSuperintendentPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.CssSelector("input[ng-model='vm.user.userName']"));
            FirstName = new EditField(Driver, By.CssSelector("input[ng-model='vm.user.firstName']"));
            LastName = new EditField(Driver, By.CssSelector("input[ng-model='vm.user.lastName']"));
            SaveButton = new EditField(Driver, By.Name("save"));
            CancelButton = new EditField(Driver, By.LinkText("Cancel"));
        }
    }
}
