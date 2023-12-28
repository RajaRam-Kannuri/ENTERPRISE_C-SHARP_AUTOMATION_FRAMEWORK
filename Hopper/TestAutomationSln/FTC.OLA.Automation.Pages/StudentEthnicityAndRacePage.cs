using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentEthnicityAndRacePage : ApplicationWizardPage
    {
        public Radio HispanicOriginYES { get; private set; }
        public Radio HispanicOriginNO { get; private set; }
        public Checkbox AmericanIndianOrAlaskaNative { get; private set; }
        public Checkbox Asian { get; private set; }
        public Checkbox BlackOrAfricanAmerican { get; private set; }
        public Checkbox NativeHawaiianOrOtherPacificIslander { get; private set; }
        public Checkbox White { get; private set; }
        public Text YouMustSelectYesOrNoMessage { get; private set; }
        public Text OneOrMoreRaceCategoriesMustBeSelectedMessage { get; private set; }

        public StudentEthnicityAndRacePage(IWebDriver driver)
            : base(driver)
        {
            HispanicOriginYES = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div > label:nth-child(2)"));
            HispanicOriginNO = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div > label:nth-child(4)"));
            AmericanIndianOrAlaskaNative = new Checkbox(Driver, By.CssSelector("#question-form > div:nth-child(3) > div:nth-child(1) > label:nth-child(2)"));
            Asian = new Checkbox(Driver, By.CssSelector("#question-form > div:nth-child(3) > div:nth-child(1) > label:nth-child(6)"));
            BlackOrAfricanAmerican = new Checkbox(Driver, By.CssSelector("#question-form > div:nth-child(3) > div:nth-child(1) > label:nth-child(10)"));
            NativeHawaiianOrOtherPacificIslander = new Checkbox(Driver, By.CssSelector("#question-form > div:nth-child(3) > div:nth-child(2) > label:nth-child(2)"));
            White = new Checkbox(Driver, By.CssSelector("#question-form > div:nth-child(3) > div:nth-child(2) > label:nth-child(6)"));
            YouMustSelectYesOrNoMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div.errors"));
            OneOrMoreRaceCategoriesMustBeSelectedMessage = new Text(Driver, By.XPath("//p[text() = 'One or more race categories must be selected!']"));
        }
    }
}
