using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FoundationPrintAndSendDocumentsPage : FoundationWizardPage
    {
        public Dropdown SchoolYear { get; private set; }
        public Text ApplicationID { get; private set; }
        public Button InstructionsAndDocuments { get; private set; }
        public DocUploadButton ChooseFile { get; private set; }
        public Button UploadDocuments { get; private set; }

        public FoundationPrintAndSendDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"RPMainPanel_controls_guardianlogin_uploaddocuments_ascx352_ddlScholarshipApplicationYear\"]"));
            ApplicationID = new Text(Driver, By.CssSelector("span[id$=\"RPMainPanel_controls_guardianlogin_uploaddocuments_ascx352_lblApplicationIDValue\"]"));
            InstructionsAndDocuments = new Button(Driver, By.CssSelector("input[id$=\"RPMainPanel_controls_guardianlogin_uploaddocuments_ascx352_btnInstructions\"]"));
            ChooseFile = new DocUploadButton(Driver, By.XPath("//label[text() = 'Choose File']"));
            UploadDocuments = new Button(Driver, By.CssSelector("input[id$=\"RPMainPanel_controls_guardianlogin_uploaddocuments_ascx352_btnUpload\"]"));
        }
    }
}
