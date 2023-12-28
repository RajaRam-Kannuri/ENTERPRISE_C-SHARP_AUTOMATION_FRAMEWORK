using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Interfaces
{
    public class Dropdown
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public Dropdown(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public string SelectOption(string option)
        {

            IWebElement matchingOption = null;
            var allOptions = element.FindElements(By.TagName("option"));
            foreach(var list in allOptions)
            {
                if(list.Text.Equals(option))
                {
                    matchingOption = list;
                    break;
                }
                else if(list.Text.Contains(option) && matchingOption == null)
                {
                    matchingOption = list;
                }
            }
            if(matchingOption == null)
            {
            }
            else
            {
                matchingOption.Click();
            }
            return option;

        }

        public string OptionSelected(By by)
        {
            IWebElement element_name = driver.FindElement(by);
            SelectElement statusId = new SelectElement(element_name);
            return statusId.SelectedOption.Text;
        }

    }
}
