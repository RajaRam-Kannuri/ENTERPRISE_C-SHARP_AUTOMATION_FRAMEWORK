using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class CafeteriaSettingsPage : CommonPage
    {
        public Dropdown LunchCountClassPeriod { get; private set; }

        public Button AddMoreMenuOptionsButton { get; private set; }

        public Button SaveButton { get; private set; }

        public CafeteriaSettingsPage(IWebDriver driver)
            : base(driver)
        {
            LunchCountClassPeriod = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.selectedPeriod\"]"));
            AddMoreMenuOptionsButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.addLunchOption()\"]"));
            SaveButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save()\"]"));
        }
    }
}
