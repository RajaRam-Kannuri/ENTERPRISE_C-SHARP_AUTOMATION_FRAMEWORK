using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ElectronicSignaturePage : ApplicationWizardPage
    {
        public Checkbox ClickToCertifyFirstCheckbox { get; private set; }
		public Checkbox ClickToCertifySecondCheckbox { get; private set; }
		public Checkbox ClickToCertifyThirdCheckbox { get; private set; }
		public Checkbox ClickToCertifyFourthCheckbox { get; private set; }
        public Checkbox ClickToCertifyFifthCheckbox { get; private set; }
        public Checkbox ClickToCertifySixthCheckbox { get; private set; }
        public Link StepUpForStudentsParentHandbookLink { get; private set; }
		public EditField PrimaryParentSignatureTextBox { get; private set; }
		public EditField SecondaryParentSignatureTextBox { get; private set; }
		public Text PrimaryParentName { get; private set; }
		public Text SecondaryParentName { get; private set; }
        public Button SubmitApplicationButton { get; private set; }
        public Text CheckboxOneErrorMessage { get; private set; }
        public Text CheckboxTwoErrorMessage { get; private set; }
        public Text CheckboxThreeErrorMessage { get; private set; }
        public Text CheckboxFourErrorMessage { get; private set; }
        public Text CheckboxFiveErrorMessage { get; private set; }
        public Text CheckboxSixErrorMessage { get; private set; }

        public ElectronicSignaturePage(IWebDriver driver)
            : base(driver)
        {
			ClickToCertifyFirstCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"informationCertify\"]"));
			ClickToCertifySecondCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"certifyRules\"]"));
			ClickToCertifyThirdCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"informationConsent\"]"));
			ClickToCertifyFourthCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"additionalScholarships\"]"));
            ClickToCertifyFifthCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"attendPrivate\"]"));
            ClickToCertifySixthCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"meetPrincipal\"]"));
            StepUpForStudentsParentHandbookLink = new Link(Driver, By.XPath("//a[text() = 'Step Up for Students Parent Handbook']"));
			PrimaryParentSignatureTextBox = new EditField(Driver, By.Id("primaryName"));
			SecondaryParentSignatureTextBox = new EditField(Driver, By.Id("secondaryName"));
            PrimaryParentName = new Text(Driver, By.CssSelector("#question-form > div:nth-child(8) > div.input-field.col.s12.l5 > p"));
			SecondaryParentName = new Text(Driver, By.CssSelector("#question-form > div:nth-child(8) > div:nth-child(3) > p"));
            SubmitApplicationButton = new Button(Driver, By.Id("question-next-button"));
            CheckboxOneErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
            CheckboxTwoErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
            CheckboxThreeErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
            CheckboxFourErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
            CheckboxFiveErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
            CheckboxSixErrorMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) >  div:nth-child(3) > p"));
        }
    }
}
