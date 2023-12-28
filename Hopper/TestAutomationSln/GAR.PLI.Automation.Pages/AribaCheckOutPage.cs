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
    public class AribaCheckOutPage : AribaApplicationWizardPage
    {
        public Button SendRequestButton { get; private set; }
        public Button SaveAndExitButton { get; private set; }
        public Button SubmitButton { get; private set; }
        public Button DoneButton { get; private set; }
        public PRNumber PRNumber { get; private set; }

        public AribaCheckOutPage(IWebDriver driver)
            : base(driver)
        {
            //SendRequestButton = new Button(Driver, By.CssSelector("#gbsection > div.action-bar-content > gb-action-bar > div > div > div > div.fd-action-bar__actions > div > button.btn-medium.btn-primary"));
            SendRequestButton = new Button(Driver, By.XPath("//button[text() = 'Send request']"));
            SaveAndExitButton = new Button(Driver, By.XPath("//button[text() = 'Save and exit']"));
            SubmitButton = new Button(Driver, By.XPath("//button[text() = 'Submit']"));
            //SaveAndExitButton = new Button(Driver, By.CssSelector("#gbsection > div.action-bar-content > gb-action-bar > div > div > div > div.fd-action-bar__actions > div > button.btn-medium.btn-inverse"));
            //DoneButton = new Button(Driver, By.CssSelector("#gbsection > div.action-bar-content > gb-action-bar > div > div > div > div.fd-action-bar__actions > div > button"));
            //DoneButton = new Button(Driver, By.XPath("//button[text() = 'Save and exit']"));
            DoneButton = new Button(Driver, By.CssSelector("#success-modal-sendRequest > div > div > div > div.modal-footer > button.btn-primary.btn-small"));
            PRNumber = new PRNumber(Driver, By.CssSelector("#gbsection > div.action-bar-content > gb-action-bar > div > div > div > div.fd-action-bar__header > div.req-info > div"));
        }
    }
}
