using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentOutOfHomeCareDocumentationPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown DropDown { get; private set; }
        public DocUploadButton UploadButton { get; private set; }
        public Button DeleteDocUpload { get; private set; }

        public StudentOutOfHomeCareDocumentationPage(IWebDriver driver)
            : base(driver)
        {
            DropDown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            UploadButton = new DocUploadButton(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > student-out-of-home-care-upload-container > standard-doc-upload > div > div > doc-upload > div > div > div > div.col.l10.offset-l2.m9.offset-m3.s12.center-align > a > span"));
            DeleteDocUpload = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > student-foster-upload-old > question-card > div.container > div > div > div > div.card-content > div.question-card-body > div > div > doc-upload > div > div > div:nth-child(2) > div.col.l10.offset-l2.m9.offset-m3.s12.doc-container > div > div.col.s12.m6.ng-star-inserted > div > div:nth-child(2) > div > a"));
        }
    }
}
