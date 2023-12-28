using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Label : BaseElement
    {
        public Label(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
