using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class OwnerOperatorPage : ApplicationWizardPage
    {
        public Radio NoOwnerOperatorRadioButton { get; private set; }
        public Radio YesOwnerOperatorRadioButton { get; private set; }
        public Radio NoFESSiblingRadioButton { get; private set; }
        public Radio YesFESSiblingRadioButton { get; private set; }
        public Button GardinerIDVerificationOKButton { get; private set; }

        public OwnerOperatorPage(IWebDriver driver)
            : base(driver)
        {
            NoOwnerOperatorRadioButton = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div.col.s6.right-align.no-radio-container > div > label"));
            YesOwnerOperatorRadioButton = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(2) > label"));
            NoFESSiblingRadioButton = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(6) > div.col.s6.right-align.no-radio-container > div > label"));
            YesFESSiblingRadioButton = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > label"));
            //GardinerIDVerificationOKButton = new Button(Driver, By.XPath("//a[text() = 'OK']"));
            GardinerIDVerificationOKButton = new Button(Driver, By.CssSelector("#gardinerIdVerificationModal > div.modal-footer > a"));
        }
    }
}