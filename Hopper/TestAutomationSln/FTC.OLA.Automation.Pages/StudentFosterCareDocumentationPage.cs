using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentFosterCareDocumentationPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown DropDown1 { get; private set; }
        public OLAWorkflowDropdown2 DropDown2 { get; private set; }
        public DocUploadButton UploadButton1 { get; private set; }
        public DocUploadButton UploadButton2 { get; private set; }
        public Button DeleteDocUpload1 { get; private set; }
        public Button DeleteDocUpload2 { get; private set; }

        public StudentFosterCareDocumentationPage(IWebDriver driver)
            : base(driver)
        {
            DropDown1 = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            DropDown2 = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            UploadButton1 = new DocUploadButton(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > student-foster-upload-container > standard-doc-upload > div > div > doc-upload > div > div > div:nth-child(2) > div.col.l10.offset-l2.m9.offset-m3.s12.center-align > a > span"));
            UploadButton2 = new DocUploadButton(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > student-foster-upload-container > standard-doc-upload > div > div > doc-upload > div > div > div:nth-child(3) > div.col.l10.offset-l2.m9.offset-m3.s12.center-align > a > span"));
            DeleteDocUpload1 = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > student-foster-upload-old > question-card > div.container > div > div > div > div.card-content > div.question-card-body > div > div > doc-upload > div > div > div:nth-child(2) > div.col.l10.offset-l2.m9.offset-m3.s12.doc-container > div > div.col.s12.m6.ng-star-inserted > div > div:nth-child(2) > div > a"));
            DeleteDocUpload2 = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > student-foster-upload-old > question-card > div.container > div > div > div > div.card-content > div.question-card-body > div > div > doc-upload > div > div > div:nth-child(3) > div.col.l10.offset-l2.m9.offset-m3.s12.doc-container > div > div.col.s12.m6.ng-star-inserted > div > div:nth-child(2) > div > a"));
        }
    }
}
