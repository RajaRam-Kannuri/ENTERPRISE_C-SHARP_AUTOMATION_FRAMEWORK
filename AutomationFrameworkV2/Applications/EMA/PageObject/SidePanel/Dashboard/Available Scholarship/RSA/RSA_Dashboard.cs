using System.Threading;
using Interfaces;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;

namespace SidePanelDashboard
{
    public class RSA_Dashboard : Widget
    {
        public RSA_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public string getHeader()
        {
            return FindText(By.XPath("(//h2)[1]")).GetText();
        }

        public RSA_Dashboard SelectStudent(string option)
        {
            FindTextField(By.Id("ddl_StudentName")).Click();
            FindTextField(By.XPath("//input[contains(@class,'rz-dropdown-filter rz-inputtext')]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public RSA_Dashboard SelectSchoolName(string option)
        {
            FindTextField(By.XPath("//input[contains(@class,'blazored-typeahead__input')]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//*[contains(@class,'blazored-typeahead__result blazored-typeahead__active-item')]")).Click();
            return this;
        }

        public RSA_Dashboard SelectGradeLevel(string option)
        {
            FindTextField(By.Id("ddl_StudentGradeLevel")).Click();
            FindTextField(By.XPath("(//input[contains(@class,'rz-inputtext')])[2]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public RSA_Dashboard ClickCurrentStatus()
        {
            FindCheckBox(By.XPath("//*[contains(@class,'rz-chkbox-box')]")).Click();
            return this;
        }

        public RSA_Dashboard UploadSupportingDocuments(string file)
        {
            FindImport(By.Id("inputDrop__"), file);
            return this;
        }

        public RSA_Dashboard ClickContinue()
        {
            FindButton(By.XPath("//button[text()='CONTINUE']")).Click();
            return this;
        }

        public RSA_Dashboard ClickPenalties()
        {
            Thread.Sleep(5000);
            MoveTo.Element(driver, driver.FindElement(By.XPath("//*[contains(@class,'rz-chkbox-box')]")));
            FindCheckBox(By.XPath("//*[contains(@class,'rz-chkbox-box')]")).Click();
            return this;
        }

        public RSA_Dashboard ClearName()
        {
            FindTextField(By.XPath("//input[@class='rz-textbox']")).Clear();
            return this;
        }

        public RSA_Dashboard TypeName(string name)
        {
            FindTextField(By.XPath("//input[@class='rz-textbox']")).Type(name);
            return this;
        }

        public RSA_Dashboard Signature()
        {
            MoveTo.Signature(driver, driver.FindElement(By.Id("signature-pad--canvas")));
            return this;
        }

        public RSA_Dashboard ClickKeep()
        {
            FindButton(By.XPath("//button[contains(text(),'Keep')]")).Click();
            return this;
        }

        public Dashboard_Dashboard ClickSubmit()
        {
            MoveTo.BottomOfPage(driver);
            FindButton(By.XPath("(//button[contains(text(),'Submit')])[2]")).Click();
            WaitFor.InvisiabilityOfElement(driver, By.XPath("(//button[contains(text(),'Submit')])[2]"));
            return new(driver);
        }

    }
}