using OpenQA.Selenium;

namespace NLPLogix.Core.Abstract
{
    public abstract class Widget : Dashboard
    {
        protected Widget(IWebDriver driver) : base(driver)
        {
        }
    }
}
