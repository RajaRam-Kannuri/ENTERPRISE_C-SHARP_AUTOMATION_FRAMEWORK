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
    public class StudentInformationPage : ApplicationWizardPage
    {
        public StudentInformationSection StudentInformation { get; private set; }

        public Modal NotificationModal { get; private set; }

        public Button ModalYes { get; private set; }

        public Button ModalNo { get; private set; }

        public Modal HighRiskUpdateModal { get; private set; }

        public Button HighRiskModalOk { get; set; }

        public StudentInformationPage(IWebDriver driver)
            : base(driver)
        {
            StudentInformation = new StudentInformationSection(Driver);
            NotificationModal = new Modal(Driver, By.Id("ValidationResultModalPopupControl_PW-1"));
            ModalYes = new Button(Driver, By.Id("ValidationResultModalPopupControl_btnResponseChoiceYes"));
            ModalNo = new Button(Driver, By.Id("ValidationResultModalPopupControl_btnResponseChoiceNo"));
            HighRiskUpdateModal = new Modal(Driver, By.Id("PLSAHighRiskNoticePopupControl_PW-1"));
            HighRiskModalOk = new Button(Driver, By.Id("PLSAHighRiskNoticePopupControl_btnContinue"));
        }
    }
}
