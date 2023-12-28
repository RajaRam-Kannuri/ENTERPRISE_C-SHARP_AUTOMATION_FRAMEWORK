using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ApplicationSummaryPage : HomePage
    {
        public Dropdown ReportSchoolYearDropdown { get; private set; }
        public Dropdown ApplicationStatus { get; private set; }
        public Dropdown ApplicationType { get; private set; }
        public Dropdown HouseholdLanguage { get; private set; }
        public Dropdown StudentStatus { get; private set; }
        public Dropdown StudentType { get; private set; }
        public Dropdown PaperApplications { get; private set; }
        public Dropdown AppealApplications { get; private set; }
        public Dropdown Format { get; private set; }
        public Button ViewReportButton { get; private set; }
        public DetailReportTable ReportApplicationTable { get; private set; }
        public Text ReportSchoolYearText { get; private set; }
        public Text ReportStudentStatusText { get; private set; }
        public Text ReportApplicationStatusText { get; private set; }
        public Text ReportStudentTypeText { get; private set; }
        public Text ReportApplicationTypeText { get; private set; }
        public Text ReportPaperApplicationsText { get; private set; }
        public Text ReportHouseholdLanguageText { get; private set; }
        public Text ReportAppealApplicationText { get; private set; }
        public Text ReportCountText { get; private set; }

        public ApplicationSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ReportSchoolYearDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            ApplicationStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationStatus\"]"));
            ApplicationType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationType\"]"));
            HouseholdLanguage = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlHouseholdLanguage\"]"));
            StudentStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudentStatus\"]"));
            StudentType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudentType\"]"));
            PaperApplications = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPaper\"]"));
            AppealApplications = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAppeal\"]"));
            Format = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlFormat\"]"));
            ViewReportButton = new Button(Driver, By.CssSelector("input[id$=\"btnReport\"]"));
            ReportApplicationTable = new DetailReportTable(Driver, By.CssSelector(".a191"));
            ReportSchoolYearText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(6) > td:nth-child(5) > table > tbody > tr > td"));
            ReportStudentStatusText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(7) > td:nth-child(4) > table > tbody > tr > td"));
            ReportApplicationStatusText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(11) > td:nth-child(3) > table > tbody > tr > td"));
            ReportStudentTypeText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(14) > td:nth-child(4) > table > tbody > tr > td"));
            ReportApplicationTypeText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(19) > td:nth-child(4) > table > tbody > tr > td"));
            ReportPaperApplicationsText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(21) > td:nth-child(6) > table > tbody > tr > td"));
            ReportHouseholdLanguageText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(25) > td:nth-child(3) > table > tbody > tr > td"));
            ReportAppealApplicationText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(26) > td:nth-child(6) > table > tbody > tr > td"));
            ReportCountText = new Text(Driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(30) > td:nth-child(3) > table > tbody > tr:nth-child(3) > td.a79c.r6 > div"));
        }
    }
}
