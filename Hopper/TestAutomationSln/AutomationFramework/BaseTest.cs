using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace AutomationFramework
{
    [TestClass]
    public class BaseTest
    {
        protected PageMinder Minder;

        protected bool TestPassed;

        private List<string> Failures; 
        
        protected static string Environment;

        protected static TestContext _testContext;

        public TestContext TestContext
        {
            get
            {
                return _testContext;
            }

            set
            {
                _testContext = value;
            }
        }

        public BaseTest()
        {
            Failures = new List<string>();
            TestPassed = true;
        }
        
        /// <summary>
        /// Adds a list of strings to the test log.
        /// </summary>
        /// <param name="items">A List of strings to be added</param>
        public void AddListToLog(List<string> items)
        {
            foreach (string item in items)
            {
                Logger.Log(item);
            }
        }

        /// <summary>
        /// Verifies that there are no errors indicated on the given page.
        /// </summary>
        /// <param name="pg">A page object representing the page to be checked.</param>
        /// <param name="pageDescription">A string describing the page</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool VerifyNoPageErrors(BasePage pg, string pageDescription)
        {
            bool ret = true;
            UIElementManager.WaitForPageLoad(pg.Driver);
            List<string> errors = pg.ErrorMessages();
            if (errors.Count > 0)
            {
                Logger.Log("FAILED: Errors encountered on {0}", pageDescription);
                AddListToLog(errors);
                ret = false;
            }

            TestPassed &= ret;
            return ret;
        }

        /// <summary>
        /// Verifies whether one collection is correctly represented within another. Used most commonly
        /// for comparing test results to search criteria, or field contents before and after an event.
        /// </summary>
        /// <param name="controlSet">The initial set of data (search criteria, initial fields, etc.)</param>
        /// <param name="testSet">The set of affected data (search results, fields after an event, etc.)</param>
        /// <param name="message">The message to be reported as part of each verification. This needs to reflect the purpose of the test.</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool CompareDictionaries(Dictionary<string, string> controlSet, Dictionary<string, string> testSet, string message)
        {
            bool dataMatches = true;
            foreach (KeyValuePair<string, string> item in testSet)
            {
                string val;
                if (controlSet.TryGetValue(item.Key, out val))
                {
                    dataMatches &= VerifyEqual(item.Value, val, string.Format("{0}: {1}", message, item.Key));
                }
            }

            TestPassed &= dataMatches;
            return dataMatches;
        }

        /// <summary>
        /// Verifies whether or not a given element is displayed on the current page.
        /// </summary>
        /// <param name="element">The element to be examined</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool VerifyDisplayed(IWebElement element)
        {
            return Verify(element.Displayed, string.Format("The {0} {1}.", element.GetDescription(), element.Displayed ? " is displayed" : " is not displayed"));
        }

        /// <summary>
        /// Verifies whether two values are equal.
        /// </summary>
        /// <typeparam name="T">The type of the values being compared</typeparam>
        /// <param name="actual">The actual value taken from the UI/DB</param>
        /// <param name="expected">The expected value</param>
        /// <param name="message">A log message used to describe the verification.</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool VerifyEqual<T>(T actual, T expected, string message)
        {
            return Verify(Equals(actual, expected), message, actual.ToString(), expected.ToString());
        }

        public bool VerifyEqual<T>(T actual, T expected, string format, params object[] args)
        {
            return Verify(Equals(actual, expected), String.Format(format, args), actual.ToString(), expected.ToString());
        }

        /// <summary>
        /// Verifies that a link returns status code 200. Used primarily for testing downloads.
        /// </summary>
        /// <param name="url">The download url to be tested</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool VerifyLinkResponseOk(string url)
        {
            int statusCode = Minder.GetLinkResponse(url);
            Verify(statusCode == 200, string.Format("Verifying that a {0} response was returned by {1}", statusCode, url));
            return TestPassed;
        }

        /// <summary>
        /// Verifies a condition and logs the given message. If the condition evaluates
        /// to false, the actual and expected parameters are used to further qualify the
        /// condition in the log.
        /// </summary>
        /// <param name="condition">A boolean value or an expression that evaluates to a boolean value.</param>
        /// <param name="message">A log message describing the verification</param>
        /// <param name="actual">A string representing the "actual" result.</param>
        /// <param name="expected">A string representing the "expected" result.</param>
        /// <returns>Returns a boolean value to indicate success or failure</returns>
        public bool Verify(bool condition, string message, string actual = "", string expected = "")
        {
            string result = condition ? "PASSED" : "FAILED";
            string details = string.Empty;
            if (!condition)
            {
                if (actual == string.Empty) actual = "*Nothing*";
                if (expected == string.Empty) expected = "*Nothing*";
                details = actual == "*Nothing*" && expected == "*Nothing*"  ? string.Empty : ", Actual: " + actual + ", Expected: " + expected;
                Failures.Add(message + details);
            }

            Logger.Log("{0}: {1}{2}", result, message, details);
            TestPassed &= condition;
            return condition;
        }

        /// <summary>
        /// Used when we find a preventative fail condition in the middle
        /// of a test. Will also log any errors we found along the way.
        /// </summary>
        /// <param name="msg">A string to describe the failure</param>
        /// <param name="args">An array of objects to be inserted at any given position markers</param>
        public void AssertAndLogFailure(string msg, params object[] args)
        {
            Failures.Add(string.Format(msg, args));
            Assert.Fail("Failed Verifications:\n{0}", string.Join("\n", Failures));
        }

        /// <summary>
        /// Used when we find a fail condition in the middle of a test
        /// that MIGHT prevent us from continuing. Will also log any
        /// errors we found along the way.
        /// </summary>
        /// <param name="condition">The boolean condition being asserted</param>
        /// <param name="msg">A string to describe the condition being asserted</param>
        /// <param name="args">An array of objects to be inserted at any given position markers</param>
        public void AssertAndLog(bool condition, string msg, params object[] args)
        {
            if (!condition)
            {
                Failures.Add(string.Format(msg, args));
            }

            Assert.IsTrue(TestPassed, "Failed Verifications:\n{0}", string.Join("\n", Failures));
        }

        /// <summary>
        /// Used at the end of every test to assert against the TestPassed
        /// variable and to log any errors we found along the way.
        /// </summary>
        public void AssertAndLogFinalResults()
        {
            AssertAndLog(TestPassed, "Test Completed");
        }
    }
}
