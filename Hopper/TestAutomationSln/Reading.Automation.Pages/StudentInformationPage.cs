using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class StudentInformationPage :
        SurveyBasePage
    {

        public EditField StudentFirstNameTextBox { get; private set; }
        public EditField StudentMiddleNameTextBox { get; private set; }
        public EditField StudentLastNameTextBox { get; private set; }
        public Dropdown SuffixDropdown { get; private set; }
        public EditField DateOfBirthTextBox { get; private set; }
        public EditField SchoolPlanningToAttendTextBox { get; private set; }
        public Dropdown SchoolCountyDropdown { get; private set; }
        public Dropdown GradeLevelDropdown { get; private set; }
        public Radio HispanicNoRadioButton { get; private set; }
        public Radio HispanicYesRadioButton { get; private set; }
        public Radio GenderMaleRadioButton { get; private set; }
        public Radio GenderFemaleRadioButton { get; private set; }
        public Checkbox AmericanIndianOrAlaskaNativeCheckbox { get; private set; }
        public Checkbox AsianCheckbox { get; private set; }
        public Checkbox BlackOrAfricanAmericanCheckbox { get; private set; }
        public Checkbox NativeHawaiianOrOtherPacificIslanderCheckbox { get; private set; }
        public Checkbox WhiteCheckbox { get; private set; }

        public StudentInformationPage(IWebDriver driver)
            : base(driver)
        {
            StudentFirstNameTextBox = new EditField(Driver, By.Id("sgE-5397639-10-129-element"));
            StudentMiddleNameTextBox = new EditField(Driver, By.Id("sgE-5397639-10-130-element"));
            StudentLastNameTextBox = new EditField(Driver, By.Id("sgE-5397639-10-131-element"));
            SuffixDropdown = new Dropdown(Driver, By.Id("sgE-5397639-10-132-element"));
            DateOfBirthTextBox = new EditField(Driver, By.Id("sgE-5397639-10-170-element"));
            SchoolPlanningToAttendTextBox = new EditField(Driver, By.Id("sgE-5397639-10-138-element"));
            SchoolCountyDropdown = new Dropdown(Driver, By.Id("sgE-5397639-10-139-element"));
            GradeLevelDropdown = new Dropdown(Driver, By.Id("sgE-5397639-10-140-element"));
            HispanicNoRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-135-10334\"]"));
            HispanicYesRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-135-10333\"]"));
            GenderMaleRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-137-10341\"]"));
            GenderFemaleRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-137-10340\"]"));
            AmericanIndianOrAlaskaNativeCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-136-10335\"]"));
            AsianCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-136-10336\"]"));
            BlackOrAfricanAmericanCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-136-10337\"]"));
            NativeHawaiianOrOtherPacificIslanderCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-136-10338\"]"));
            WhiteCheckbox = new Checkbox(Driver, By.CssSelector("label[for$=\"sgE-5397639-10-136-10339\"]"));
        }
    }
}
