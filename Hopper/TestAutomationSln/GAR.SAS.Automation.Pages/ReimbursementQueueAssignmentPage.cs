using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class ReimbursementQueueAssignmentPage : HomePage
    {
        public Dropdown Processor { get; private set; }

        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public Checkbox ImmediateAssignment { get; private set; }

        public Dropdown Priority { get; private set; }

        public Button SaveQueues { get; private set; }

        public Text TodaysAssignmentsLabel { get; private set; }

        public new Table TodaysAssignments { get; private set; }

        public Table ExistingAssignments { get; private set; }

        public EditField ReimbursementIDPriority1 { get; private set; }

        public EditField ReimbursementCountPriority1 { get; private set; }

        public Dropdown StatusPriority1 { get; private set; }

        public Dropdown TypePriority1 { get; private set; }

        public Dropdown YearPriority1 { get; private set; }

        public Dropdown ReimbursementCategoryPriority1 { get; private set; }

        public Dropdown PayeePriority1 { get; private set; }

        public Dropdown ApprovedProviderPriority1 { get; private set; }

        public Dropdown ProviderTypePriority1 { get; private set; }

        public Dropdown LanguagePriority1 { get; private set; }

        public Dropdown AssignmentOrderPriority1 { get; private set; }

        public EditField ReimbursementIDPriority2 { get; private set; }

        public EditField ReimbursementCountPriority2 { get; private set; }

        public Dropdown StatusPriority2 { get; private set; }

        public Dropdown TypePriority2 { get; private set; }

        public Dropdown YearPriority2 { get; private set; }

        public Dropdown ReimbursementCategoryPriority2 { get; private set; }

        public Dropdown PayeePriority2 { get; private set; }

        public Dropdown ApprovedProviderPriority2 { get; private set; }

        public Dropdown ProviderTypePriority2 { get; private set; }

        public Dropdown LanguagePriority2 { get; private set; }

        public Dropdown AssignmentOrderPriority2 { get; private set; }

        public EditField ReimbursementIDPriority3 { get; private set; }

        public EditField ReimbursementCountPriority3 { get; private set; }

        public Dropdown StatusPriority3 { get; private set; }

        public Dropdown TypePriority3 { get; private set; }

        public Dropdown YearPriority3 { get; private set; }

        public Dropdown ReimbursementCategoryPriority3 { get; private set; }

        public Dropdown PayeePriority3 { get; private set; }

        public Dropdown ApprovedProviderPriority3 { get; private set; }

        public Dropdown ProviderTypePriority3 { get; private set; }

        public Dropdown LanguagePriority3 { get; private set; }

        public Dropdown AssignmentOrderPriority3 { get; private set; }

        public GARReimbursementQueueTable TodaysAssignmentsTable { get; private set; }

        public GARReimbursementQueueTable ExistingAssignmentsTable { get; private set; }

        public Button RemoveAllButton { get; private set; }

        public ReimbursementQueueAssignmentPage(IWebDriver driver)
            : base(driver)
        {
            Processor = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlProcessors\"]"));
            StartDate = new EditField(Driver, By.CssSelector("input[id$=\"tbStartDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[id$=\"tbEndDate\"]"));
            ImmediateAssignment = new Checkbox(Driver, By.CssSelector("input[id$=\"cbAssignImmediately\"]"));
            Priority = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPriority\"]"));
            SaveQueues = new Button(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_btnSaveQueues"));
            TodaysAssignments = new Table(Driver, By.CssSelector("table[id$=\"gvAssignedApplications\"]"));
            ExistingAssignments = new Table(Driver, By.CssSelector("table[id$=\"gvExistingQueueAssignments\"]"));
            TodaysAssignmentsLabel = new Text(Driver, By.CssSelector("span[id$=\"lblTodaysAssignments\"]"));
            ReimbursementIDPriority1 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_tbApplicationID"));
            ReimbursementCountPriority1 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_tbClaimCount"));
            StatusPriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlClaimStatus"));
            TypePriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlClaimType"));
            YearPriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlOrgYear"));
            ReimbursementCategoryPriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlCategory"));
            PayeePriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlPayType"));
            ApprovedProviderPriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlApprovedProvider"));
            ProviderTypePriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlProviderType"));
            LanguagePriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlApplicationLanguage"));
            AssignmentOrderPriority1 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl00_PriorityAssignment_ddlAssignmentOrder"));
            ReimbursementIDPriority2 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_tbApplicationID"));
            ReimbursementCountPriority2 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_tbClaimCount"));
            StatusPriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlClaimStatus"));
            TypePriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlClaimType"));
            YearPriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlOrgYear"));
            ReimbursementCategoryPriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlCategory"));
            PayeePriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlPayType"));
            ApprovedProviderPriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlApprovedProvider"));
            ProviderTypePriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlProviderType"));
            LanguagePriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlApplicationLanguage"));
            AssignmentOrderPriority2 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl02_PriorityAssignment_ddlAssignmentOrder"));
            ReimbursementIDPriority3 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_tbApplicationID"));
            ReimbursementCountPriority3 = new EditField(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_tbClaimCount"));
            StatusPriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlClaimStatus"));
            TypePriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlClaimType"));
            YearPriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlOrgYear"));
            ReimbursementCategoryPriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlCategory"));
            PayeePriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlPayType"));
            ApprovedProviderPriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlApprovedProvider"));
            ProviderTypePriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlProviderType"));
            LanguagePriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlApplicationLanguage"));
            AssignmentOrderPriority3 = new Dropdown(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_rptPriority_ctl04_PriorityAssignment_ddlAssignmentOrder"));
            TodaysAssignmentsTable = new GARReimbursementQueueTable(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_CurrentClaimAssignments_gvAssignedClaims"));
            ExistingAssignmentsTable = new GARReimbursementQueueTable(Driver, By.CssSelector("#controls_claims_claimassignment_queueassignment_ascx441_CurrentQueueAssignments_gvExistingQueueAssignments"));
            RemoveAllButton = new Button(Driver, By.CssSelector("input[id$=\"imbBtnRemoveAll\"]"));
        }
    }
}
