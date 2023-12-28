using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.Provider.Automation.Pages
{
    public class ReimbursementRequestPage : HomePage
    {
        public Link ViewReimbursementActivity { get; private set; }

        public Link SubmitAReimbursementRequest { get; private set; }

        public Link UploadReimbursementDocuments { get; private set; }

        public ReimbursementRequestPage(IWebDriver driver)
            : base(driver)
        {
            ViewReimbursementActivity = new Link(Driver, By.LinkText("View Reimbursement Activity"));
            SubmitAReimbursementRequest = new Link(Driver, By.LinkText("Submit a Reimbursement Request"));
            UploadReimbursementDocuments = new Link(Driver, By.LinkText("Upload Reimbursement Documents"));
        }
    }
}
