using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Link : BaseElement
    {
        public Link(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
