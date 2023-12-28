using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Dropdown : BaseElement
    {
        public Dropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}