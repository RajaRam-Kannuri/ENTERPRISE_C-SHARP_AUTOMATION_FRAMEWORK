using Interfaces;
using Login_Dashboard;
using OpenQA.Selenium;
using SidePanelDashboard;
using UserProfile;

namespace NLPLogix.Core.Abstract
{
    public abstract class Dashboard
    {

        protected IWebDriver driver;

        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;
        }

        By spinner = By.XPath("//*[@class='spinner-border'][@role='loading']");

        public Button FindButton(By by)
        {
            try
            {
                WaitFor.InvisiabilityOfElement(driver, spinner);
                WaitFor.WaitForElementToBeVisiable(driver, by);
                WaitFor.WaitForElementToBeClickable(driver, by);
                WaitFor.InvisiabilityOfElement(driver, spinner);
                MoveTo.Element(driver, driver.FindElement(by));
            }
            catch(ElementClickInterceptedException)
            {
                WaitFor.InvisiabilityOfElement(driver, spinner);
                WaitFor.WaitForElementToBeVisiable(driver, by);
                WaitFor.WaitForElementToBeClickable(driver, by);
                WaitFor.InvisiabilityOfElement(driver, spinner);
                MoveTo.Element(driver, driver.FindElement(by));
            }

            try
            {
                return new Button(driver, driver.FindElement(by));
            }
            catch (InvalidElementStateException)
            {
                return new Button(driver, driver.FindElement(by));
            }
        }

        public Checkbox FindCheckBox(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.WaitForElementToBeClickable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.Element(driver, driver.FindElement(by));
            try
            {
                return new Checkbox(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new Checkbox(driver, driver.FindElement(by));
            }
        }

        public Dropdown FindDropdown(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                return new Dropdown(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new Dropdown(driver, driver.FindElement(by));
            }
        }

        public Image FindImage(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                return new Image(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new Image(driver, driver.FindElement(by));
            }
        }

        public void FindImport(By by, string file)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                new Import(driver, driver.FindElement(by)).SelectFile(file);
            }
            catch(InvalidElementStateException)
            {
                new Import(driver, driver.FindElement(by)).SelectFile(file);
            }
        }

        public RadioButton FindRadioButton(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.WaitForElementToBeClickable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.Element(driver, driver.FindElement(by));
            try
            {
                return new RadioButton(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new RadioButton(driver, driver.FindElement(by));
            }
        }

        public Table FindTable(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                return new Table(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new Table(driver, driver.FindElement(by));
            }
        }

        public Text FindText(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                return new Text(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new Text(driver, driver.FindElement(by));
            }
        }

        public TextField FindTextField(By by)
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            WaitFor.WaitForElementToBeVisiable(driver, by);
            WaitFor.InvisiabilityOfElement(driver, spinner);
            try
            {
                return new TextField(driver, driver.FindElement(by));
            }
            catch(InvalidElementStateException)
            {
                return new TextField(driver, driver.FindElement(by));
            }
        }

        public Dashboard_Dashboard ClickDashboard()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'Dashboard')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new Dashboard_Dashboard(driver);
        }

        public Reimbursement_Dashboard ClickReimbursement()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'Reimbursement')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new Reimbursement_Dashboard(driver);
        }

        public MyStudent_Dashboard ClickMyStudents()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'MyStudents')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new MyStudent_Dashboard(driver);
        }

        public MarketPlace_Dashboard ClickMarketPlace()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'Marketplace')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new MarketPlace_Dashboard(driver);
        }

        public RecentTransaction_Dashboard ClickRecentTransaction()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'RecentTransactions')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new RecentTransaction_Dashboard(driver);
        }

        public Help_Dashboard ClickHelp()
        {
            WaitFor.InvisiabilityOfElement(driver, spinner);
            MoveTo.TopOfPage(driver);
            FindText(By.XPath("//a[contains(@href, 'Help')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, spinner);
            return new Help_Dashboard(driver);
        }

        public LoginDashboard ClickLogOut()
        {
            FindButton(By.Id("profileDropdown")).Click();
            FindButton(By.XPath("//a[@href='#']")).Click();
            return new(driver);
        }

        public UserProfile_Dashboard ClickEditProfile()
        {
            FindButton(By.Id("profileDropdown")).Click();
            FindButton(By.XPath("//div[contains(@class,'dropdown-menu')]//*[contains(@class,'btn-danger')]")).Click();
            return new(driver);
        }

    }
}
