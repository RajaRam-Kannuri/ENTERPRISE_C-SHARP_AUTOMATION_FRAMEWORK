using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class MarketingUnfinishedAppsPage : PowerBIBasePage
    {
        public PowerBIReport Report { get; private set; }
        public Text CountOfUnfinishedApplications { get; private set; }
        public Button CountOfUnfinishedApplicationsByCountyVisualization { get; private set; }
        public Button CountOfUnfinishedApplicationsByDateVisualization { get; private set; }
        public Button UnfinishedApplicationsBySchoolYearVisualization { get; private set; }
        public Button DataTableVisualization { get; private set; }
        public Text PercentOfUnfinishedApplications { get; private set; }
        public Text CountOfStudentsOnUnfinishedApplications { get; private set; }
        public Text PercentOfStudentsOnUnfinishedApplications { get; private set; }
        public Button ProcessingSchoolYearDropdownButton { get; private set; }
        public PowerBIDropdown ProcessingSchoolYearDropdownList { get; private set; }
        public Button ReportMonthDropdownButton { get; private set; }
        public PowerBIDropdown ReportMonthDropdownList { get; private set; }
        public Button NewRenewalStatusDropdownButton { get; private set; }
        public PowerBIDropdown NewRenewalStatusDropdownList { get; private set; }
        public Button CountyDropdownButton { get; private set; }
        public PowerBIDropdown CountyDropdownList { get; private set; }
        public Button MediaMarketDropdownButton { get; private set; }
        public PowerBIDropdown MediaMarketDropdownList { get; private set; }
        public Button CityDropdownButton { get; private set; }
        public PowerBIDropdown CityDropdownList { get; private set; }
        public Button ZipCodeDropdownButton { get; private set; }
        public PowerBIDropdown ZipCodeDropdownList { get; private set; }

        public MarketingUnfinishedAppsPage(IWebDriver driver)
            : base(driver)
        {
            Report = new PowerBIReport(Driver, By.Id("content"));
            CountOfUnfinishedApplications = new Text(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(7) > transform > div > div.visualContent > div > visual-modern > div > svg > g:nth-child(1) > text > tspan"));
            CountOfUnfinishedApplicationsByCountyVisualization = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(11) > transform > div > div.visualContent > div > visual-modern"));
            CountOfUnfinishedApplicationsByDateVisualization = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(15) > transform > div > div.visualContent > div > visual-modern"));
            UnfinishedApplicationsBySchoolYearVisualization = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(12) > transform > div > div.visualContent > div > visual-modern"));
            DataTableVisualization = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(19) > transform > div > div.visualContent > div > visual-modern"));
            PercentOfUnfinishedApplications = new Text(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(8) > transform > div > div.visualContent > div > visual-modern > div > svg > g:nth-child(1) > text > tspan"));
            CountOfStudentsOnUnfinishedApplications = new Text(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(6) > transform > div > div.visualContent > div > visual-modern > div > svg > g:nth-child(1) > text > tspan"));
            PercentOfStudentsOnUnfinishedApplications = new Text(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(9) > transform > div > div.visualContent > div > visual-modern > div > svg > g:nth-child(1) > text > tspan"));
            ProcessingSchoolYearDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(10) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            ProcessingSchoolYearDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(67) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content > div > div"));
            ReportMonthDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(13) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            ReportMonthDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(68) > div.slicer-dropdown-content > div > div.slicerBody"));
            NewRenewalStatusDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(14) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            NewRenewalStatusDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(69) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content > div > div"));
            CountyDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(16) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            CountyDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(70) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content.scroll-scrolly_visible > div > div"));
            MediaMarketDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(17) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            MediaMarketDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(71) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content.scroll-scrolly_visible > div > div"));
            CityDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(18) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            CityDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(72) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content.scroll-scrolly_visible > div > div"));
            ZipCodeDropdownButton = new Button(Driver, By.CssSelector("#pvExplorationHost > div > div > exploration > div > explore-canvas > div > div.canvasFlexBox > div > div.displayArea.disableAnimations.fitToPage > div.visualContainerHost > visual-container-repeat > visual-container:nth-child(20) > transform > div > div.visualContent > div > visual-modern > div > div > div.slicer-content-wrapper > div > i"));
            ZipCodeDropdownList = new PowerBIDropdown(Driver, By.CssSelector("body > div:nth-child(73) > div.slicer-dropdown-content > div > div.slicerBody > div > div.scrollbar-inner.scroll-content.scroll-scrolly_visible > div > div"));
        }
    }
}
