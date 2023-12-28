using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Text : BaseElement
    {
        public Text(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}