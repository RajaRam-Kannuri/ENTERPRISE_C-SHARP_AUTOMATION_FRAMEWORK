using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class CommonAdultInformationSection : ControlSection
    {
        public EditField FirstName { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField LastName { get; private set; }

        public EditField EmailAddress { get; private set; }

        public Radio IncomeChangesYes { get; private set; }

        public Radio IncomeChangesNo { get; private set; }

        public Radio ReceivingChildSupportYes { get; private set; }

        public Radio ReceivingChildSupportNo { get; private set; }

        public Dropdown EmploymentStatus { get; private set; }

        [KeywordTestingElementRequiresWait]
        public EditField Employer { get; private set; }

        public EditField CheckWages { get; private set; }

        public EditField CashWages { get; private set; }

        public EditField NonWorkCompensation { get; private set; }

        public EditField ChildSupport { get; private set; }

        public EditField Alimony { get; private set; }

        public EditField AdoptionBenefits { get; private set; }

        public EditField PublicAssistance { get; private set; }

        public EditField AdultSocialSecurity { get; private set; }

        public EditField ChildSocialSecurity { get; private set; }

        public EditField SupplementalSecurity { get; private set; }

        public EditField Pension { get; private set; }

        public EditField AllowanceBenefits { get; private set; }

        public EditField DeployedServiceMember { get; private set; }

        public EditField Annuities { get; private set; }

        public EditField Interest { get; private set; }

        public EditField MonthlyWithdrawals { get; private set; }

        public EditField OutsideAssistance { get; private set; }

        public EditField SelfEmployment { get; private set; }

        public EditField NetRental { get; private set; }

        public EditField OtherIncome { get; private set; }

        public EditField FosterOOHC { get; private set; }

        public CommonAdultInformationSection(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtFirstName\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"_txtMiddleName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtLastName\"]"));
            EmailAddress = new EditField(Driver, By.CssSelector("input[id$=\"_txtEmail\"]"));
            ReceivingChildSupportYes = new Radio(Driver, By.CssSelector("input[id$=\"_rbChildSupport_0\"]"));
            ReceivingChildSupportNo = new Radio(Driver, By.CssSelector("input[id$=\"_rbChildSupport_1\"]"));
            IncomeChangesYes = new Radio(Driver, By.CssSelector("input[id$=\"_rbSeasonalEmployment_0\"]"));
            IncomeChangesNo = new Radio(Driver, By.CssSelector("input[id$=\"_rbSeasonalEmployment_1\"]"));
            EmploymentStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlEmploymentStatus\"]"));
            Employer = new EditField(Driver, By.CssSelector("input[id$=\"_tbEmployerName\"]"));
            CheckWages = new EditField(Driver, By.CssSelector("input[id$=\"_ctl02_TBAmount\"]"));
            CashWages = new EditField(Driver, By.CssSelector("input[id$=\"_ctl03_TBAmount\"]"));
            NonWorkCompensation = new EditField(Driver, By.CssSelector("input[id$=\"_ctl04_TBAmount\"]"));
            ChildSupport = new EditField(Driver, By.CssSelector("input[id$=\"_ctl05_TBAmount\"]"));
            Alimony = new EditField(Driver, By.CssSelector("input[id$=\"_ctl06_TBAmount\"]"));
            AdoptionBenefits = new EditField(Driver, By.CssSelector("input[id$=\"_ctl07_TBAmount\"]"));
            PublicAssistance = new EditField(Driver, By.CssSelector("input[id$=\"_ctl08_TBAmount\"]"));
            AdultSocialSecurity = new EditField(Driver, By.CssSelector("input[id$=\"_ctl09_TBAmount\"]"));
            ChildSocialSecurity = new EditField(Driver, By.CssSelector("input[id$=\"_ctl10_TBAmount\"]"));
            SupplementalSecurity = new EditField(Driver, By.CssSelector("input[id$=\"_ctl11_TBAmount\"]"));
            Pension = new EditField(Driver, By.CssSelector("input[id$=\"_ctl12_TBAmount\"]"));
            AllowanceBenefits = new EditField(Driver, By.CssSelector("input[id$=\"_ctl13_TBAmount\"]"));
            DeployedServiceMember = new EditField(Driver, By.CssSelector("input[id$=\"_ctl14_TBAmount\"]"));
            Annuities = new EditField(Driver, By.CssSelector("input[id$=\"_ctl15_TBAmount\"]"));
            Interest = new EditField(Driver, By.CssSelector("input[id$=\"_ctl16_TBAmount\"]"));
            MonthlyWithdrawals = new EditField(Driver, By.CssSelector("input[id$=\"_ctl17_TBAmount\"]"));
            OutsideAssistance = new EditField(Driver, By.CssSelector("input[id$=\"_ctl18_TBAmount\"]"));
            SelfEmployment = new EditField(Driver, By.CssSelector("input[id$=\"_ctl19_TBAmount\"]"));
            NetRental = new EditField(Driver, By.CssSelector("input[id$=\"_ctl20_TBAmount\"]"));
            OtherIncome = new EditField(Driver, By.CssSelector("input[id$=\"_ctl21_TBAmount\"]"));
            FosterOOHC = new EditField(Driver, By.CssSelector("input[id$=\"_ctl22_TBAmount\"]"));
        }
    }
}
