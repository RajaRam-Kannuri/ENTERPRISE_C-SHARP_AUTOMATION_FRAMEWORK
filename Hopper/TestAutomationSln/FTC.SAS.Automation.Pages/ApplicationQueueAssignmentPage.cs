using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class ApplicationQueueAssignmentPage : HomePage
    {
        public Dropdown Processor { get; private set; }

        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public Checkbox ImmediateAssignment { get; private set; }

        public Dropdown Priority { get; private set; }

        public Button SaveQueues { get; private set; }

        public Text TodaysAssignmentsLabel { get; private set; }

        public Table TodaysAssignments { get; private set; }

        public Table ExistingAssignments { get; private set; }

        public EditField ApplicationIDPriority1 { get; private set; }

        public EditField ApplicationCountPriority1 { get; private set; }

        public Dropdown StatusPriority1 { get; private set; }

        public Dropdown TypePriority1 { get; private set; }

        public Dropdown StudentTypePriority1 { get; private set; }

        public Checkbox ThreeYearOldPriority1 { get; private set; }

        public Checkbox FourYearOldPriority1 { get; private set; }

        public Checkbox KindergartenPriority1 { get; private set; }

        public Checkbox FirstGradePriority1 { get; private set; }

        public Checkbox SecondGradePriority1 { get; private set; }

        public Checkbox ThirdGradePriority1 { get; private set; }

        public Checkbox FourthGradePriority1 { get; private set; }

        public Checkbox FifthGradePriority1 { get; private set; }

        public Checkbox SixthGradePriority1 { get; private set; }

        public Checkbox SeventhGradePriority1 { get; private set; }

        public Checkbox EighthGradePriority1 { get; private set; }

        public Checkbox NinthGradePriority1 { get; private set; }

        public Checkbox TenthGradePriority1 { get; private set; }

        public Checkbox EleventhGradePriority1 { get; private set; }

        public Checkbox TwelfthGradePriority1 { get; private set; }

        public Dropdown LanguagePriority1 { get; private set; }

        public Dropdown YearPriority1 { get; private set; }

        public Checkbox AssignAppealPriority1 { get; private set; }

        public Checkbox AssignWaitlistPriority1 { get; private set; }

        public Dropdown BusinessSEIncomePriority1 { get; private set; }

        public Dropdown DirectCertificationHHPriority1 { get; private set; }

        public Dropdown SNAPTANFFDPIRHHPriority1 { get; private set; }

        public Dropdown MilitaryPriority1 { get; private set; }

        public Dropdown LEOPriority1 { get; private set; }

        public Dropdown SeasonalPriority1 { get; private set; }

        public Dropdown FosterPriority1 { get; private set; }

        public Dropdown OutOfHomePriority1 { get; private set; }

        public Dropdown DuplicateStudentsPriority1Dropdown { get; private set; }

        public EditField ApplicationIDPriority2 { get; private set; }

        public EditField ApplicationCountPriority2 { get; private set; }

        public Dropdown StatusPriority2 { get; private set; }

        public Dropdown TypePriority2 { get; private set; }

        public Dropdown StudentTypePriority2 { get; private set; }

        public Checkbox ThreeYearOldPriority2 { get; private set; }

        public Checkbox FourYearOldPriority2 { get; private set; }

        public Checkbox KindergartenPriority2 { get; private set; }

        public Checkbox FirstGradePriority2 { get; private set; }

        public Checkbox SecondGradePriority2 { get; private set; }

        public Checkbox ThirdGradePriority2 { get; private set; }

        public Checkbox FourthGradePriority2 { get; private set; }

        public Checkbox FifthGradePriority2 { get; private set; }

        public Checkbox SixthGradePriority2 { get; private set; }

        public Checkbox SeventhGradePriority2 { get; private set; }

        public Checkbox EighthGradePriority2 { get; private set; }

        public Checkbox NinthGradePriority2 { get; private set; }

        public Checkbox TenthGradePriority2 { get; private set; }

        public Checkbox EleventhGradePriority2 { get; private set; }

        public Checkbox TwelfthGradePriority2 { get; private set; }

        public Dropdown LanguagePriority2 { get; private set; }

        public Dropdown YearPriority2 { get; private set; }

        public Checkbox AssignAppealPriority2 { get; private set; }

        public Checkbox AssignWaitlistPriority2 { get; private set; }

        public Dropdown BusinessSEIncomePriority2 { get; private set; }

        public Dropdown DirectCertificationHHPriority2 { get; private set; }

        public Dropdown SNAPTANFFDPIRHHPriority2 { get; private set; }

        public Dropdown MilitaryPriority2 { get; private set; }

        public Dropdown LEOPriority2 { get; private set; }
        
        public Dropdown SeasonalPriority2 { get; private set; }

        public Dropdown FosterPriority2 { get; private set; }

        public Dropdown OutOfHomePriority2 { get; private set; }

        public Dropdown DuplicateStudentsPriority2Dropdown { get; private set; }

        public Button RemoveAllButton { get; private set; }
        
        public ApplicationQueueAssignmentPage(IWebDriver driver)
            : base(driver)
        {
            Processor = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlProcessors\"]"));
            StartDate = new EditField(Driver, By.CssSelector("input[id$=\"tbStartDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[id$=\"tbEndDate\"]"));
            ImmediateAssignment = new Checkbox(Driver, By.CssSelector("input[id$=\"cbAssignImmediately\"]"));
            Priority = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPriority\"]"));
            SaveQueues = new Button(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_Table1 > tbody > tr:nth-child(4) > td:nth-child(2) > div > button"));
            TodaysAssignments = new Table(Driver, By.CssSelector("table[id$=\"gvAssignedApplications\"]"));
            ExistingAssignments = new Table(Driver, By.CssSelector("table[id$=\"gvExistingQueueAssignments\"]"));
            TodaysAssignmentsLabel = new Text(Driver, By.CssSelector("span[id$=\"lblTodaysAssignments\"]"));
            ApplicationIDPriority1 = new EditField(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_tbApplicationID"));
            ApplicationCountPriority1 = new EditField(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_tbApplicationCount"));
            StatusPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlApplicationStatus"));
            TypePriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlApplicationType"));
            StudentTypePriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlStudentType"));
            ThreeYearOldPriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbThreeYearOld"));
            FourYearOldPriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbFourYearOld"));
            KindergartenPriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbKindergarten"));
            FirstGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbFirst"));
            SecondGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbSecond"));
            ThirdGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbThird"));
            FourthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbFourth"));
            FifthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbFifth"));
            SixthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbSixth"));
            SeventhGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbSeventh"));
            EighthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbEighth"));
            NinthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbNinth"));
            TenthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbTenth"));
            EleventhGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbEleventh"));
            TwelfthGradePriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbTwelfth"));
            LanguagePriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlApplicationLanguage"));
            YearPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlOrgYear"));
            AssignAppealPriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbAppeal"));
            AssignWaitlistPriority1 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_cbWaitList"));
            BusinessSEIncomePriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlBusinessIncome"));
            DirectCertificationHHPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlDirectCert"));
            SNAPTANFFDPIRHHPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlSnapTanf"));
            MilitaryPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlMilitary"));
            LEOPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlLEO"));
            SeasonalPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlSeasonal"));
            FosterPriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlFoster"));
            OutOfHomePriority1 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlOutOfHome"));
            ApplicationIDPriority2 = new EditField(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_tbApplicationID"));
            ApplicationCountPriority2 = new EditField(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_tbApplicationCount"));
            StatusPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlApplicationStatus"));
            TypePriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlApplicationType"));
            StudentTypePriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlStudentType"));
            ThreeYearOldPriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbThreeYearOld"));
            FourYearOldPriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbFourYearOld"));
            KindergartenPriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbKindergarten"));
            FirstGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbFirst"));
            SecondGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbSecond"));
            ThirdGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbThird"));
            FourthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbFourth"));
            FifthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbFifth"));
            SixthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbSixth"));
            SeventhGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbSeventh"));
            EighthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbEighth"));
            NinthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbNinth"));
            TenthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbTenth"));
            EleventhGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbEleventh"));
            TwelfthGradePriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbTwelfth"));
            LanguagePriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlApplicationLanguage"));
            YearPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlOrgYear"));
            AssignAppealPriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbAppeal"));
            AssignWaitlistPriority2 = new Checkbox(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_cbWaitList"));
            BusinessSEIncomePriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlBusinessIncome"));
            DirectCertificationHHPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlDirectCert"));
            SNAPTANFFDPIRHHPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlSnapTanf"));
            MilitaryPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlMilitary"));
            LEOPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlLEO"));
            SeasonalPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlSeasonal"));
            FosterPriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlFoster"));
            OutOfHomePriority2 = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlOutOfHome"));
            DuplicateStudentsPriority1Dropdown = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl00_PriorityAssignment_ddlDuplicateStudents"));
            DuplicateStudentsPriority2Dropdown = new Dropdown(Driver, By.CssSelector("#controls_applicationassignment_queueassignment_ascx143_rptPriority_ctl02_PriorityAssignment_ddlDuplicateStudents"));
            RemoveAllButton = new Button(Driver, By.CssSelector("input[id$=\"imbBtnRemoveAll\"]"));
        }
    }
}
