using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class AribaSupplierConfirmingPOPage : BasePage
    {
        public EditField ConfirmationTextbox { get; private set; }
        public Button NextButton{ get; private set; }
        public Button SubmitButton { get; private set; }

        public AribaSupplierConfirmingPOPage(IWebDriver driver)
            : base(driver)
        {
            ConfirmationTextbox = new EditField(Driver, By.Id("_c85znb"));
            NextButton = new Button(Driver, By.Id("_jsl7tb"));
            SubmitButton = new Button(Driver, By.Id("_uz6b3"));
        }
    }
}
