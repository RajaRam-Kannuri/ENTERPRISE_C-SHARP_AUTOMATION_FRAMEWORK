using OpenQA.Selenium;

namespace Interfaces
{
    public class Button
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public Button(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public void Click() => element.Click();

        public string GetText()
        {
            return element.Text;
        }

        public string GetFromHTMLAttribute(string htmlAttribute)
        {
            return element.GetAttribute(htmlAttribute);
        }

        public string GetFromCSSAttribute(string cssAttribute)
        {
            return element.GetCssValue(cssAttribute);
        }
    }
}
