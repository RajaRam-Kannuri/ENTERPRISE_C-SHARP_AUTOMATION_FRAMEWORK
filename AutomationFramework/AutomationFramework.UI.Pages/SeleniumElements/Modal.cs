using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Modal : BaseElement
    {
        public Modal(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
