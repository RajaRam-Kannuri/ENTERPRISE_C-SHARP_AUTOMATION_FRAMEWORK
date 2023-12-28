using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework
{
    [KeywordTesting]
    public class WebElement : IWebElement
    {
        protected readonly IWebDriver _driver;

        private By _locateBy;

        private int _index;

        public WebElement(IWebDriver driver, By locateBy, int index = 0)
        {
            this._locateBy = locateBy;
            this._driver = driver;
            _index = index;
        }

        public IWebElement Locate(int timeout = StringConstants.WebdriverWaitTime)
        {
            IWebElement element = null;
            try
            {
                if (_index == 0)
                {
                    element = _driver.FindElement(this._locateBy, timeout);
                }
                else
                {
                    List<IWebElement> allMatchingElements = _driver.FindElements(this._locateBy, timeout);
                    element = allMatchingElements[_index];
                }
            }
            catch (WebDriverTimeoutException)
            {
                List<string> errors = _driver.ErrorMessages();
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
                    element = _driver.FindElement(this._locateBy, timeout);
                }
                else
                {
                    List<IWebElement> allMatchingElements = _driver.FindElements(this._locateBy, timeout);
                    element = allMatchingElements[_index];
                }
            }
            catch (WebDriverTimeoutException)
            {
                List<string> errors = _driver.ErrorMessages();
            }

            return element;
        }

        public List<IWebElement> LocateAll(int timeout = StringConstants.WebdriverWaitTime)
        {
            List<IWebElement> elements = null;
            try
            {
                elements = _driver.FindElements(this._locateBy, timeout);
            }
            catch (WebDriverTimeoutException)
            {
                List<string> errors = _driver.ErrorMessages();
            }
            return elements;
        }

        public IWebElement LocateAndEnsureUsable(int timeout = StringConstants.WebdriverWaitTime)
        {
            IWebElement element = null;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.Until(ExpectedConditions.ElementIsVisible(_locateBy));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(_locateBy));
            element = _driver.FindElement(this._locateBy, timeout);

            return element;
        }

        public By LocateBy()
        {
            return this._locateBy;
        }

        public WebElement UpdateLocator(By locatedBy)
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

        [KeywordTestingEditField]
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
                _driver.SetChanged(this);
            }
        }

        public void Submit()
        {
            IWebElement elem = LocateAndEnsureUsable();
            if (elem != null) elem.Submit();
        }

        [KeywordTestingGeneral]
        public void Click()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(StringConstants.WebdriverWaitTime));
            wait.Until(ExpectedConditions.ElementIsVisible(this._locateBy));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(this._locateBy)).Click();
            }
            catch { }
        }

        [KeywordTestingGeneral]
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

        [KeywordTestingGeneral]
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

        [KeywordTestingGeneral]
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

        [KeywordTestingGeneral]
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

        [KeywordTestingGeneral]
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

        [KeywordTestingLink]
        [KeywordTestingText]
        public string Text
        {
            get
            {
                return this.Locate().Text;
            }
        }

        [KeywordTestingGeneral]
        public bool Enabled
        {
            get
            {
                return this.Locate().Enabled;
            }
        }

        [KeywordTestingRadio]
        [KeywordTestingCheckbox]
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

        [KeywordTestingGeneral]
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

        [KeywordTestingGeneral]
        public void MouseOver()
        {
            IWebElement element = Locate();
            Actions mouseOver = new Actions(_driver);
            mouseOver.MoveToElement(element).Perform();
        }

        /// <summary>
        /// Tries to retrieve an object matching the given description from within
        /// a page or a previously located WebElement.
        /// </summary>
        /// <param name="locateBy">The object locator</param>
        /// <param name="element">The IWebElement that receives the located item</param>
        /// <returns>Returns a boolean value determining if the item was located or not</returns>
        public bool TryGetElement(By locateBy, out IWebElement element)
        {
            return Locate().TryGetElement(locateBy, out element);
        }

        /// <summary>
        /// Tries to retrieve objects matching the given description from within
        /// a page or a previously located WebElement.
        /// </summary>
        /// <param name="locateBy">The object locator</param>
        /// <param name="elements">The IWebElement that receives the located items</param>
        /// <returns>Returns a boolean value determining if the items were located or not</returns>
        public bool TryGetElements(By locateBy, out List<IWebElement> elements)
        {
            return Locate().TryGetElements(locateBy, out elements);
        }

        [KeywordTestingGeneral]
        public string CollectUrl()
        {
            return _driver.Url;
        }

        [KeywordTestingGeneral]
        public bool VerifyElementExists()
        {
            return _driver.ElementExists(_locateBy);
        }

        [KeywordTestingGeneral]
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

        [KeywordTestingVerificationMethod]
        public bool VerifyElementIsHidden()
        {
            return !Exists() || !Displayed;
        }

        [KeywordTestingVerificationMethod]
        public bool VerifyElementIsVisible()
        {
            return !VerifyElementIsHidden();
        }

        [KeywordTestingGeneral]
        [KeywordTestingVerificationMethod]
        public bool VerifyElementIsDisabled()
        {
            return Exists() && !Enabled;
        }

        [KeywordTestingGeneral]
        [KeywordTestingVerificationMethod]
        public bool VerifyElementIsEnabled()
        {
            return !VerifyElementIsDisabled();
        }

		[KeywordTestingGeneral]
		[KeywordTestingVerificationMethod]
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

        [KeywordTestingFindMethod]
        public void FindInRepeatedControlGroup(object thingToFindBy)
        {
        }

		[KeywordTestingGeneral]
		public void GoToURL(String url)
		{
			_driver.Url = url;
		}

        [KeywordTestingGeneral]
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
