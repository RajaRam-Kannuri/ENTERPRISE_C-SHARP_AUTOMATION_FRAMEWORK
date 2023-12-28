using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class PrimaryParentInformationPage :
        SurveyBasePage
    {

        public EditField ParentFirstNameTextBox { get; private set; }
        public EditField ParentMiddleNameTextBox { get; private set; }
        public EditField ParentLastNameTextBox { get; private set; }
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

        public PrimaryParentInformationPage(IWebDriver driver)
            : base(driver)
        {
            ParentFirstNameTextBox = new EditField(Driver, By.Id("sgE-5397639-1-71-element"));
            ParentMiddleNameTextBox = new EditField(Driver, By.Id("sgE-5397639-1-120-element"));
            ParentLastNameTextBox = new EditField(Driver, By.Id("sgE-5397639-1-73-element"));
            StreetAddressTextBox = new EditField(Driver, By.Id("sgE-5397639-1-74-element"));
            CityTextBox = new EditField(Driver, By.Id("sgE-5397639-1-75-element"));
            ZIPCodeTextBox = new EditField(Driver, By.Id("sgE-5397639-1-77-element"));
            StateDropdown = new Dropdown(Driver, By.Id("sgE-5397639-1-177-element"));
            SuffixDropdown = new Dropdown(Driver, By.Id("sgE-5397639-1-119-element"));
            EmailAddressTextBox = new EditField(Driver, By.Id("sgE-5397639-1-78-element"));
            PhoneNumberTextBox = new EditField(Driver, By.Id("sgE-5397639-1-79-element"));
            CountyDropdown = new Dropdown(Driver, By.Id("sgE-5397639-1-121-element"));
            EnglishRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-1-122-10297\"]"));
            SpanishRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-1-122-10298\"]"));
            OtherRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-1-122-10300\"]"));
            NoSecondaryAdultRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-1-231-10801\"]"));
            YesSecondaryAdultRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-1-231-10800\"]"));
        }
    }
}
