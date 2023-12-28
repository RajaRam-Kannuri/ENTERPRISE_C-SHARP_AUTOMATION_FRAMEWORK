using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AutomationFramework
{
    public static class WebDriverExtensions
    {
        #region IWebDriver Extensions
        /// <summary>
        /// Returns the cookie string for the current session
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <returns>The cookie string</returns>
        public static string Cookies(this IWebDriver driver)
        {
            List<OpenQA.Selenium.Cookie> cookies = driver.Manage().Cookies.AllCookies.ToList();
            return string.Join("; ", cookies.Select(c => string.Format("{0}={1}", c.Name, c.Value)));
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the last opened child browser
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        public static void UseChild(this IWebDriver driver, int index = -1)
        {
            driver.WaitForPopUp();
            if (index == -1) index = driver.WindowHandles.Count - 1;
            driver.SwitchTo().Window(driver.WindowHandles[index]);
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the parent browser
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        public static void UseParent(this IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the given iFrame.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="element">The iFrame to use as context</param>
        public static void UseFrame(this IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the iFrame at the given index.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="index">The index of the iFrame to use as context</param>
        public static void UseFrame(this IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the "last" available iFrame.
        /// Useful for frames that do not have uniquely recognizable properties.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        public static void UseLastFrame(this IWebDriver driver)
        {
            List<IWebElement> allFrames = driver.FindElements(By.TagName("iframe")).ToList();
            if (allFrames.Count > 0)
            {
                driver.UseFrame(allFrames.Last());
            }
        }

        /// <summary>
        /// Tells WebDriver to operate in the context of the iFrame with the given name.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="frameName">The name property of the iFrame to use as context</param>
        public static void UseFrame(this IWebDriver driver, string frameName)
        {
            driver.SwitchTo().Frame(frameName);
        }

        /// <summary>
        /// Tells WebDriver to return to the default page context. Use after iFrame context
        /// operations are completed, as when closing modals, etc.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        public static void UseDefault(this IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Downloads the file at the given location, saving it to the indicated folder.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="url">A url representing the file location</param>
        /// <param name="localPath">The folder to use when saving the file</param>
        public static void DownloadFileFromUrl(this IWebDriver driver, string url, string localPath)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.Cookie] = driver.Cookies();
                client.DownloadFile(url, localPath);
            }
        }

        /// <summary>
        /// Opens the file at the given location into a data stream.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="url">A url representing the file location</param>
        /// <returns>Returns a Stream object representing the file.</returns>
        public static Stream OpenFileFromUrl(this IWebDriver driver, string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.Cookie] = driver.Cookies();
                return client.OpenRead(url);
            }
        }

        /// <summary>
        /// Examines the current page for error messages.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <returns>Returns a list containing any collected error messages</returns>
        public static List<string> ErrorMessages(this IWebDriver driver)
        {
            List<string> errList = new List<string>();

            // Server errors
            if (driver.PageSource.Contains("Server Error"))
            {
                errList.Add("Server Error encountered:");
                errList.Add(driver.PageSource);
            }

            // Error class elements
            if (driver.ElementExists(By.ClassName("error")))
            {
                driver.FindElements(By.ClassName("error")).ToList().ForEach(err => errList.Add(err.Text));
            }

            return errList;
        }

        /// <summary>
        /// Forces an element to recognize that it has been changed by calling the native blur method.
        /// Useful only for extremely stubborn UI elements.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="element">The element to be blurred</param>
        public static void ForceBlur(this IWebDriver driver, IWebElement element)
        {
            string elementId = element.GetAttribute("id");
            if (string.IsNullOrEmpty(elementId)) return;
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("return document.getElementById('{0}').blur()", elementId));
        }

        /// <summary>
        /// Forces an element to recognize that it has been changed by calling the native change method.
        /// Useful only for extremely stubborn UI elements.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        /// <param name="element">The element to be "changed"</param>
        public static void SetChanged(this IWebDriver driver, IWebElement element)
        {
            string elementId = element.GetAttribute("id");
            if (string.IsNullOrEmpty(elementId)) return;
            //((IJavaScriptExecutor)driver).ExecuteScript(string.Format("$('#{0}').change()", elementId));txtUN
            //((IJavaScriptExecutor)driver).ExecuteScript(string.Format("if (typeof jQuery != 'undefined') $('#{0}').change()", elementId));
        }

        /// <summary>
        /// Waits for a child browser to be opened.
        /// </summary>
        /// <param name="driver">An IWebDriver instance</param>
        public static void WaitForPopUp(this IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            wait.Until(drv => drv.WindowHandles.Count > 1);
        }

        public static void CloseChildren(this IWebDriver driver)
        {
            for (int i = driver.WindowHandles.Count - 1; i > 0; i--)
            {
                driver.SwitchTo().Window(driver.WindowHandles[i]);
                driver.Close();
            }
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        #endregion

        #region ISearchContext Extensions

        /// <summary>
        /// Finds an element either within the page, or within a previously located IWebElement,
        /// waiting the specified amount of time before failing. This compensates for most
        /// synchronization errors.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <param name="timeout">The amount of time to wait for the object to be available</param>
        /// <returns>Returns the located IWebElement</returns>
        /// <exception cref="NoSuchElementException">Returned if an element cannot be found by the given locator</exception>
        /// <exception cref="WebDriverTimeoutException">Returned if an element cannot is not found within the alloted time</exception>
        public static IWebElement FindElement(this ISearchContext context, By by, int timeout)
        {
            if (timeout > 0)
            {
                DefaultWait<ISearchContext> wait = new DefaultWait<ISearchContext>(context)
                {
                    PollingInterval = TimeSpan.FromMilliseconds(500),
                    Timeout = TimeSpan.FromSeconds(timeout)
                };
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                return wait.Until(ctx => ctx.FindElement(by));
            }

            return context.FindElement(by);
        }

        /// <summary>
        /// Finds elements either within the page, or within a previously located IWebElement,
        /// waiting the specified amount of time before failing. This compensates for most
        /// synchronization errors.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <param name="timeout">The amount of time to wait for the object to be available</param>
        /// <returns>Returns a collection of located IWebElements</returns>
        /// <exception cref="NoSuchElementException">Returned if an element cannot be found by the given locator</exception>
        /// <exception cref="WebDriverTimeoutException">Returned if an element cannot is not found within the alloted time</exception>
        public static List<IWebElement> FindElements(this ISearchContext context, By by, int timeout)
        {
            if (timeout > 0)
            {
                DefaultWait<ISearchContext> wait = new DefaultWait<ISearchContext>(context)
                {
                    PollingInterval = TimeSpan.FromMilliseconds(500),
                    Timeout = TimeSpan.FromSeconds(timeout)
                };
                wait.IgnoreExceptionTypes(new[] { typeof(NoSuchElementException), typeof(ElementNotVisibleException) });
                return wait.Until(ctx => (ctx.FindElements(by).Count > 0) ? ctx.FindElements(by).ToList() : null);
            }

            return context.FindElements(by).ToList();
        }

        /// <summary>
        /// Determines if a given object is present or not.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="elem">A WebElement object representing the object to look for</param>
        /// <returns>Returns a boolean value determining if the item was located or not</returns>
        public static bool ElementExists(this ISearchContext context, BaseElement elem)
        {
            return context.ElementExists(elem.LocateBy());
        }

        /// <summary>
        /// Determines if a given object is present or not.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <returns>Returns a boolean value determining if the item was located or not</returns>
        public static bool ElementExists(this ISearchContext context, By by)
        {
            try
            {
                context.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to retrieve an object matching the given description from within
        /// a page or a previously located IWebElement.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <param name="element">The IWebElement that receives the located item</param>
        /// <returns>Returns a boolean value determining if the item was located or not</returns>
        public static bool TryGetElement(this ISearchContext context, By by, out IWebElement element)
        {
            try
            {
                element = context.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                element = null;
                return false;
            }
        }

        /// <summary>
        /// Determines if any objects matching the given description are present or not.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <returns>Returns a boolean value determining if the items were located or not</returns>
        public static bool ElementsExist(this ISearchContext context, By by)
        {
            try
            {
                return context.FindElements(by).Count > 0;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to retrieve objects matching the given description from within
        /// a page or a previously located IWebElement.
        /// <para>
        /// ISearchContext is the interface that provides IWebDriver and IWebElement
        /// objects with the ability to locate child objects. We have used it here
        /// in place of either one of them to allow this method to be used for both.
        /// </para>
        /// </summary>
        /// <param name="context">An instance of an ISearchContext object</param>
        /// <param name="by">The object locator</param>
        /// <param name="elements">The IWebElement that receives the located items</param>
        /// <returns>Returns a boolean value determining if the items were located or not</returns>
        public static bool TryGetElements(this ISearchContext context, By by, out List<IWebElement> elements)
        {
            try
            {
                elements = context.FindElements(by).ToList();
                return elements.Count > 0;
            }
            catch (NoSuchElementException)
            {
                elements = null;
                return false;
            }
        }

        #endregion

        #region IWebElement Extensions

        /// <summary>
        /// Retrieves the rows from a table, table header, or table body.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns a List of IWebElements representing the table rows</returns>
        ///
        public static List<IWebElement> Rows(this IWebElement element)
        {
            return element.FindElements(By.TagName("tr"), 1);
        }

        /// <summary>
        /// Retrieves the body of a table.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns an IWebElement representing the table body</returns>
        public static IWebElement Body(this IWebElement element)
        {
            return element.FindElement(By.TagName("tbody"), 1);
        }

        /// <summary>
        /// Retrieves the cells from a table row.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns a List of IWebElements representing the row cells</returns>
        public static List<IWebElement> Cells(this IWebElement element)
        {
            return element.FindElements(By.TagName("td"), 1);
        }

        /// <summary>
        /// Retrieves the cells from a table header.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns a List of IWebElements representing the header cells</returns>
        public static List<IWebElement> HeaderCells(this IWebElement element)
        {
            return element.FindElements(By.TagName("th"), 1).ToList();
        }

        /// <summary>
        /// Retrieves the header of a table.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns an IWebElement representing the table header</returns>
        public static IWebElement Header(this IWebElement element)
        {
            return element.FindElement(By.TagName("thead"), 1).Rows()[0];
        }

        /// <summary>
        /// Retrieves the footer of a table.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be searched</param>
        /// <returns>Returns an IWebElement representing the table footer</returns>
        public static IWebElement Footer(this IWebElement element)
        {
            return element.FindElement(By.TagName("tfoot"), 1).Rows()[0];
        }

        /// <summary>
        /// Retrieves a description of the given IWebElement based on its tag properties.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be examined</param>
        /// <returns>Returns a string describing the object</returns>
        public static string GetDescription(this IWebElement element)
        {
            string elementTag = element.TagName;
            string elementType, elementDesc = string.Empty;
            switch (elementTag)
            {
                case "a":
                    elementType = "link";
                    break;
                case "input":
                    elementType = element.GetAttribute("type");
                    break;
                default:
                    elementType = elementTag;
                    break;
            }

            if (!string.IsNullOrEmpty(element.GetAttribute("id")))
            {
                elementDesc = element.GetAttribute("id");
            }
            else if (!string.IsNullOrEmpty(element.GetAttribute("name")))
            {
                elementDesc = element.GetAttribute("name");
            }
            else if (!string.IsNullOrEmpty(element.Text))
            {
                elementDesc = element.Text;
            }
            else if (!string.IsNullOrEmpty(element.GetAttribute("title")))
            {
                elementDesc = element.GetAttribute("title");
            }
            else if (!string.IsNullOrEmpty(element.GetAttribute("class")))
            {
                elementDesc = element.GetAttribute("class");
            }

            return string.Format("{0} {1}", elementDesc, elementType);
        }

        /// <summary>
        /// Selects a random item from a select list.
        /// </summary>
        /// <param name="list">An IWebElement representing the list to be used.</param>
        /// <param name="startingIndex">An integer representing the starting index from which to select. Use to skip instructional entries, such as "Select ..."</param>
        public static void SelectRandom(this IWebElement list)
        {
            IList<IWebElement> options = list.FindElements(By.TagName("option"));
            int idx = new Random().Next(1, options.Count - 1);
            //list.Select(options[idx].Text);
            options[idx].Click();
        }

        public static void SelectRandom(this IWebElement list, String item)
        {
            if (item == null) return;
            var options = list.FindElements(By.TagName("li"));
            int idx = new Random().Next(1, options.Count - 1);

            try
            {
                options[idx].Click();
            }
            catch { }
        }

        public static bool VerifyOptionExists(this IWebElement list, object option)
        {
            if (option == null) return false;
            list.Click();
            Thread.Sleep(3000);

            IList<IWebElement> options = list.FindElements(By.TagName("option"));
            IWebElement desiredOption = options.Where(op => op.Text.Contains(option.ToString())).ToList().FirstOrDefault();
            return desiredOption != null;
        }

        public static void SelectByPartialText(this IWebElement list, String item)
        {
            if (item == null) return;
            var options = list.FindElements(By.TagName("li"));

            foreach (var option in options)
            {
                if (option.Text.Contains(item))
                {
                    option.Click();
                    break;
                }
            }
        }

        public static void SelectByPartialTextIfDisplayed(this IWebElement list, String item)
        {
            try
            {
                if (item == null) return;
                var options = list.FindElements(By.TagName("li"));

                foreach (var option in options)
                {
                    if (option.Text.Contains(item))
                    {
                        option.Click();
                        break;
                    }
                }
            }
            catch { }
        }

        public static void SelectFirstOption(this IWebElement list, object item)
        {
            if (item == null) return;
            list.Click();
            IList<IWebElement> options = list.FindElements(By.TagName("option"));
            IWebElement desiredOption = options.First();
            if (desiredOption != null)
                desiredOption.Click();
        }

        public static void SelectLastOption(this IWebElement list, object item)
        {
            IWebElement desiredOption;
            if (item == null) return;
            list.Click();
            IList<IWebElement> options = list.FindElements(By.TagName("option"));
            int count = options.Count();

            if (count > 2)
                desiredOption = options[count - 2];
            else
                desiredOption = options.Last();

            if (desiredOption != null)
                desiredOption.Click();
        }

        public static List<string> GetOptions(this IWebElement list)
        {
            List<string> options = new List<string>();
            list.FindElements(By.TagName("option")).ToList().ForEach(option =>
            {
                if (option.Text != "-Select-") options.Add(option.Text);
            });
            return options;
        }

        /// <summary>
        /// Returns whether or not an element is read-only.
        /// </summary>
        /// <param name="element">An IWebElement representing the object to be examined</param>
        /// <returns>Returns a boolean to indicate whether or not the element is read-only</returns>
        //[KeywordTestingGeneral]
        public static bool VerifyElementIsReadOnly(this IWebElement element)
        {
            string readOnly = element.GetAttribute("readOnly");
            return readOnly != null && (readOnly == "True" || readOnly == "true");
        }

        /// <summary>
        /// Sets the state of a checkbox.
        /// </summary>
        /// <param name="checkbox">An IWebElement representing the checkbox to be used.</param>
        /// <param name="state">The desired checkbox state</param>
        public static void Set(this IWebElement checkbox, bool? state)
        {
            if (state == null) return;

            if (checkbox.Selected != state)
            {
                checkbox.Click();
            }
        }

        /// <summary>
        /// Sets the state of a checkbox.
        /// </summary>
        /// <param name="checkbox">An IWebElement representing the checkbox to be used.</param>
        /// <param name="state">The desired checkbox state</param>
        public static void Set(this IWebElement checkbox, object state)
        {
            if (state == null) return;
            string objectType = state.GetType().ToString();
            if (objectType == "System.String")
            {
                string stateAsString = (string)state;
                List<string> onValues = new List<string>() { "on", "true" };
                Set(checkbox, onValues.Any(onValue => onValue.Equals(stateAsString, StringComparison.CurrentCultureIgnoreCase)));
            }
            else if (objectType == "System.Boolean")
            {
                Set(checkbox, state);
            }
            else if (objectType == "System.Int32")
            {
                Set(checkbox, (int)state == 1);
            }
        }

        /// <summary>
        /// Clears the given text field and enters the provided text.
        /// </summary>
        /// <param name="textField">An IWebElement representing the textbox to be used.</param>
        /// <param name="data">The data to enter into the field.</param>
        public static void SetText(this IWebElement textField, object data)
        {
            if (data == null) return;
            //textField.Clear();
            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(data.ToString());
        }

        public static void SetTextIfDisplayed(this IWebElement textField, object data)
        {
            try
            {
                SetText(textField, data);
            }
            catch { }
        }

        public static void SetRandomNumber(this IWebElement textField, object data)
        {
            Random rnd = new Random();
            //textField.Clear();
            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(rnd.Next(0, 10000000).ToString());
        }

        public static void SetRandomEmailAddress(this IWebElement textField, object data)
        {
            Random rnd = new Random();
            //textField.Clear();
            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(rnd.Next(0, 10000000).ToString() + "@hopper.com");
        }

        public static void SetEmailAddressFromCSVForEO(this IWebElement textField, object data)
        {
            List<string> emails = new List<string>();
            string path = @"C:\KWDT Temp Repo\emailsEO.csv";

            using (var reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    emails.Add(values[0]);
                }
            }

            string email = emails[1];
            emails.Remove(emails[1]);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in emails)
                    writer.WriteLine(line);
            }

            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(email);
        }

        public static void SetEmailAddressFromCSVForUA(this IWebElement textField, object data)
        {
            List<string> emails = new List<string>();
            string path = @"C:\KWDT Temp Repo\emailsUA.csv";

            using (var reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    emails.Add(values[0]);
                }
            }

            string email = emails[1];
            emails.Remove(emails[1]);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in emails)
                    writer.WriteLine(line);
            }

            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(email);
        }

        public static void SetTodaysDate(this IWebElement textField, object data)
        {
            DateTime thisDay = DateTime.Today;
            //textField.Clear();
            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(thisDay.ToString("d"));
        }

        public static void SetRandomSSN(this IWebElement textField, object data)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(0000, 9999);

            string unformattedSSN = "21114" + rndNum.ToString();
            string formattedSSN = unformattedSSN.Insert(5, "-").Insert(3, "-");
            textField.SendKeys(Keys.Control + "a");
            textField.SendKeys(Keys.Delete);
            textField.SendKeys(formattedSSN);
        }

        /// <summary>
        /// Appends the provided text to the existing contents of the given text field
        /// </summary>
        /// <param name="textField">An IWebElement representing the textbox to be used.</param>
        /// <param name="data">The data to enter into the field.</param>
        public static void AppendText(this IWebElement textField, String data)
        {
            //string currentText = textField.GetAttribute("Value");

            //SetText(textField, currentText + " " + data);
            //string currentText2 = textField.ge("Value");
            textField.SendKeys(data);
        }

        /// <summary>
        /// Returns the contents of the value attribute
        /// </summary>
        /// <param name="textField">An IWebElement representing the textbox to be used.</param>
        public static string Value(this IWebElement textField)
        {
            return textField.GetAttribute("value");
        }

        #endregion

        #region Other Extensions

        /// <summary>
        /// Collects the message from an IAlert dialog and returns a reference
        /// to the dialog to allow it to be handled.
        /// </summary>
        /// <param name="alert">An instance of an IAlert dialog</param>
        /// <param name="alertText">The dialog message</param>
        /// <returns>Returns a reference to the IAlert object</returns>
        public static string GetText(this IAlert alert)
        {
            return alert.Text;
        }

        public static void EnterTextIntoAndCloseAlert(this IWebDriver driver, IWebElement triggerElement, object text)
        {
            string currentWindow = driver.CurrentWindowHandle;
            triggerElement.Click();
            driver.SwitchTo().Alert().SendKeys(text.ToString());
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Window(currentWindow);
        }

        public static void ExecuteSqlQuery(this IWebElement textField, object data)
        {
        }

        public static void ExecuteSqlQueryUseSecondaryDataIfQueryNull(this IWebElement textField, object data)
        {
            SetText(textField, data);
        }

        public static bool ExecuteSqlQueryAndVerifyResultEquals(this IWebElement textField, object data, object data2)
        {
            return data.ToString().Equals(data2.ToString());
        }

        public static string ExecuteSqlQueryAndCollectValue(this IWebElement textField, string data)
        {
            return data;
        }

        public static void RunCommandLineCommand(this IWebElement textField, string command)
        {
            string strCmdText;
            strCmdText = "cd..";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        public static string CollectPrimaryDataValue(this IWebElement textField, string data)
        {
            return data;
        }

        public static void ForceWaitForHowManySeconds(this IWebElement textField, String time)
        {
            int wait = Convert.ToInt32(time);
            if (wait < 1) wait = 1;

            Thread.Sleep(wait * 1000);
        }

        public static bool VerifyPrimaryDataEqualsSecondaryData(this IWebElement textField, object data1, object data2)
        {
            if (String.Equals(data1, data2))
                return true;

            return false;
        }

        public static void APITEST(this IWebElement textField, object data)
        {
            string URL = "https://sufsolaapitest.azurewebsites.net/v1/ping";
            string urlParameters = "?api_key=123";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJSUzI1NiIsImtpZCI6IjFmZjk2MWZjNjNkYTFhZTAyYmNlMWRjMTM3NTNhZTYxIiwidHlwIjoiSldUIn0.eyJuYmYiOjE0OTUxMjE0ODgsImV4cCI6MTQ5NTEyNTA4OCwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMzEiLCJhdWQiOlsiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMzEvcmVzb3VyY2VzIiwib2xhYXBpIl0sImNsaWVudF9pZCI6Im1pY3JvU2VydmljZSIsInNjb3BlIjpbIm9sYWFwaSJdfQ.MaW7mgwqphImHZcpPGwm_AHPREs9bcwZ-_3yto3CcWpFx0T5xyD89D6LIyF6imIgrpxy-TGoDl5Ukckept0AI4g6JuhvYddk9XQfDJ4WciUbdTRSnRCaf98G95a8lzoowmiT6861HZLb49_NLfi6fdtfDk03_9UymePZTStj5cPjIQ1hS7b414CDv19kJhQwTAwoAd8dYiObHj9rnUHnxYXulJ62GMfdVRXt9xOWAMqbr6UdIUiwZTZ9xV9WU2LpHU1L1_Sfubbzvq0vRFOAj5i0GZwJk2gRtFR1s9kRWH8E955WVjeG3rrDLhGRl7PrbAhphsxZ5b0zHVe4yWcDkg");

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();
        }
        #endregion
    }
}