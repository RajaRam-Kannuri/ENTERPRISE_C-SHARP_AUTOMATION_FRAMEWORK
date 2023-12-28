using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentIsThereSecondaryAdultPage : ApplicationWizardPage
    {
        public Button HasSecondaryNo { get; private set; }
        public Button HasSecondaryYes { get; private set; }
        public Text ErrorHasOccurredMessage { get; private set; }

        public ParentIsThereSecondaryAdultPage(IWebDriver driver)
            : base(driver)
        {
            HasSecondaryNo = new Button(Driver, By.CssSelector("#question-form > div > div.col.s6.right-align.no-radio-container > div > label"));
            HasSecondaryYes = new Button(Driver, By.CssSelector("#question-form > div > div:nth-child(2) > label"));
            ErrorHasOccurredMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
        }
    }
}
