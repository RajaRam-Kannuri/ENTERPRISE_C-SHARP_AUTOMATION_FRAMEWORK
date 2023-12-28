using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class ConfigureFeatureSettingsPage : HomePage
    {
        public Button FreeReducedLunch0StudentsEditButton { get; private set; }
        public Button FreeReducedLunch1StudentEditButton { get; private set; }
        public Button FreeReducedLunch2StudentsEditButton { get; private set; }
        public Button FreeReducedLunch0StudentsUpdateButton { get; private set; }
        public Button FreeReducedLunch1StudentUpdateButton { get; private set; }
        public Button FreeReducedLunch2StudentsUpdateButton { get; private set; }
        public Button FreeReducedLunch0StudentsCancelButton { get; private set; }
        public Button FreeReducedLunch1StudentCancelButton { get; private set; }
        public Button FreeReducedLunch2StudentsCancelButton { get; private set; }
        public Checkbox FreeReducedLunch0StudentsIsEnabledCheckbox { get; private set; }
        public Checkbox FreeReducedLunch1StudentIsEnabledCheckbox { get; private set; }
        public Checkbox FreeReducedLunch2StudentsIsEnabledCheckbox { get; private set; }

        public ConfigureFeatureSettingsPage(IWebDriver driver)
            : base(driver)
        {
            FreeReducedLunch0StudentsEditButton = new Button(Driver, By.CssSelector("input[id$=\"ctl04_btnEdit\"]"));
            FreeReducedLunch1StudentEditButton = new Button(Driver, By.CssSelector("input[id$=\"ctl05_btnEdit\"]"));
            FreeReducedLunch2StudentsEditButton = new Button(Driver, By.CssSelector("input[id$=\"ctl06_btnEdit\"]"));
            FreeReducedLunch0StudentsUpdateButton = new Button(Driver, By.CssSelector("input[id$=\"ctl04_btnUpdate\"]"));
            FreeReducedLunch1StudentUpdateButton = new Button(Driver, By.CssSelector("input[id$=\"ctl05_btnUpdate\"]"));
            FreeReducedLunch2StudentsUpdateButton = new Button(Driver, By.CssSelector("input[id$=\"ctl06_btnUpdate\"]"));
            FreeReducedLunch0StudentsCancelButton = new Button(Driver, By.CssSelector("input[id$=\"ctl04_btnCancel\"]"));
            FreeReducedLunch1StudentCancelButton = new Button(Driver, By.CssSelector("input[id$=\"ctl05_btnCancel\"]"));
            FreeReducedLunch2StudentsCancelButton = new Button(Driver, By.CssSelector("input[id$=\"ctl06_btnCancel\"]"));
            FreeReducedLunch0StudentsIsEnabledCheckbox = new Checkbox(Driver, By.CssSelector("input[id$=\"ctl04_chkIsEnabled\"]"));
            FreeReducedLunch1StudentIsEnabledCheckbox = new Checkbox(Driver, By.CssSelector("input[id$=\"ctl05_chkIsEnabled\"]"));
            FreeReducedLunch2StudentsIsEnabledCheckbox = new Checkbox(Driver, By.CssSelector("input[id$=\"ctl06_chkIsEnabled\"]"));
        }
    }
}
