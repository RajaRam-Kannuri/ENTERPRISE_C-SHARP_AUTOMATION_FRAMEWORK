using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ApplicationAlreadySubmittedPage : OLABasePage
    {
        public Text AlreadySubmittedMessage { get; private set; }
        public Button TakeMeToMyDashboard_Button { get; private set; }
        public Button ContactUs_Button { get; private set; }

        public ApplicationAlreadySubmittedPage(IWebDriver driver)
            : base(driver)
        {
            AlreadySubmittedMessage = new Text(Driver, By.XPath("//div[text() = 'Your application has already been submitted']"));
            TakeMeToMyDashboard_Button = new Button(Driver, By.XPath("/html/body/app-root/div[1]/submitted/div/div/div/div/div[2]/div/div/div[2]/p[1]/a"));
            ContactUs_Button = new Button(Driver, By.XPath("/html/body/app-root/div[1]/submitted/div/div/div/div/div[2]/div/div/div[2]/p[2]/a"));
        }
    }
}
