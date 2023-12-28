using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentAddressPage : ApplicationWizardPage
    {
        public EditField HomeAddress { get; private set; }
        public EditField AptNumber { get; private set; }
        public EditField ZipCode { get; private set; }
        public OLACheckbox AddressesAreSameCheckbox { get; private set; }
        public EditField MailingAddress { get; private set; }
        public EditField MailingAptNumber { get; private set; }
        public EditField MailingZipCode { get; private set; }
        public Button AddressValidationContinue { get; private set; }
        public OLAWorkflowDropdown HomeCityDropdown { get; private set; }
        public OLAWorkflowDropdown3 MailingCityDropdown { get; private set; }
        public OLAWorkflowDropdown4 CountyDropdown { get; private set; }
        public Text HomeAddressIsRequiredMessage { get; private set; }
        public Text HomeCityIsRequiredMessage { get; private set; }
        public Text HomeZIPIsRequiredMessage { get; private set; }
        public Text HomeCountyIsRequiredMessage { get; private set; }
        public Text MailingAddressIsRequiredMessage { get; private set; }
        public Text MailingCityIsRequiredMessage { get; private set; }
        public Text MailingZIPIsRequiredMessage { get; private set; }
        public Text MailingCountyIsRequiredMessage { get; private set; }
        public Text HomeAddressIsNotLongEnoughMessage { get; private set; }
        public Text HomeZIPIsNotLongEnoughMessage { get; private set; }
        public Text HomeZIPIsInvalidMessage { get; private set; }
        public Text MailingAddressIsNotLongEnoughMessage { get; private set; }
        public Text MailingZIPIsNotLongEnoughMessage { get; private set; }
        public Text MailingZIPIsInvalidMessage { get; private set; }

        public ParentAddressPage(IWebDriver driver)
            : base(driver)
        {
            HomeAddress = new EditField(Driver, By.Id("streetAddress"));
            AptNumber = new EditField(Driver, By.Id("aptNumber"));
            ZipCode = new EditField(Driver, By.Id("zipcode"));
			AddressesAreSameCheckbox = new OLACheckbox(Driver, By.CssSelector("label[for$=\"addressesAreSameChkbx\"]"));
			MailingAddress = new EditField(Driver, By.Id("mailingStreetAddress"));
            MailingAptNumber = new EditField(Driver, By.Id("mailingAptNumber"));
            MailingZipCode = new EditField(Driver, By.Id("mailingZipcode"));
			AddressValidationContinue = new Button(Driver, By.XPath("//a[text() = 'Continue']"));
            HomeCityDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            MailingCityDropdown = new OLAWorkflowDropdown3(Driver, By.ClassName("select-dropdown"));
            CountyDropdown = new OLAWorkflowDropdown4(Driver, By.ClassName("select-dropdown"));
            HomeAddressIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div.input-field.col.s12.m4 > div"));
            HomeCityIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(1) > div.errors"));
            HomeZIPIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            HomeCountyIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(4) > div.errors"));
            MailingAddressIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(4) > div.input-field.col.s12.m4 > div"));
            MailingCityIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div:nth-child(1) > div.errors"));
            MailingZIPIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div:nth-child(3) > div"));
            MailingCountyIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div:nth-child(4) > div.errors"));
            HomeAddressIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div.input-field.col.s12.m4 > div"));
            HomeZIPIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            HomeZIPIsInvalidMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            MailingAddressIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(4) > div.input-field.col.s12.m4 > div"));
            MailingZIPIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div:nth-child(3) > div"));
            MailingZIPIsInvalidMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(5) > div:nth-child(3) > div"));
        }
    }
}
