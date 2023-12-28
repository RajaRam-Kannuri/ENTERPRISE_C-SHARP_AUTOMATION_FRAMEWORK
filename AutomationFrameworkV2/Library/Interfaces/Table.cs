using OpenQA.Selenium;

namespace Interfaces
{
    public class Table
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public Table(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public void Click() => element.Click();

        public string GetText()
        {
            return element.Text;
        }

        public string GetFromCSSAttribute(string CSSAttribute)
        {
            return element.GetCssValue(CSSAttribute);
        }

        public string GetFromHTMLAttribute(string HTMLAttribute)
        {
            return element.GetAttribute(HTMLAttribute);
        }

    }
}
