using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class FESEOandUAAvailableSeatsPage : PowerBIBasePage
    {
        public AvailableSeatsTable PageElementsTable { get; private set; }


        //public Text TotalFESEOAwardedAndEnrolled { get; private set; }
        //public Text TotalFESEOAwardedAndEnrolledPriorDayChange { get; private set; }
        //public Text TotalEstimatedFESEOCapExclusions { get; private set; }
        //public Text FESEOTotalMilitary { get; private set; }
        //public Text FESEOTotalFoster { get; private set; }
        //public Text FESEOTotalAdopted { get; private set; }
        //public Text FESEOTotalLawEnforcement { get; private set; }
        //public Text FESEOTotalPriorPublicAndDirectCert { get; private set; }
        //public Text FESEOTotalPriorPublicAndFPL185 { get; private set; }
        //public Text FESEOTotalPriorPublicAndOOH { get; private set; }
        //public Text FESUACurrentAwarded { get; private set; }
        //public Text FESUACurrentAwardedPriorDayChange { get; private set; }
        //public Text TotalEstimatedFESUACapExclusions { get; private set; }
        //public Text FESUAFloridaVPK { get; private set; }
        //public Text FESUATotalMilitary { get; private set; }
        //public Text FESUATotalFoster { get; private set; }
        //public Text FESUATotalAdopted { get; private set; }
        //public Text FESUATotalLawEnforcement { get; private set; }
        //public Text FESUAPriorSchoolForDeafAndBlind { get; private set; }
        //public Text FESUAPriorPublic { get; private set; }
        //public Text FESUAPriorMcKay { get; private set; }

        public FESEOandUAAvailableSeatsPage(IWebDriver driver)
            : base(driver)
        {
            PageElementsTable = new AvailableSeatsTable(Driver, By.Id("VisibleReportContentReportViewerControl_ctl09"));

            //TotalFESEOAwardedAndEnrolled = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_37iT0_aria > div"));
            //TotalFESEOAwardedAndEnrolledPriorDayChange = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_41iT0_aria > div"));
            //TotalEstimatedFESEOCapExclusions = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_50iT0_aria > div"));
            //FESEOTotalMilitary = new Text(Driver, By.CssSelector("#VisibleReportContentReportViewerControl_ctl09 > div > table > tbody > tr > td > table > tbody > tr:nth-child(5) > td:nth-child(1) > table > tbody > tr:nth-child(2) > td:nth-child(1) > div > div"));
            //FESEOTotalFoster = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_90iT1_aria > div"));
            //FESEOTotalAdopted = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_99iT1_aria > div"));
            //FESEOTotalLawEnforcement = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_108iT1_aria > div"));
            //FESEOTotalPriorPublicAndDirectCert = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_117iT1_aria > div"));
            //FESEOTotalPriorPublicAndFPL185 = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_126iT1_aria > div"));
            //FESEOTotalPriorPublicAndOOH = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_135iT1_aria > div"));
            //FESUACurrentAwarded = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_171iT2_aria > div"));
            //FESUACurrentAwardedPriorDayChange = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_175iT2_aria > div"));
            //TotalEstimatedFESUACapExclusions = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_175iT2_aria > div"));
            //FESUAFloridaVPK = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_248iT3_aria > div"));
            //FESUATotalMilitary = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_261iT3_aria > div"));
            //FESUATotalFoster = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_274iT3_aria > div"));
            //FESUATotalAdopted = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_287iT3_aria > div"));
            //FESUATotalLawEnforcement = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_300iT3_aria > div"));
            //FESUAPriorSchoolForDeafAndBlind = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_313iT3_aria > div"));
            //FESUAPriorPublic = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_326iT3_aria > div"));
            //FESUAPriorMcKay = new Text(Driver, By.CssSelector("#P908ca77675b245218c0f691661c5e67c_1_607iT6_aria > div"));
        }
    }
}
