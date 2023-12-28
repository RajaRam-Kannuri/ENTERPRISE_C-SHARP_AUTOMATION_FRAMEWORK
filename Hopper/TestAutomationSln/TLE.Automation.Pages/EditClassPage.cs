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
    public class EditClassPage : CommonPage
    {
        public EditField Description { get; private set; }

        public TypeAheadList Period { get; private set; }

        public EditField Credits { get; private set; }

        public Button SaveButton { get; private set; }

        public EditClassPage(IWebDriver driver)
            : base(driver)
        {
            Description = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.description\"]]"));
            Period = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.period\"]"));
            Credits = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.credits\"]"));
            SaveButton = new Button(Driver, By.Id("btnSave"));
        }
    }
}
