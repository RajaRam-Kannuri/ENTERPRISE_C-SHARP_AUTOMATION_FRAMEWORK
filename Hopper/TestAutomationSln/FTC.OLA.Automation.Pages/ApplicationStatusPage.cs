using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ApplicationStatusPage : PLIBasePage
    {
        public Text PageName { get; private set; }
        public Dropdown SchoolYearDropdown { get; private set; }
        public Text ApplicationID { get; private set; }
        public Button SubmitButton { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            PageName = new Text(Driver, By.Id("RPMainPanel_LblPageName"));
            SchoolYearDropdown = new Dropdown(Driver, By.Id("RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_ddlScholarshipApplicationYear"));
            ApplicationID = new Text(Driver, By.Id("RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_lblApplicationIDValue"));
        }
    }
}
