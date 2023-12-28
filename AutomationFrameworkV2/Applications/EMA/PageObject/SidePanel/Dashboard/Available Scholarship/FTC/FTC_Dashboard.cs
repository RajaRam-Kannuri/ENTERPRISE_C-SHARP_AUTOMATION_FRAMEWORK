using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;

namespace SidePanelDashboard
{
    public class FTC_Dashboard : Dashboard
    {
        public FTC_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public FTC_Dashboard SelectSchoolYear(string schoolyear)
        {
            FindCheckBox(By.XPath("//*[@class='modal-body']//h2[text()='"+ schoolyear + "']//..//..//input")).Click();
            return this;
        }

        public FTC_Application ClickContinue()
        {
            FindButton(By.XPath("(//*[@class='modal-body']//button)[2]")).Click();
            return new(driver);
        }

    }
}
