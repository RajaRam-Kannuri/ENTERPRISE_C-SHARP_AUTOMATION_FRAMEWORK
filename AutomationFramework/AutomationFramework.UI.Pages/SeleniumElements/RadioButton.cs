using OpenQA.Selenium;

namespace AutomationFramework
{
    public class RadioButton : BaseElement
    {
        public RadioButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
