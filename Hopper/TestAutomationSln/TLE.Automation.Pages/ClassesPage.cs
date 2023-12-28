using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ClassesPage : CommonPage
    {
        public WebElement CreateClassLink { get; private set; }

        public WebElement SchoolName { get; private set; }

        public WebElement SchoolYear { get; private set; }

        public WebElement Teacher { get; private set; }

        public WebElement ClassCount { get; private set; }

        public WebTable ClassTable { get; private set; }

        public ClassesPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
