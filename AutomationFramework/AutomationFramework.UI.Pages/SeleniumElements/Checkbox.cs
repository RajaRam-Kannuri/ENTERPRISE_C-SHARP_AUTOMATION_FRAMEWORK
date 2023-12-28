using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Checkbox : BaseElement
    {
        public Checkbox(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}