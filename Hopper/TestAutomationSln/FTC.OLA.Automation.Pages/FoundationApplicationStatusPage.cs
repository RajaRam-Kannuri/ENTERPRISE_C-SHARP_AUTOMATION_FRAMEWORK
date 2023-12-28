using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FoundationApplicationStatusPage : FoundationWizardPage
    {
        public Dropdown SchoolYear { get; private set; }
        public Text ApplicationID { get; private set; }
        public Text ApplicationStatus { get; private set; }

        public FoundationApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_ddlScholarshipApplicationYear\"]"));
            ApplicationID = new Text(Driver, By.CssSelector("span[id$=\"RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_lblApplicationIDValue\"]"));
            ApplicationStatus = new Text(Driver, By.CssSelector("span[id$=\"RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_lblApplicationStatusMessage\"]"));
        }
    }
}
