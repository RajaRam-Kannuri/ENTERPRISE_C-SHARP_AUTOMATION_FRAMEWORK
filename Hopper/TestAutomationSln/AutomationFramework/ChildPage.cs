using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class ChildPage : BasePage
    {
        public ChildPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
