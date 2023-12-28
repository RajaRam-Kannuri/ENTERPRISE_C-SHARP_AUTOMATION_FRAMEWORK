using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentSummaryPage : ApplicationWizardPage
    {
        public Button StartStudentButton { get; private set; }
        public Button AddStudentButton { get; private set; }
        public Button ScholarshipButton { get; private set; }
        public Button ParentButton { get; private set; }
        public Button CloseTourPopup { get; private set; }
        public OLAStudentsTable NewStudentsTable { get; private set; }
        public OLAStudentsTable RenewalStudentsTable { get; private set; }
        public Button DeleteConfirm { get; private set; }
        public Button DeleteCancel { get; private set; }
        public Text StudentSchoolYearIsMissingInfoMessage { get; private set; }
        public Text StudentRelationshipIsMissingInfoMessage { get; private set; }
        public Text YouMustEnterAtLeastOneStudentMessage { get; private set; }

        public StudentSummaryPage(IWebDriver driver)
            : base(driver)
        {
            //AddStudentButton = new Button(Driver, By.XPath("//a[text() = ' Add ']"));
            AddStudentButton = new Button(Driver, By.XPath("//*[contains(text(), ' ADD ADDITIONAL STUDENT ')]"));
            ScholarshipButton = new Button(Driver, By.CssSelector("#question-next-button"));
            //ScholarshipButton = new Button(Driver, By.Id("question-next-button"));
            ParentButton = new Button(Driver, By.XPath("//span[text() = 'Parent']"));
            CloseTourPopup = new Button(Driver, By.XPath("//button[text() = 'Close']"));
            NewStudentsTable = new OLAStudentsTable(Driver, By.XPath("//*[contains(@class, 'new-student-section')]"));
            RenewalStudentsTable = new OLAStudentsTable(Driver, By.XPath("//*[contains(@class, 'renewal-student-section')]"));
            DeleteConfirm = new Button(Driver, By.XPath("//*[@id='deleteSecondaryModal']/div[2]/a[2]"));
            DeleteCancel = new Button(Driver, By.XPath("//a[text() = 'Cancel']"));
            StartStudentButton = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > student-summary-container > student-summary > div > div > div > p:nth-child(3) > a"));
            StudentSchoolYearIsMissingInfoMessage = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/student-ftc-school-year')]"));
            StudentRelationshipIsMissingInfoMessage = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/survey-relationship-to-parent')]"));
            YouMustEnterAtLeastOneStudentMessage = new Text(Driver, By.XPath("//*[contains(@href, 'student/student-new')]"));
        }
    }
}
