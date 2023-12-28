using OpenQA.Selenium;

namespace AutomationFramework
{
    public class List : BaseElement
    {
        public List(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
