using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class MicrosoftStaySignedInPage : BasePage
    {
        public Button YESButton { get; private set; }

        public MicrosoftStaySignedInPage(IWebDriver driver)
            : base(driver)
        {
            YESButton = new Button(Driver, By.Id("idSIButton9"));
        }
    }
}
