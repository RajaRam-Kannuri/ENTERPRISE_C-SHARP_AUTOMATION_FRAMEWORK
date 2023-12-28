using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class AribaSAPApproveCommentsPage : BasePage
    {
        public EditField CommentsTextbox { get; private set; }
        public Button OKButton { get; private set; }

        public AribaSAPApproveCommentsPage(IWebDriver driver)
            : base(driver)
        {
            CommentsTextbox = new EditField(Driver, By.Id("_vwptbc"));
            OKButton = new Button(Driver, By.Id("_svvsg"));
        }
    }
}
