using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework
{
    public class BaseElement : IWebElement
    {
        protected readonly IWebDriver _driver;

        private By _locateBy;

        private int _index;

        public BaseElement(IWebDriver driver, By locateBy, int index = 0)
        {
            this._locateBy = locateBy;
            this._driver = driver;
            _index = index;
        }

        public IWebElement Locate(int timeout = 10)
        {
            IWebElement element = null;
            try
            {
                if (_index == 0)
                {
                    element = _driver.FindElement(this._locateBy);
                }
                //else
                //{
                //    List<IWebElement> allMatchingElements = _driver.FindElements(this._locateBy);
                //    element = allMatchingElements[_index];
                //}
            }
            catch (WebDriverTimeoutException)
            {
            }

            return element;
        }

        public IWebElement LocateExtended(int timeout = 60)
        {
            IWebElement element = null;
            try
            {
                if (_index == 0)
                {
                    element = _driver.FindElement(this._locateBy);
                }
                else
                {
                    List<IWebElement> allMatchingElements = _driver.FindElements(this._locateBy, timeout);
                    element = allMatchingElements[_index];
                }
            }
            catch (WebDriverTimeoutException)
            {
            }

            return element;
        }

        //public List<IWebElement> LocateAll(int timeout = 10)
        //{
        //    List<IWebElement> elements = null;
        //    try
        //    {
        //        elements = _driver.FindElements(this._locateBy);
        //    }
        //    catch (WebDriverTimeoutException)
        //    {
        //    }
        //    return elements;
        //}

        public IWebElement LocateAndEnsureUsable(int timeout = 10)
        {
            IWebElement element = null;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.Until(ExpectedConditions.ElementIsVisible(_locateBy));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(_locateBy));
            element = _driver.FindElement(this._locateBy);

            return element;
        }

        public By LocateBy()
        {
            return this._locateBy;
        }

        public BaseElement UpdateLocator(By locatedBy)
        {
            _locateBy = locatedBy;
            return this;
        }

        public IWebElement FindElement(By @by)
        {
            return this.Locate().FindElement(@by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return this.Locate().FindElements(@by);
        }

        public void Clear()
        {
            this.LocateAndEnsureUsable();
            this.SendKeys(Keys.Control + "a");
            this.SendKeys(Keys.Delete);
        }

        public void SendKeys(string text)
        {
            IWebElement elem = LocateAndEnsureUsable();
            if (elem != null && text != null)
            {
                elem.SendKeys(text);
            }
        }

        public void Submit()
        {
            IWebElement elem = LocateAndEnsureUsable();
            if (elem != null) elem.Submit();
        }

        public void Click()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(this._locateBy));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(this._locateBy)).Click();
            }
            catch { }
        }

        public bool ClickIfDisplayed()
        {
            try
            {
                Locate().Click();
            }
            catch
            { }

            return true;
        }

        public bool ClickIfDisplayedExtendedTimeout()
        {
            try
            {
                LocateExtended().Click();
            }
            catch
            { }

            return true;
        }

        public bool ClickIfURLContainsValue(string url)
        {
            try
            {
                String currentUrl = _driver.Url;

                if (currentUrl.Contains(url))
                    Locate(0).Click();
            }
            catch
            { }

            return true;
        }

        public bool CloseCurrentBrowserTab()
        {
            try
            {
                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
                _driver.Close();
                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            }
            catch
            { }

            return true;
        }

        public bool SwitchToLastBrowserTab()
        {
            try
            {
                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            }
            catch
            { }

            return true;
        }

        public string GetAttribute(string attributeName)
        {
            IWebElement elem = LocateAndEnsureUsable();
            return elem != null ? elem.GetAttribute(attributeName) : null;
        }

        public string GetCssValue(string propertyName)
        {
            IWebElement elem = LocateAndEnsureUsable();
            return elem != null ? elem.GetCssValue(propertyName) : null;
        }

        public string TagName
        {
            get
            {
                return this.Locate().TagName;
            }
        }

        public string Text
        {
            get
            {
                return this.Locate().Text;
            }
        }

        public bool Enabled
        {
            get
            {
                return this.Locate().Enabled;
            }
        }

        public bool Selected
        {
            get
            {
                return this.Locate().Selected;
            }
        }

        public Point Location
        {
            get
            {
                return this.Locate().Location;
            }
        }

        public Size Size
        {
            get
            {
                return this.Locate().Size;
            }
        }

        public bool Displayed
        {
            get
            {
                try
                {
                    return Locate(0).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public void MouseOver()
        {
            IWebElement element = Locate();
            Actions mouseOver = new Actions(_driver);
            mouseOver.MoveToElement(element).Perform();
        }

        public string CollectUrl()
        {
            return _driver.Url;
        }

        public bool VerifyElementExists()
        {
            return _driver.ElementExists(_locateBy);
        }

        public bool VerifyElementDoesNotExist()
        {
            return !_driver.ElementExists(_locateBy);
        }

        public bool Exists()
        {
            return _driver.ElementExists(_locateBy);
        }

        public bool IsAvailable()
        {
            return Exists() && Displayed;
        }

        public bool VerifyElementIsHidden()
        {
            return !Exists() || !Displayed;
        }

        public bool VerifyElementIsVisible()
        {
            return !VerifyElementIsHidden();
        }

        public bool VerifyElementIsDisabled()
        {
            return Exists() && !Enabled;
        }

        public bool VerifyElementIsEnabled()
        {
            return !VerifyElementIsDisabled();
        }

        public bool VerifyElementIsNotClickable()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

                wait.Until(ExpectedConditions.ElementToBeClickable(this));
                return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public bool HasElements(By locateBy)
        {
            return Locate().ElementsExist(locateBy);
        }

        public void FindInRepeatedControlGroup(object thingToFindBy)
        {
        }

        public void GoToURL(String url)
        {
            _driver.Url = url;
        }

        public void GoBackToPreviousPage()
        {
            _driver.Navigate().Back();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}