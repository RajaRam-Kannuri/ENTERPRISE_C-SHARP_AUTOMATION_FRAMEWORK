using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class AccountActivityPage : HomePage
    {
        public Link ViewStudentStatement { get; private set; }

        public Link SubmitAReimbursementRequest { get; private set; }

        public Link SubmitAPreAuthorizationRequest { get; private set; }

        public Link ApproveAProviderReimbursement { get; private set; }

        public Link UploadReimbursementDocuments { get; private set; }

        public Link PrintIDCard { get; private set; }

        public AccountActivityPage(IWebDriver driver)
            : base(driver)
        {
            ViewStudentStatement = new Link(Driver, By.LinkText("View Student Statement"));
            SubmitAReimbursementRequest = new Link(Driver, By.LinkText("Submit a Reimbursement Request"));
            SubmitAPreAuthorizationRequest = new Link(Driver, By.LinkText("Submit a Pre-Authorization Request"));
            ApproveAProviderReimbursement = new Link(Driver, By.LinkText("Approve a Provider Reimbursement"));
            UploadReimbursementDocuments = new Link(Driver, By.LinkText("Upload Reimbursement Documents"));
            PrintIDCard = new Link(Driver, By.LinkText("Print ID Card"));
        }
    }
}
