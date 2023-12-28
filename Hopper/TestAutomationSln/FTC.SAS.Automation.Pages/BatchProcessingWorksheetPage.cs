using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class BatchProcessingWorksheetPage : HomePage
    {
        public SASWorkflowDropdown YearDropdown { get; private set; }
        public SASWorkflowDropdown ApplicationWorkflowStatusDropdown { get; private set; }
        public SASWorkflowDropdown NewStudentDropdown { get; private set; }
        public SASWorkflowDropdown FosterOutOfHomeCareDropdown { get; private set; }
        public SASWorkflowDropdown KindergartenFirstGradeDropdown { get; private set; }
        public SASWorkflowDropdown SixthNinthGradeDropdown { get; private set; }
        public SASWorkflowDropdown NewAdultDropdown { get; private set; }
        public SASWorkflowDropdown ApplicationTypeDropdown { get; private set; }
        public SASWorkflowDropdown HouseholdSizeDropdown { get; private set; }
        public SASWorkflowDropdown IncomeChangePercentageDropdown { get; private set; }
        public SASWorkflowDropdown PercentOfGuidelinesDropdown { get; private set; }
        public SASWorkflowDropdown DirectCertificationDropdown { get; private set; }
        public Button SearchButton { get; private set; }
        public Button ResetSearchButton { get; private set; }
        public Button SetAllToReviewCompleteButton { get; private set; }
        public Button SetAllToPendingProcessingButton { get; private set; }
        public Button UpdateButton { get; private set; }
        public Button YesButton { get; private set; }
        public Button NoButton { get; private set; }

        public BatchProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            YearDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(1) > td > bindable-dropdown > div"));
            ApplicationWorkflowStatusDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(2) > td > bindable-dropdown > div"));
            NewStudentDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(3) > td > bindable-dropdown > div"));
            FosterOutOfHomeCareDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(4) > td > bindable-dropdown > div"));
            KindergartenFirstGradeDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(5) > td > bindable-dropdown > div"));
            SixthNinthGradeDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(6) > td > bindable-dropdown > div"));
            NewAdultDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(2) > table > tbody > tr:nth-child(7) > td > bindable-dropdown > div"));
            ApplicationTypeDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(1) > td > bindable-dropdown > div"));
            HouseholdSizeDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(2) > td > bindable-dropdown > div"));
            IncomeChangePercentageDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(3) > td > bindable-dropdown > div"));
            PercentOfGuidelinesDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(4) > td > bindable-dropdown > div"));
            DirectCertificationDropdown = new SASWorkflowDropdown(Driver, By.CssSelector("#searchForm > div:nth-child(2) > div:nth-child(3) > table > tbody > tr:nth-child(5) > td > bindable-dropdown > div"));
            SearchButton = new Button(Driver, By.XPath("//button[text() = 'Search']"));
            ResetSearchButton = new Button(Driver, By.XPath("//button[text() = 'Reset Search']"));
            SetAllToReviewCompleteButton = new Button(Driver, By.CssSelector("#searchResults > tfoot > tr > td > div > label:nth-child(1)"));
            SetAllToPendingProcessingButton = new Button(Driver, By.CssSelector("#searchResults > tfoot > tr > td > div > label:nth-child(2)"));
            UpdateButton = new Button(Driver, By.XPath("//button[text() = 'Update']"));
            YesButton = new Button(Driver, By.XPath("//button[text() = 'Yes']"));
            NoButton = new Button(Driver, By.XPath("//button[text() = 'No']"));
        }
    }
}
