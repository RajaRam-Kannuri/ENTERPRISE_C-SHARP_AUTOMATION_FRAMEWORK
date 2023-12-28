using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentProfilePage :
        BasePage
    {
        public EditField FirstNameTextField { get; private set; }
        public EditField MiddleNameTextField { get; private set; }
        public EditField LastNameTextField { get; private set; }
        public EditField SuffixTextField { get; private set; }
        public Button AddAddressButton { get; private set; }
        public Button AddPhoneNumberButton { get; private set; }
        public Button SubmitButton { get; private set; }

        public ParentProfilePage(IWebDriver driver)
            : base(driver)
        {
            FirstNameTextField = new EditField(Driver, By.Id(""));
            MiddleNameTextField = new EditField(Driver, By.Id(""));
            LastNameTextField = new EditField(Driver, By.Id(""));
            SuffixTextField = new EditField(Driver, By.Id(""));
            AddAddressButton = new Button(Driver, By.Id(""));
            AddPhoneNumberButton = new Button(Driver, By.Id(""));
            SubmitButton = new Button(Driver, By.Id(""));
        }
    }
}
