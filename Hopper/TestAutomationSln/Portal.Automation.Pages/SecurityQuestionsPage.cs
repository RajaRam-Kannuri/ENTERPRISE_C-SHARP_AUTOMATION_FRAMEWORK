using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Portal.Automation.Pages
{
    public class SecurityQuestionsPage : PortalBasePage
    {
		public EditField Answer1 { get; private set; }
		public EditField Answer2 { get; private set; }
		public EditField Answer3 { get; private set; }
		public OLAWorkflowDropdown Question1Dropdown { get; private set; }
		public OLAWorkflowDropdown2 Question2Dropdown { get; private set; }
		public OLAWorkflowDropdown3 Question3Dropdown { get; private set; }
		public Button SaveButton { get; private set; }
        public Text Answer1IsRequired_Message { get; private set; }
        public Text Answer2IsRequired_Message { get; private set; }
        public Text Answer3IsRequired_Message { get; private set; }

        public SecurityQuestionsPage(IWebDriver driver)
            : base(driver)
        {
			Answer1 = new EditField(Driver, By.Id("Answers_Question1Answer"));
			Answer2 = new EditField(Driver, By.Id("Answers_Question2Answer"));
			Answer3 = new EditField(Driver, By.Id("Answers_Question3Answer"));
			Question1Dropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
			Question2Dropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
			Question3Dropdown = new OLAWorkflowDropdown3(Driver, By.ClassName("select-dropdown"));
			SaveButton = new Button(Driver, By.CssSelector("#LoginForm > div > div > button"));
            Answer1IsRequired_Message = new Text(Driver, By.Id("Answers_Question1Answer-error"));
            Answer2IsRequired_Message = new Text(Driver, By.Id("Answers_Question2Answer-error"));
            Answer3IsRequired_Message = new Text(Driver, By.Id("Answers_Question3Answer-error"));
        }
    }
}