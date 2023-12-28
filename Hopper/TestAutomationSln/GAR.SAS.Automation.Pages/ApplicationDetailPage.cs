using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class ApplicationDetailPage : HomePage
    {
        public Dropdown ReportSchoolYear => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));

        public Dropdown ApplicationStatus => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationStatus\"]"));

        public Dropdown ApplicationType => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationType\"]"));

        public Dropdown HouseholdLanguage => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlHouseholdLanguage\"]"));

        public Dropdown StudentStatus => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudentStatus\"]"));

        public Dropdown StudentType => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudentType\"]"));

        public Dropdown PaperApplications => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPaper\"]"));

        public Dropdown AppealApplications => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAppeal\"]"));

        public Dropdown Format => new Dropdown(Driver, By.CssSelector("select[id$=\"ddlFormat\"]"));

        public Button ViewReportButton => new Button(Driver, By.CssSelector("input[id$=\"btnReport\"]"));

        public Text ReportTitle => new Text(Driver, By.XPath(".//td[@class='a4']"));


        public ApplicationDetailPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
