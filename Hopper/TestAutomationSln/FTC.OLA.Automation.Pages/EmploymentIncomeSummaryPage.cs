using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class EmploymentIncomeSummaryPage : ApplicationWizardPage
    {
        public Button ReturnToIncomeButton { get; private set; }
        public Button AddJobButton { get; private set; }
        public OLAEmploymentIncomeTable EmploymentIncomeTable { get; private set; }
        public Text TotalIncomeAmount { get; private set; }

        public EmploymentIncomeSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ReturnToIncomeButton = new Button(Driver, By.Id("question-next-button"));
            AddJobButton = new Button(Driver, By.Id("btnAddJob"));
            EmploymentIncomeTable = new OLAEmploymentIncomeTable(Driver, By.XPath("//*[contains(@class, 'new-student-section')]"));
            TotalIncomeAmount = new Text(Driver, By.XPath("/html/body/app-root/div[1]/standard-navigation-screen/div/div/div/div/div[1]/employment-income-summary-container/employment-income-summary/div/div/div[1]/div[5]/div[2]"));
        }
    }
}