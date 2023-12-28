using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class HomePage : FTCPLIBasePage
    {
        public Link SignOut { get; private set; }

        public Text LoggedInUser { get; private set; }

        public Tab HomeTab { get; private set; }

        public Tab MyInformationTab { get; private set; }

        public Tab ApplicationStatusTab { get; private set; }

        public Tab AddAStudentTab { get; private set; }

        public Tab PrintAndSendDocumentsTab { get; private set; }

        public Tab ReimbursementRequestsTab { get; private set; }

        public Tab ResourcesTab { get; private set; }

        public Tab FAQTab { get; private set; }

        public Tab ContactUsTab { get; private set; }

        public Tab AppealTab { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            SignOut = new Link(Driver, By.Id("LBSignOut"));
            LoggedInUser = new Text(Driver, By.Id("LblUsername"));
            HomeTab = new Tab(Driver, By.Id("TCMainTab_T0T"));
            MyInformationTab = new Tab(Driver, By.Id("TCMainTab_T1T"));
            ApplicationStatusTab = new Tab(Driver, By.Id("TCMainTab_AT2T"));
            AddAStudentTab = new Tab(Driver, By.LinkText("Add a Student"));
            PrintAndSendDocumentsTab = new Tab(Driver, By.Id("TCMainTab_T3"));
            ReimbursementRequestsTab = new Tab(Driver, By.LinkText("Reimbursement Requests"));
            ResourcesTab = new Tab(Driver, By.LinkText("Resources"));
            FAQTab = new Tab(Driver, By.LinkText("FAQ"));
            ContactUsTab = new Tab(Driver, By.LinkText("Contact Us"));
            AppealTab = new Tab(Driver, By.LinkText("Appeal"));
        }
    }
}
