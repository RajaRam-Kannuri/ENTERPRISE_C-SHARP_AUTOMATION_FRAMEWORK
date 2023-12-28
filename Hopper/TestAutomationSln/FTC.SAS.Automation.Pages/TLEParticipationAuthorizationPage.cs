using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class TLEParticipationAuthorizationPage : HomePage
    {
        public Dropdown TLEParticipation { get; private set; }

        public Button SaveButton { get; private set; }

        public TLEParticipationAuthorizationPage(IWebDriver driver)
            : base(driver)
        {
            TLEParticipation = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolParticipant\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveSchoolParticipation\"]"));
        }
    }
}
