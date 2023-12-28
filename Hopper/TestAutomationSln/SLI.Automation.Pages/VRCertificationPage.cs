using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class VRCertificationPage : HomePage
    {
        public EditField FirstName { get; private set; }

        public EditField MiddlInitial { get; private set; }

        public EditField LastName { get; private set; }

        public Button ICertifyButton { get; private set; }

        public Button ReturnToVRButton { get; private set; }

        public VRCertificationPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"tbxFirstName\"]"));
            MiddlInitial = new EditField(Driver, By.CssSelector("input[id$=\"tbxMiddleInitial\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"tbxLastName\"]"));
            ICertifyButton = new Button(Driver, By.CssSelector("input[id$=\"btnCertifyVrNav\"]"));
            ReturnToVRButton = new Button(Driver, By.CssSelector("input[id$=\"Button2\"]"));
        }
    }
}
