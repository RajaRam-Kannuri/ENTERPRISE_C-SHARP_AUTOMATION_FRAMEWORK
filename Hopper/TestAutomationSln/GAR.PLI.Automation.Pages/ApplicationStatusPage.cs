using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class ApplicationStatusPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Text ApplicationId { get; private set; }

        public ScholarshipChildrenStatusTable ScholarshipChildrenStatusTable { get; private set; }

        public Modal ConfirmationModal { get; private set; }

        public Button ConfirmModalButton { get; private set; }

        public Button CancelModalButton { get; private set; }

        public Button ModalOKButton { get; private set; }

        public Text ModalMessage { get; private set; }

        public GARPLIOnHoldReasonsTable OnHoldReasonsTable { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Button RequestMatrixReviewButton { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Button EligibilityLetterButton { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            ScholarshipChildrenStatusTable = new ScholarshipChildrenStatusTable(Driver, By.CssSelector("table[id$=\"ScholarshipChildrenStatus_DLStudents\"]"));
            ConfirmationModal = new Modal(Driver, By.CssSelector("div[id$=\"ScholarshipChildrenStatus_ASPxModalPopupConfirm_PW-1\"]"));
            ConfirmModalButton = new Button(Driver, By.CssSelector("input[id$=\"ScholarshipChildrenStatus_ASPxModalPopupConfirm_btnConfirm\"]"));
            CancelModalButton = new Button(Driver, By.CssSelector("input[id$=\"ScholarshipChildrenStatus_ASPxModalPopupConfirm_btnCancel\"]"));
            ModalOKButton = new Button(Driver, By.CssSelector("input[id$=\"ScholarshipChildrenStatus_ASPxPopupModalResult_btnOK\"]"));
            ModalMessage = new Text(Driver, By.CssSelector("span[id$=\"ScholarshipChildrenStatus_ASPxPopupModalResult_lblResult\"]"));
            RequestMatrixReviewButton = new Button(Driver, By.CssSelector("input[id$=\"requestMatrixReview\"]"));
            EligibilityLetterButton = new Button(Driver, By.CssSelector("input[id$=\"btnPrintLetter\"]"));
            OnHoldReasonsTable = new GARPLIOnHoldReasonsTable(Driver, By.CssSelector("div[id$=\"RPMainPanel_controls_guardianlogin_applicationstatus_ascx128_divOnholdHouseHoldMembers\"]"));
        }
    }
}
