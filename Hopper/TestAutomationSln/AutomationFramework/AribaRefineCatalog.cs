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
    public class AribaRefineCatalog : WebElement
    {
        public AribaRefineCatalog(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingAribaRefineCatalog]
        public bool SelectSupplierByName (string text)
        {
            try
            {
                _driver.FindElement(By.CssSelector("#search-facet-Supplier-group > span:nth-child(4) > a")).Click();
            }
            catch { }

            IWebElement supplierSection = _driver.FindElement(By.Id("search-facet-Supplier-group"));

            IList<IWebElement> suppliers = supplierSection.FindElements(By.TagName("div"));

            foreach (var supplier in suppliers)
            {
                if (supplier.Text.Contains(text) && suppliers.IndexOf(supplier) > 1)
                {
                    IList<IWebElement> checkbox = supplier.FindElements(By.TagName("input"));
                    checkbox[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingAribaRefineCatalog]
        public bool SelectManufacturerByName(string text)
        {
            try
            {
                _driver.FindElement(By.CssSelector("#search-facet-Manufacturer-group > span:nth-child(4) > a")).Click();
            }
            catch { }

            IWebElement manufacturerSection = _driver.FindElement(By.Id("search-facet-Manufacturer-group"));

            IList<IWebElement> manufacturers = manufacturerSection.FindElements(By.TagName("div"));

            foreach (var manufacturer in manufacturers)
            {
                if (manufacturer.Text.Contains(text) && manufacturers.IndexOf(manufacturer) > 1)
                {
                    IList<IWebElement> checkbox = manufacturer.FindElements(By.TagName("input"));
                    checkbox[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingAribaRefineCatalog]
        public bool SelectCategoryByName(string text)
        {
            try
            {
                _driver.FindElement(By.CssSelector("#search-facet-Category-group > span:nth-child(4) > a")).Click();
            }
            catch { }

            IWebElement categorySection = _driver.FindElement(By.Id("search-facet-Category-group"));

            IList<IWebElement> categories = categorySection.FindElements(By.TagName("div"));

            foreach (var category in categories)
            {
                if (category.Text.Contains(text) && categories.IndexOf(category) > 1)
                {
                    IList<IWebElement> checkbox = category.FindElements(By.TagName("input"));
                    checkbox[0].Click();
                    return true;
                }
            }

            return false;
        }
    }
}
