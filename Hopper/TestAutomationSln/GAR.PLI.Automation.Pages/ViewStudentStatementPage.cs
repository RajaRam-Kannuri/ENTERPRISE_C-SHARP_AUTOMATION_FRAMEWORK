using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class ViewStudentStatementPage : AccountActivityPage
    {
        public WebElement StudentList { get; private set; }

        public WebElement StudentName { get; private set; }

        public Text StudentId { get; private set; }

        public WebElement ScholarshipsList { get; private set; }

        public WebElement TotalFundsAwarded { get; private set; }

        public WebElement TotalScholarshipFundsActivity { get; private set; }

        public WebElement TotalFundsAvailableForReimbursement { get; private set; }

        public Dropdown ReimbursementActivityYear { get; private set; }

        public WebElement InProcessTab { get; private set; }

        public WebElement PendingPaymentTab { get; private set; }

        public WebElement PaidTab { get; private set; }

        public WebElement DeclinedTab { get; private set; }

        public WebElement PreAuthorizationRequestTab { get; private set; }

        public WebElement InProcessTabContents { get; private set; }

        public WebElement OnlyShowActionRequiredReimbursements { get; private set; }

        public WebElement TotalScholarshipFundsPendingProcessing { get; private set; }

        public WebElement PendingPaymentTabContents { get; private set; }

        public WebElement TotalScholarshipFundsPendingPayment { get; private set; }

        public WebElement PaidTabContents { get; private set; }

        public WebElement TotalScholarshipFundsPaid { get; private set; }

        public WebElement DeniedTabContents { get; private set; }

        public WebElement PreAuthorizationRequestTabContents { get; private set; }

        public WebElement ReimbursementDetailsModal { get; private set; }

        public WebElement ModalGeneralInfo { get; private set; }

        public WebElement ModalReimbursementID { get; private set; }

        public WebElement ModalReimursementSubmissionDate { get; private set; }

        public WebElement ModalReimursementStatus { get; private set; }

        public WebElement ModalStudentName { get; private set; }

        public WebElement ModalStudentID { get; private set; }

        public WebElement ModalProviderName { get; private set; }

        public Table ModalNotForPreAuth { get; private set; }

        public WebElement ModalPayTo { get; private set; }

        public WebElement ModalInvoiceNumber { get; private set; }

        public WebElement ModalInvoiceDate { get; private set; }

        public WebElement ModalInvoiceAmount { get; private set; }

        public WebElement ModalDetailInfoReimbursementItems { get; private set; }

        public Table ModalDocuments { get; private set; }

        public WebElement ModalReturnToStatementButton { get; private set; }

        public EditField InProcessSearchWithinResults { get; private set; }

        public EditField PendingPaymentSearchWithinResults { get; private set; }

        public EditField DeclinedSearchWithinResults { get; private set; }

        public ReimbursementTable InProcessTable { get; private set; }

        public ReimbursementTable PendingPaymentTable { get; private set; }

        public ReimbursementTable DeclinedTable { get; private set; }

        public ReimbursementDetailsModalPLI ReimbursementDetailsDenialReason { get; private set; }

        public ReimbursementDetailsModalPLI ReimbursementDetailsItemStatus { get; private set; }

        public ViewStudentStatementPage(IWebDriver driver)
            : base(driver)
        {
            StudentList = new WebElement(Driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            StudentName = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblstudentName\"]"));
            StudentId = new Text(Driver, By.Id("RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_lblStudentID"));
            ScholarshipsList = new WebElement(Driver, By.CssSelector(""));
            TotalFundsAwarded = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblAwardActivity\"]"));
            TotalScholarshipFundsActivity = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblTotalFundsAvailable\"]"));
            TotalFundsAvailableForReimbursement = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"ddlOrganizationYear\"]"));
            ReimbursementActivityYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlOrganizationYear\"]"));
            InProcessTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T0T\"]"));
            PendingPaymentTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T1T\"]"));
            PaidTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T2T\"]"));
            DeclinedTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T3T\"]"));
            PreAuthorizationRequestTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T4T\"]"));
            InProcessTabContents = new WebElement(Driver, By.CssSelector("div[id$=\"claimsTabPage_C0\"]"));
            OnlyShowActionRequiredReimbursements = new WebElement(Driver, By.CssSelector("input[id*=\"viewstudentstatement\"][id$=\"chkActionRequired\"]"));
            TotalScholarshipFundsPendingProcessing = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblPendingProcessing\"]"));
            PendingPaymentTabContents = new WebElement(Driver, By.CssSelector("div[id$=\"claimsTabPage_C1\"]"));
            TotalScholarshipFundsPendingPayment = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblPendingPayment\"]"));
            PaidTabContents = new WebElement(Driver, By.CssSelector("div[id$=\"claimsTabPage_C2\"]"));
            TotalScholarshipFundsPaid = new WebElement(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblPaid\"]"));
            DeniedTabContents = new WebElement(Driver, By.CssSelector("div[id$=\"claimsTabPage_C3\"]"));
            PreAuthorizationRequestTabContents = new WebElement(Driver, By.CssSelector("div[id$=\"claimsTabPage_C4\"]"));
            ReimbursementDetailsModal = new WebElement(Driver, By.Id("claimDetailDialog"));
            ModalGeneralInfo = new WebElement(Driver, By.Id("divGeneralInfo"));
            ModalReimbursementID = new WebElement(Driver, By.Id("tdReimbursementID"));
            ModalReimursementSubmissionDate = new WebElement(Driver, By.Id("tdReimursementSubmissionDate"));
            ModalReimursementStatus = new WebElement(Driver, By.Id("tdReimursementStatus"));
            ModalStudentName = new WebElement(Driver, By.Id("tdStudentName"));
            ModalStudentID = new WebElement(Driver, By.Id("tdStudentID"));
            ModalProviderName = new WebElement(Driver, By.Id("tdProviderName"));
            ModalNotForPreAuth = new Table(Driver, By.Id("tblNotForPreAuth"));
            ModalPayTo = new WebElement(Driver, By.Id("tdPayTo"));
            ModalInvoiceNumber = new WebElement(Driver, By.Id("tdInvoiceNumber"));
            ModalInvoiceDate = new WebElement(Driver, By.Id("tdInvoiceDate"));
            ModalInvoiceAmount = new WebElement(Driver, By.Id("tdInvoiceAmount"));
            ModalDetailInfoReimbursementItems = new WebElement(Driver, By.Id("divDetailInfoReimbursementItems"));
            //ModalReimbursementCategory = new WebElement(Driver, By.CssSelector(".reimbursementCategory"));
            //ModalReimbursementType = new WebElement(Driver, By.CssSelector(".reimbursementType"));
            //ModalReimbursementDetail = new WebElement(Driver, By.CssSelector(".reimbursementDetail"));
            //ModalReimbursementDescription = new WebElement(Driver, By.CssSelector(".reimbursementDescription"));
            //ModalReimbursementItemAmount = new WebElement(Driver, By.CssSelector(".reimbursementItemAmount"));
            //ModalReimbursementTaxRate = new WebElement(Driver, By.CssSelector(".reimbursementTaxRate"));
            //ModalReimbursementLineItemTotal = new WebElement(Driver, By.CssSelector(".reimbursementLineItemTotal"));
            //ModalReimbursementItemStatus = new WebElement(Driver, By.CssSelector(".reimbursementItemStatus"));
            ModalDocuments = new Table(Driver, By.Id("tblDocuments"));
            ModalReturnToStatementButton = new WebElement(Driver, By.CssSelector(".AppButton"));
            InProcessSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C0']/div/div[1]/div[2]/label/input"));
            PendingPaymentSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C1']/div/div[1]/div[2]/label/input"));
            DeclinedSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C3']/div/div[1]/div[2]/label/input"));
            InProcessTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C0 > div > table"));
            PendingPaymentTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C1 > div > table"));
            DeclinedTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_claims_viewstudentstatement_ascx412_claimsTabPage_C3 > div > table"));
            //ReimbursementDetailsItemStatus = new Text(Driver, By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset/table/tbody/tr[8]/td[2]"));
            //ReimbursementDetailsDenialReason = new ReimbursementDetailsModal(Driver, By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset/table/tbody/tr[9]/td[2]"));
            ReimbursementDetailsDenialReason = new ReimbursementDetailsModalPLI(Driver, By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset"));
            ReimbursementDetailsItemStatus = new ReimbursementDetailsModalPLI(Driver, By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset"));
        }
    }
}
