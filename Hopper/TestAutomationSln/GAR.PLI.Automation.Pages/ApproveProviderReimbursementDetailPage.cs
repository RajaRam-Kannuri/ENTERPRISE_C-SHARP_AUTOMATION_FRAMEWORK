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
    public class ApproveProviderReimbursementDetailPage : AccountActivityPage
    {
        public Radio ApproveInvoice { get; private set; }
        public Radio DenyInvoice { get; private set; }
        public EditField RejectionReason { get; private set; }
        public Button Submit { get; private set; }
        public Text SuccessMessage { get; private set; }
        public ReimbursementLineItemsTable ReimbursementLineItemsTable { get; private set; }
        public Button PopupClickYes { get; private set; }
        public Button PopupClickNo { get; private set; }

        public ApproveProviderReimbursementDetailPage(IWebDriver driver)
            : base(driver)
        {
            ApproveInvoice = new Radio(Driver, By.CssSelector("input[id$=\"rblApprove_0\"]"));
            DenyInvoice = new Radio(Driver, By.CssSelector("input[id$=\"rblApprove_1\"]"));
            RejectionReason = new EditField(Driver, By.CssSelector("input[id$=\"txtRejectionReason\"]"));
            Submit = new Button(Driver, By.CssSelector("input[id$=\"btnSubmit\"]"));
            SuccessMessage = new Text(Driver, By.CssSelector("span[id$=\"lblResults\"]"));
            ReimbursementLineItemsTable = new ReimbursementLineItemsTable(Driver, By.XPath("//*[@id='RPMainPanel_controls_guardianlogin_claims_approveproviderclaimdetail_ascx423_plTnFReimbursement']/table[2]"));
            PopupClickYes = new Button(Driver, By.CssSelector("input[id$=\"btnYes\"]"));
            PopupClickNo = new Button(Driver, By.CssSelector("input[id$=\"btnNo\"]"));
        }
    }
}
