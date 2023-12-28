using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Button : BaseElement
    {
        public Button(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
