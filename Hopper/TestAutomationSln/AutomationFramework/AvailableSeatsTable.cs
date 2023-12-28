using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    [KeywordTesting]
    public class AvailableSeatsTable : WebElement
    {
        public AvailableSeatsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyTotalFESEOAwardedAndEnrolledEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[12].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyTotalFESEOAwardedAndEnrolledPriorDayChangeEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[14].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyTotalEstimatedFESEOCapExclusionsEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[18].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUACurrentAwardedEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[26].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUACurrentAwardedPriorDayChangeEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[28].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyTotalEstimatedFESUACapExclusionsEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[32].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalMilitaryEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[40].Text;

            try {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalFosterEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[44].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalAdoptedEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[48].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalLawEnforcementEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[52].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalPriorPublicAndDirectCertEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[56].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalPriorPublicAndFPL185Equals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[60].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESEOTotalPriorPublicAndOOHEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[64].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUAFloridaVPKEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[70].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUATotalMilitaryEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[74].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUATotalFosterEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[78].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUATotalAdoptedEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[82].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUATotalLawEnforcementEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[86].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUAPriorSchoolForDeafAndBlindEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[90].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }

        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUAPriorPublicEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[94].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }
               
        [KeywordTestingAvailableSeatsTable]
        public bool VerifyFESUAPriorMcKayEquals(string value)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("div"));

            string text = lineItems[108].Text;

            try
            {
                text = text.Replace(",", "");
            }
            catch { }

            if (text.Equals(value))
                return true;

            return false;
        }
    }
}
