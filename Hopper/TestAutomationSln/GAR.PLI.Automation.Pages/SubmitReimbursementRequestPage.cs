using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class SubmitReimbursementRequestPage : AccountActivityPage
    {
        public Dropdown StudentList { get; private set; }

        public Text StudentName { get; private set; }

        public Text StudentId { get; private set; }

        public Dropdown PreAuthorizationId { get; private set; }

        public Dropdown SelectProvider { get; private set; }

        public EditField ProviderTypeAheadTextField { get; private set; }

        public CustomDropdown ProviderTypeAheadList { get; private set; }

        public EditField ProviderName { get; private set; }

        public EditField ProviderLicense { get; private set; }

        public Dropdown PayTo { get; private set; }

        public EditField InvoiceNumber { get; private set; }

        public EditField InvoiceDate { get; private set; }

        public EditField TotalInvoiceAmount { get; private set; }

        public DropdownWithAlert ReimbursementCategory { get; private set; }

        public Dropdown ReimbursementType { get; private set; }

        public Dropdown ReimbursementDetail { get; private set; }

        public EditField LineItemDescription { get; private set; }

        public EditField ItemAmount { get; private set; }

        public EditField TaxRateAmount { get; private set; }

        public EditField LineItemTotalAmount { get; private set; }

        public Button SaveThisItemButton { get; private set; }

        public Table LineItemsTable { get; private set; }

        public Checkbox CertificationStatement { get; private set; }

        public Button CancelButton { get; private set; }

        public BlockedButton SubmitButton { get; private set; }

        public Text IneligibleAccountMessage { get; private set; }

        public Text SuccessMessage { get; private set; }

        public Text LowBalanceErrorMessage { get; private set; }

        public ReimbursementID ReimbursementID { get; private set; }

        public DocUploadButton ChooseFile { get; private set; }

        public Button UploadDocuments { get; private set; }

        public EditField TandFAnnualTuition { get; private set; }

        public EditField TandFAnnualBooks { get; private set; }

        public EditField TandFAnnualRegistration { get; private set; }

        public EditField TandFAnnualTesting { get; private set; }

        public EditField TandFAnnualTransportation { get; private set; }

        public EditField TandFAnnualUniforms { get; private set; }

        public EditField TandFAnnualTutoring { get; private set; }

        public EditField TandFAnnualCapitalCampaign { get; private set; }

        public EditField TandFAnnualOther { get; private set; }

        public EditField TandFAnnualSpecifyOtherTextBox { get; private set; }
        
        public EditField TandFInvoiceTuition { get; private set; }

        public EditField TandFInvoiceBooks { get; private set; }

        public EditField TandFInvoiceRegistration { get; private set; }

        public EditField TandFInvoiceTesting { get; private set; }

        public EditField TandFInvoiceTransportation { get; private set; }

        public EditField TandFInvoiceUniforms { get; private set; }

        public EditField TandFInvoiceTutoring { get; private set; }

        public EditField TandFInvoiceCapitalCampaign { get; private set; }

        public EditField TandFInvoiceOther { get; private set; }

        public EditField TandFRegistrationDescription { get; private set; }

        public EditField TandFTransportationDescription { get; private set; }

        public EditField TandFBooksDescription { get; private set; }

        public EditField TandFTestingDescription { get; private set; }

        public EditField TandFUniformsDescription { get; private set; }

        public EditField TandFTutoringDescription { get; private set; }

        public EditField TandFCapitalCampaignDescription { get; private set; }

        public EditField TandFCapitalOtherDescription { get; private set; }

        public Button TandFPopupOK { get; private set; }

        public Checkbox Quarter1Checkbox { get; private set; }

        public Checkbox Quarter2Checkbox { get; private set; }

        public Checkbox Quarter3Checkbox { get; private set; }

        public Checkbox Quarter4Checkbox { get; private set; }

        public Text StudentEligibilityStatusMessage { get; private set; } 

        public SubmitReimbursementRequestPage(IWebDriver driver)
            : base(driver)
        {
            StudentList = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"lblStudentValue\"]"));
            StudentId = new Text(Driver, By.CssSelector("span[id$=\"lblStudentIDValue\"]"));
            PreAuthorizationId = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPreAuthCode\"]"));
            SelectProvider = new Dropdown(Driver, By.CssSelector("span[id$=\"ddlProvider-container\"]"));
            ProviderTypeAheadTextField = new EditField(Driver, By.CssSelector(".select2-search__field"));
            //ProviderTypeAheadList = new Dropdown(Driver, By.CssSelector("ul[id$=\"ddlProvider-results\"]"));
            ProviderTypeAheadList = new CustomDropdown(Driver, By.CssSelector("ul[id$=\"ddlProvider-results\"]"));
            ProviderName = new EditField(Driver, By.CssSelector("input[id$=\"tbProviderName\"]"));
            ProviderLicense = new EditField(Driver, By.CssSelector("input[id$=\"tbProviderLicense\"]"));
            PayTo = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPayee\"]"));
            InvoiceNumber = new EditField(Driver, By.CssSelector("input[id$=\"tbInvoiceNumber\"]"));
            InvoiceDate = new EditField(Driver, By.CssSelector("input[id$=\"tbInvoiceDate\"]"));
            TotalInvoiceAmount = new EditField(Driver, By.CssSelector("span[id$=\"TotalAmountValue\"]"));
            //LineItemCategory = new Dropdown(Driver, By.XPath("//select[@id='RPMainPanel_controls_providerlogin_submitclaim']"));
            //SuffixSelectOption = new CustomDropdown(Driver, By.XPath("//*[contains(@id, 'select-options-')]"));
            //*[@id="RPMainPanel_controls_providerlogin_submitclaim_ascx448_sctrlAddClaimItem_ddlItemCategory"]
            ReimbursementCategory = new DropdownWithAlert(Driver, By.CssSelector("select[id$=\"ddlItemCategory\"]"));
            ReimbursementType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlItemType\"]"));
            ReimbursementDetail = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlItemDetail\"]"));
            LineItemDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"tbItemDescription\"]"));
            ItemAmount = new EditField(Driver, By.CssSelector("input[id$=\"tbItemAmount\"]"));
            TaxRateAmount = new EditField(Driver, By.CssSelector("input[id$=\"tbTaxRateAmount\"]"));
            LineItemTotalAmount = new EditField(Driver, By.CssSelector("span[id$=\"lblLineItemTotal\"]"));
            SaveThisItemButton = new Button(Driver, By.CssSelector("input[id$=\"btnAdd\"]"));
            LineItemsTable = new Table(Driver, By.Id("tblClaimItems"));
            CertificationStatement = new Checkbox(Driver, By.CssSelector("input[id$=\"chkCertification\"]"));
            CancelButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancel\"]"));
            //SubmitButton = new Button(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            //IneligibleAccountMessage = new Text(Driver, By.CssSelector("div[id$=\"divIneligibleAccount\"]"));
            //SuccessMessage = new Text(Driver, By.CssSelector("div[id$=\"divPostClaim\"]"));
            SubmitButton = new BlockedButton(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            IneligibleAccountMessage = new Text(Driver, By.CssSelector("div[id$=\"divIneligibleAccount\"]"));
            SuccessMessage = new Text(Driver, By.CssSelector("div[id$=\"divPostClaim\"]"));
            LowBalanceErrorMessage = new Text(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_claims_submitclaim_ascx414_vsSubmitClaim > ul > li"));
            ReimbursementID = new ReimbursementID(Driver, By.CssSelector("div[id$=\"divInfo\"]"));
            ChooseFile = new DocUploadButton(Driver, By.CssSelector("input[id$=\"FileUploadControl\"]"));
            UploadDocuments = new Button(Driver, By.CssSelector("input[id$=\"btnUpload\"]"));
            TandFAnnualTuition = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualTuition\"]"));
            TandFAnnualBooks = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualBooks\"]"));
            TandFAnnualRegistration = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualRegistration\"]"));
            TandFAnnualTesting = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualTesting\"]"));
            TandFAnnualTransportation = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualTransportation\"]"));
            TandFAnnualUniforms = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualUniforms\"]"));
            TandFAnnualTutoring = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualTutoring\"]"));
            TandFAnnualCapitalCampaign = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualCapitalCampaign\"]"));
            TandFAnnualOther = new EditField(Driver, By.CssSelector("input[id$=\"tbxAnnualOther\"]"));
            TandFAnnualSpecifyOtherTextBox = new EditField(Driver, By.CssSelector("textarea[id$=\"tbxAnnualDescribeOther\"]"));
            TandFInvoiceTuition = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceTuition\"]"));
            TandFInvoiceBooks = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceBooks\"]"));
            TandFInvoiceRegistration = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceRegistration\"]"));
            TandFInvoiceTesting = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceTesting\"]"));
            TandFInvoiceTransportation = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceTransportation\"]"));
            TandFInvoiceUniforms = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceUniforms\"]"));
            TandFInvoiceTutoring = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceTutoring\"]"));
            TandFInvoiceCapitalCampaign = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceCapitalCampaign\"]"));
            TandFInvoiceOther = new EditField(Driver, By.CssSelector("input[id$=\"tbxInvoiceOther\"]"));
            TandFRegistrationDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceRegistrationDescription\"]"));
            TandFTransportationDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceTransportationDescription\"]"));
            TandFBooksDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceBooksDescription\"]"));
            TandFTestingDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceTestingDescription\"]"));
            TandFUniformsDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceUniformsDescription\"]"));
            TandFTutoringDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceTutoringDescription\"]"));
            TandFCapitalCampaignDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceCapital CampaignDescription\"]"));
            TandFCapitalOtherDescription = new EditField(Driver, By.CssSelector("textarea[id$=\"invoiceOtherDescription\"]"));
            TandFPopupOK = new Button(Driver, By.CssSelector("body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button > span"));
            Quarter1Checkbox = new Checkbox(Driver, By.CssSelector("input[id$=\"chkQuarterOne\"]"));
            Quarter2Checkbox = new Checkbox(Driver, By.CssSelector("input[id$=\"chkQuarterTwo\"]"));
            Quarter3Checkbox = new Checkbox(Driver, By.CssSelector("input[id$=\"chkQuarterThree\"]"));
            Quarter4Checkbox = new Checkbox(Driver, By.CssSelector("input[id$=\"chkQuarterFour\"]"));
            StudentEligibilityStatusMessage = new Text(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_claims_submitclaim_ascx414_lblStudentClaimEligibilityStatus"));
        }
    }
}
