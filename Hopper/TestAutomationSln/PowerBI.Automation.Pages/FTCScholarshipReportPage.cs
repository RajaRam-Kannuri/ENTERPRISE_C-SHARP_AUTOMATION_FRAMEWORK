using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class FTCScholarshipReportPage : PowerBIBasePage
    {
        public Text CurrentSchoolYearText { get; private set; }
        public Button FTCCumulativeEnrollmentsTile { get; private set; }
        public Button FTCHistoricalTrendsTile { get; private set; }
        public Button FTCCurrentlyAttendingStudentsTile { get; private set; }
        public Button FTCEmployerSearchTile { get; private set; }
        public Button FTCEnrolledBySchoolTile { get; private set; }
        public Button FTCParentsByLegislativeDistrictTile { get; private set; }
        public Button FTCCumulativeFundedStudentsTile { get; private set; }
        public Text FTCAverageAnnualIncomeText { get; private set; }

        public FTCScholarshipReportPage(IWebDriver driver)
            : base(driver)
        {
            CurrentSchoolYearText = new Text(Driver, By.CssSelector("#dashboard3760792 > li.dashboardTile.baseTile.gridLayoutItem.smallestTileHeight.largeTitleWidth.readonly.nonActionable.transformElement > div.tileWrapper > div > a > div > section > div > div > div > visual > div > div > p > span"));
            FTCCumulativeEnrollmentsTile = new Button(Driver, By.CssSelector(""));
            FTCHistoricalTrendsTile = new Button(Driver, By.CssSelector(""));
            FTCCurrentlyAttendingStudentsTile = new Button(Driver, By.CssSelector(""));
            FTCEmployerSearchTile = new Button(Driver, By.CssSelector(""));
            FTCEnrolledBySchoolTile = new Button(Driver, By.CssSelector(""));
            FTCParentsByLegislativeDistrictTile = new Button(Driver, By.CssSelector(""));
            FTCCumulativeFundedStudentsTile = new Button(Driver, By.CssSelector(""));
            FTCAverageAnnualIncomeText = new Text(Driver, By.CssSelector(""));
        }
    }
}
