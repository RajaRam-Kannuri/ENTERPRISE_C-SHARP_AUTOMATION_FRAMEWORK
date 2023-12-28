using NLPLogix.Core.Abstract;
using OpenQA.Selenium;

namespace SidePanelDashboard
{
    public class UA_Dashboard : Widget
    {
        public UA_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public UA_Application ClickContinue()
        {
            FindButton(By.XPath("(//*[@class='modal-body']//button)[2]")).Click();
            return new(driver);
        }

    }
}
