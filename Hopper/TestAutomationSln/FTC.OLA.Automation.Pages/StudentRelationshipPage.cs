using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentRelationshipPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown RelationshipDropdown { get; private set; }
        public Text YouMustSelectARelationshipTypeMessage { get; private set; }

        public StudentRelationshipPage(IWebDriver driver)
            : base(driver)
        {
            RelationshipDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            YouMustSelectARelationshipTypeMessage = new Text(Driver, By.XPath("//p[text() = 'You must select a relationship type']"));
        }
    }
}
