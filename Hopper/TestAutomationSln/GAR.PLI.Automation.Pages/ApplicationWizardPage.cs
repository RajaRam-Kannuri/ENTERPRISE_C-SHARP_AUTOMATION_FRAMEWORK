using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public abstract class ApplicationWizardPage : BasePage
    {
        public Button SaveAndLogoutButton { get; private set; }

        public Button NextButton { get; private set; }

        public Button SubmitButton { get; private set; }

        public Button PreviousButton { get; private set; }

        public Text PageTitle { get; private set; }

        public HiddenButton OnlineChatButton { get; private set; }

        public ApplicationWizardPage(IWebDriver driver)
            : base(driver)
        {
            SaveAndLogoutButton = new Button(Driver, By.Id("RPMainPanel_BtnLogout"));
            NextButton = new Button(Driver, By.Id("RPMainPanel_BtnNext"));
            SubmitButton = new Button(Driver, By.Id("RPMainPanel_BtnNext"));
            PreviousButton = new Button(Driver, By.Id("RPMainPanel_BtnPrevious"));
            PageTitle = new Text(Driver, By.Id("RPMainPanel_LblPageName"));
            OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
        }
    }
}
