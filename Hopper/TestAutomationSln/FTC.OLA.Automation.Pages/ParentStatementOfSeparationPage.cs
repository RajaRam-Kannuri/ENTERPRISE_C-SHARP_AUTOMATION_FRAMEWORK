using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentStatementOfSeparationPage : ApplicationWizardPage
    {
        public EditField FirstName { get; private set; }
        public EditField MiddleName { get; private set; }
        public EditField LastName { get; private set; }
        public OLAWorkflowDropdown SuffixDropdown { get; private set; }
        public EditField DateOfSeparation { get; private set; }
        public Button DontKnowAddress { get; private set; }
        public EditField StreetAddress { get; private set; }
        public EditField AptNumber { get; private set; }
        public EditField City { get; private set; }
        public OLAWorkflowDropdown2 StateDropdown { get; private set; }
        public EditField ZipCode { get; private set; }
        public Button DontKnowPhoneNumber { get; private set; }
        public EditField PhoneNumber { get; private set; }
        public EditField ParentSignature { get; private set; }
        public Text ParentName { get; private set; }
        public Text FirstNameIsRequiredMessage { get; private set; }
        public Text FirstNameIsNotLongEnoughMessage { get; private set; }
        public Text FirstNameInvalidCharactersMessage { get; private set; }
        public Text LastNameIsRequiredMessage { get; private set; }
        public Text LastNameIsNotLongEnoughMessage { get; private set; }
        public Text LastNameInvalidCharactersMessage { get; private set; }
        public Text DateOfSeparationIsRequiredMessage { get; private set; }
        public Text DateOfSeparationInvalidDateMessage { get; private set; }
        public Text StreetAddressIsRequiredMessage { get; private set; }
        public Text StreetAddressIsNotLongEnoughMessage { get; private set; }
        public Text CityIsRequiredMessage { get; private set; }
        public Text CityIsNotLongEnoughMessage { get; private set; }
        public Text StateIsRequiredMessage { get; private set; }
        public Text ZipIsRequiredMessage { get; private set; }
        public Text ZipIsNotLongEnoughMessage { get; private set; }
        public Text ZipIsInvalidMessage { get; private set; }
        public Text PhoneNumberIsRequiredMessage { get; private set; }
        public Text PhoneNumberInvalidFormatMessage { get; private set; }
        public Text TheNameEnteredDoesNotMatchMessage { get; private set; }

        public ParentStatementOfSeparationPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.Id("firstName"));
            MiddleName = new EditField(Driver, By.Id("middleName"));
            LastName = new EditField(Driver, By.Id("lastName"));
			SuffixDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            DateOfSeparation = new EditField(Driver, By.Id("dateOfSeparation"));
            DontKnowAddress = new Button(Driver, By.CssSelector("label[for*=\"addressUnknown\"]"));
            StreetAddress = new EditField(Driver, By.Id("streetAddress"));
            AptNumber = new EditField(Driver, By.Id("aptNumber"));
            City = new EditField(Driver, By.Id("city"));
			StateDropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            ZipCode = new EditField(Driver, By.Id("zipcode"));
            DontKnowPhoneNumber = new Button(Driver, By.CssSelector("label[for*=\"phoneUnknown\"]"));
            PhoneNumber = new EditField(Driver, By.Id("phone"));
            ParentSignature = new EditField(Driver, By.Id("primarySignature"));
            ParentName = new Text(Driver, By.CssSelector("#question-form > div:nth-child(8) > div > p"));
            FirstNameIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(1) > div"));
            FirstNameIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(1) > div"));
            FirstNameInvalidCharactersMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(1) > div"));
            LastNameIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            LastNameIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            LastNameInvalidCharactersMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div:nth-child(3) > div"));
            DateOfSeparationIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(4) > div > div"));
            DateOfSeparationInvalidDateMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(4) > div > div"));
            StreetAddressIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div.row.section-group > div.input-field.col.s12.m4 > div"));
            StreetAddressIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div.row.section-group > div.input-field.col.s12.m4 > div"));
            CityIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div.input-field.col.s12.m4 > div"));
            CityIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div.input-field.col.s12.m4 > div"));
            StateIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div:nth-child(2) > div.errors"));
            ZipIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div:nth-child(3) > div"));
            ZipIsNotLongEnoughMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div:nth-child(3) > div"));
            ZipIsInvalidMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(6) > div:nth-child(2) > div:nth-child(3) > div"));
            PhoneNumberIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(8) > div > div"));
            PhoneNumberInvalidFormatMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(8) > div > div"));
            TheNameEnteredDoesNotMatchMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
        }
    }
}
