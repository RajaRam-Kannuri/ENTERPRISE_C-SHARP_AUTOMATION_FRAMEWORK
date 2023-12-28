using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentReviewPage : ApplicationWizardPage
    {
        public Text NameLabel { get; private set; }
        public Text SSNLabel { get; private set; }

        public ParentReviewPage(IWebDriver driver)
            : base(driver)
        {
            NameLabel = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > standard-navigation-screen > div > div > div > div > div.card-content > primary-parent-review-container > primary-parent-review > div > div:nth-child(1) > div.col.s4.label > p"));
            SSNLabel = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > standard-navigation-screen > div > div > div > div > div.card-content > primary-parent-review-container > primary-parent-review > div > div:nth-child(2) > div.col.s4.label > p"));
        }
    }
}
