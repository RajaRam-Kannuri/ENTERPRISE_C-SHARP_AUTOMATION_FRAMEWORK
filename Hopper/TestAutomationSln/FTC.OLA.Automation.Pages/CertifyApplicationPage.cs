using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class CertifyApplicationPage : ApplicationWizardPage
    {
        public Checkbox ClickToCertifyFirstCheckbox { get; private set; }
		public Checkbox ClickToCertifySecondCheckbox { get; private set; }
		public Checkbox ClickToCertifyThirdCheckbox { get; private set; }
		//public Checkbox ClickToCertifyFourthCheckbox { get; private set; }
		public Link StepUpForStudentsParentHandbookLink { get; private set; }
        public Text YouMustCertifyThisStatementMessage1 { get; private set; }
        public Text YouMustCertifyThisStatementMessage2 { get; private set; }
        public Text YouMustCertifyThisStatementMessage3 { get; private set; }
        //public Text YouMustCertifyThisStatementMessage4 { get; private set; }

        public CertifyApplicationPage(IWebDriver driver)
            : base(driver)
        {
			ClickToCertifyFirstCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"informationCertify\"]"));
			ClickToCertifySecondCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"certifyRules\"]"));
			ClickToCertifyThirdCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"informationConsent\"]"));
			//ClickToCertifyFourthCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"informationConsent\"]"));
			StepUpForStudentsParentHandbookLink = new Link(Driver, By.XPath("//a[text() = 'Step Up for Students Parent Handbook']"));
            YouMustCertifyThisStatementMessage1 = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div.errors.col.s12.push-m2.push-l2 > span"));
            YouMustCertifyThisStatementMessage2 = new Text(Driver, By.CssSelector("#question-form > div:nth-child(3) > div.errors.col.s12.push-m2.push-l2 > span"));
            YouMustCertifyThisStatementMessage3 = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div.errors.col.s12.push-m2.push-l2 > span"));
            //YouMustCertifyThisStatementMessage4 = new Text(Driver, By.CssSelector("#question-form > div:nth-child(7) > div.errors.col.s12.push-m2.push-l2 > span"));
        }
    }
}
