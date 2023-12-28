using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class AppealPage : FTCPLIBasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Text ApplicationId { get; private set; }

        public Dropdown AppealReason { get; private set; }

        public EditField AppealDetail { get; private set; }

        public Button SubmitButton { get; private set; }

        public AppealPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationID\"]"));
            AppealReason = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAppealReasonType\"]"));
            AppealDetail = new EditField(Driver, By.CssSelector("input[id$=\"txtJustificationReason\"]"));
            SubmitButton = new Button(Driver, By.CssSelector("input[id$=\"Submit\"]"));
        }
    }
}
