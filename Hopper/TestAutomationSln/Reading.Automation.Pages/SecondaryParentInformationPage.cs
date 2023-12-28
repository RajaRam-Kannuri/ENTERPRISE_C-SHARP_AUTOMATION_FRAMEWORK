using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class SecondaryParentInformationPage :
        SurveyBasePage
    {

        public EditField SecondaryParentFirstNameTextBox { get; private set; }
        public EditField SecondaryParentMiddleNameTextBox { get; private set; }
        public EditField SecondaryParentLastNameTextBox { get; private set; }
        public EditField StreetAddressTextBox { get; private set; }
        public EditField CityTextBox { get; private set; }
        public EditField ZIPCodeTextBox { get; private set; }
        public Dropdown StateDropdown { get; private set; }
        public Dropdown SuffixDropdown { get; private set; }
        public EditField EmailAddressTextBox { get; private set; }
        public EditField PhoneNumberTextBox { get; private set; }
        public Dropdown CountyDropdown { get; private set; }
        public Radio EnglishRadioButton { get; private set; }
        public Radio SpanishRadioButton { get; private set; }
        public Radio OtherRadioButton { get; private set; }
        public Radio NoSecondaryAdultRadioButton { get; private set; }
        public Radio YesSecondaryAdultRadioButton { get; private set; }

        public SecondaryParentInformationPage(IWebDriver driver)
            : base(driver)
        {
            SecondaryParentFirstNameTextBox = new EditField(Driver, By.Id("sgE-5397639-25-233-element"));
            SecondaryParentMiddleNameTextBox = new EditField(Driver, By.Id("sgE-5397639-25-237-element"));
            SecondaryParentLastNameTextBox = new EditField(Driver, By.Id("sgE-5397639-25-238-element"));
            SuffixDropdown = new Dropdown(Driver, By.Id("sgE-5397639-25-239-element"));
            EmailAddressTextBox = new EditField(Driver, By.Id("sgE-5397639-25-240-element"));
            PhoneNumberTextBox = new EditField(Driver, By.Id("sgE-5397639-25-241-element"));
        }
    }
}
