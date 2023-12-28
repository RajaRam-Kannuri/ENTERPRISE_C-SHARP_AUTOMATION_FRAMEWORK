using System.Collections.Generic;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class BasePage
    {
        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public List<string> ErrorMessages()
        {
            List<string> errList = new List<string>();

            // Server errors
            if (Driver.PageSource.Contains("Server Error"))
            {
                errList.Add("Server Error encountered:");
                errList.Add(Driver.PageSource);
            }

            return errList;
        }

        public void SetDriverFocus()
        {
            Driver.UseDefault();
        }
    }
}
