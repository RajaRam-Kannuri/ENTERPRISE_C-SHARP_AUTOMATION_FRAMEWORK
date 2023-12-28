using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class CheckFileProcessPage : BasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Dropdown VerificationPeriod { get; private set; }

        public Text CurrentVRPeriod { get; private set; }

        public Button RunCheckFileProcess { get; private set; }

        public CheckFileProcessPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("input[id$=\"ddlSchoolYear\"]"));
            VerificationPeriod = new Dropdown(Driver, By.CssSelector("input[id$=\"ddlVRPeriod\"]"));
            CurrentVRPeriod = new Text(Driver, By.CssSelector("input[id$=\"lblVRPeriodReportID\"]"));
            RunCheckFileProcess = new Button(Driver, By.CssSelector("input[id$=\"btnCheckFile\"]"));
        }
    }
}
