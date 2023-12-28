using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentPreviousSchoolPage : ApplicationWizardPage
    {
        public EditField SchoolName { get; private set; }
        public OLAWorkflowDropdown SchoolTypeDropdown { get; private set; }
        public OLAWorkflowDropdown2 CountyDropdown { get; private set; }
        public Text ThisFieldIsRequiredMessage { get; private set; }
        public Text MustBeAtLeast2CharactersMessage { get; private set; }
        public Text InvalidCharactersMessage { get; private set; }
        public Button ContinuePopupButton { get; private set; }
        public Button StayPopupButton { get; private set; }

        public StudentPreviousSchoolPage(IWebDriver driver)
            : base(driver)
        {
            SchoolName = new EditField(Driver, By.Id("schoolName"));
			SchoolTypeDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
			CountyDropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            ThisFieldIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div"));
            MustBeAtLeast2CharactersMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div"));
            InvalidCharactersMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(1) > div > div"));
            ContinuePopupButton = new Button(Driver, By.XPath("//a[text() = 'Continue']"));
            StayPopupButton = new Button(Driver, By.XPath("//a[text() = 'Stay']"));
        }
    }
}
