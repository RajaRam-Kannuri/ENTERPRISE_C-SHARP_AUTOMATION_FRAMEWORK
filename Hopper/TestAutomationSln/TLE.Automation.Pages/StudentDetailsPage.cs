using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class StudentDetailsPage : CommonPage
    {
        public Checkbox IsActive { get; private set; }

        public EditField StudentFirstName { get; private set; }

        public EditField StudentMiddleName { get; private set; }

        public EditField StudentLastName { get; private set; }

        public EditField DateOfBirth { get; private set; }

        public TypeAheadList GradeLevel { get; private set; }

        public EditField StudentIdentifier { get; private set; }

        public TypeAheadList Gender { get; private set; }

        public EditField SSN { get; private set; }

        public EditField StudentEmail { get; private set; }

        public EditField AlienRegistrationNumber { get; private set; }

        public Checkbox HasIEP { get; private set; }

        public Button AttachIEPButton { get; private set; }

        public Button SaveButton { get; private set; }

        public WebElement PrimaryGuardianSection { get; private set; }

        public WebElement SecondaryGuardianSection { get; private set; }

        public Button CancelButton { get; private set; }

        public StudentDetailsPage(IWebDriver driver)
            : base(driver)
        {
            IsActive = new Checkbox(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.isActive\"]"));
            StudentFirstName = new EditField(Driver, By.CssSelector("input[name=\"studentFirstName\"]"));
            StudentMiddleName = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.middleName\"]"));
            StudentLastName = new EditField(Driver, By.CssSelector("input[name=\"studentLastName\"]"));
            DateOfBirth = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.dateOfBirth\"]"));
            GradeLevel = new TypeAheadList(Driver, By.CssSelector("div[name=\"gradelevel\"]"));
            StudentIdentifier = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.studentIdentifier\"]"));
            Gender = new TypeAheadList(Driver, By.CssSelector("div[name=\"gender\"]"));
            SSN = new EditField(Driver, By.CssSelector("input[name=\"ssn\"]"));
            StudentEmail = new EditField(Driver, By.CssSelector("input[name=\"studentEmail\"]"));
            HasIEP = new Checkbox(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.hasIEP\"]"));
            AlienRegistrationNumber = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.studentModel.arn\"]"));
            AttachIEPButton = new Button(Driver, By.CssSelector("input[name=\"iepFile\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[value=\"Save\"]"));
            PrimaryGuardianSection = new WebElement(Driver, By.CssSelector("div[heading*=\"Primary Parent\"]"));
            SecondaryGuardianSection = new WebElement(Driver, By.CssSelector("div[heading*=\"Secondary Parent\"]"));
            CancelButton = new Button(Driver, By.CssSelector("input[ng-click=\"vm.cancel()\"]"));
        }
    }
}
