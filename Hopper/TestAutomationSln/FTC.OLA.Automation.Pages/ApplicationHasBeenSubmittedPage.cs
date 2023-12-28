using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ApplicationHasBeenSubmittedPage :
        BasePage
    {
        public Text YourApplicationHasBeenSubmittedSuccessMessage{ get; private set; }
        public Text YourApplicationIsNotFinishedMessage { get; private set; }
        public Button TakeMeToMyDashboardButton { get; private set; }
        public Button ContactUsButton { get; private set; }

        public ApplicationHasBeenSubmittedPage(IWebDriver driver)
            : base(driver)
        {
			YourApplicationHasBeenSubmittedSuccessMessage = new Text(Driver, By.XPath("//div[text() = 'Your application has been submitted!']"));
            YourApplicationIsNotFinishedMessage = new Text(Driver, By.XPath("//p[text() = 'Your application will not be reviewed until you send your remaining documents to us. Once we receive your additional documents, we will send you an email letting you know that we have started reviewing your application.']"));
            //TakeMeToMyDashboardButton = new Button(Driver, By.XPath("//*[contains(@a, 'Take me to my dashboard')]"));
            TakeMeToMyDashboardButton = new Button(Driver, By.XPath("//*[contains(@href, 'sufsportalapplicationtest.azurewebsites.net')]"));
            //ContactUsButton = new Button(Driver, By.XPath("//*[contains(@a, 'Contact Us')]"));
            ContactUsButton = new Button(Driver, By.XPath("//*[contains(@href, 'contact-us')]"));
        }
    }
}
