using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FaxCoverSheetPage : ApplicationWizardPage
    {
        public Button PrintButton { get; private set; }
        public Button BackButton { get; private set; }
        public Text ApplicationIdNumber { get; private set; }

        public FaxCoverSheetPage(IWebDriver driver)
            : base(driver)
        {
			PrintButton = new Button(Driver, By.XPath("//a[text() = 'Print']"));
			BackButton = new Button(Driver, By.XPath("//a[text() = 'Back']"));
            ApplicationIdNumber = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > fax > div > div > div > div.col.s12.section-2 > p:nth-child(1) > span:nth-child(2)"));
		}
	}
}
