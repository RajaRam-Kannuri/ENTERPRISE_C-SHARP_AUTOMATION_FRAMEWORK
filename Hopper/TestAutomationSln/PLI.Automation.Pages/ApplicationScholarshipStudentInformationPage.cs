using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationScholarshipStudentInformationPage : ApplicationWizardPage
    {
        public StudentInformationSection StudentInformation { get; private set; }

        public Modal NotificationModal { get; private set; }

        public Button ModalYes { get; private set; }

        public Button ModalNo { get; private set; }

        public ApplicationScholarshipStudentInformationPage(IWebDriver driver)
            : base(driver)
        {
            StudentInformation = new StudentInformationSection(Driver);
            NotificationModal = new Modal(Driver, By.Id("ValidationResultModalPopupControl_PW-1"));
            ModalYes = new Button(Driver, By.Id("ValidationResultModalPopupControl_btnResponseChoiceYes"));
            ModalNo = new Button(Driver, By.Id("ValidationResultModalPopupControl_btnResponseChoiceNo"));
        }
    }
}
