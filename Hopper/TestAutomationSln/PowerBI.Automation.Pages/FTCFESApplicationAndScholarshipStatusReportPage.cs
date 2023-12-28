using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class FTCFESApplicationAndScholarshipStatusReportPage : PowerBIBasePage
    {
        public PowerBITable StudentsByApplicationStatusTable { get; private set; }
        public PowerBITable ActiveScholarshipsTable { get; private set; }

        public FTCFESApplicationAndScholarshipStatusReportPage(IWebDriver driver)
            : base(driver)
        {
            StudentsByApplicationStatusTable = new PowerBITable(Driver, By.Id("ReportViewerControl_fixedTable"));
            ActiveScholarshipsTable = new PowerBITable(Driver, By.CssSelector("#P3032f4b6e0394b55ade1172b4b8ed1be_1_oReportCell > table > tbody > tr > td > table > tbody > tr:nth-child(10) > td:nth-child(2) > table"));
        }
    }
}
