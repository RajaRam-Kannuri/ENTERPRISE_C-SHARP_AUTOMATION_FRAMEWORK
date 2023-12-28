using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class AttendanceClassSettingsPage : CommonPage
    {
        public Checkbox SelectAll { get; private set; }

        public Button SaveButton { get; private set; }

        public Button CancelButton { get; private set; }

        public AttendanceClassSettingsPage(IWebDriver driver)
            : base(driver)
        {
            SelectAll = new Checkbox(Driver, By.Id("select-all"));
            SaveButton = new Button(Driver, By.CssSelector("button[type=\"Submit\"]"));
            CancelButton = new Button(Driver, By.CssSelector("button[type=\"Reset\"]"));
        }
    }
}
