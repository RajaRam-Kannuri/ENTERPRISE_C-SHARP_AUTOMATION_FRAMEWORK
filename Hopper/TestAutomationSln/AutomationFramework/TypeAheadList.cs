using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class TypeAheadList : WebElement
    {
        public TypeAheadList(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingTypeAheadList]
        public void Select(string item)
        {
            if (item == null)
                return;

            this.Click();
            List<IWebElement> spans = this.FindElements(By.TagName("span")).ToList();
            spans.Where(span => span.Text.Contains(item)).First().Click();
        }

        public void Select(string[] items)
        {
            if (items == null || items.Count() == 0)
                return;

            foreach (string item in items)
            {
                Select(item);
            }
        }

        [KeywordTestingTypeAheadList]
        [KeywordTestingVerificationMethod]
        public bool VerifyOptionExists(string option)
        {
            List<IWebElement> spans = this.FindElements(By.TagName("span")).ToList();
            IWebElement optionSpan = spans.Where(span => span.Text.Contains(option)).FirstOrDefault();
            return optionSpan != null;
        }

        [KeywordTestingTypeAheadList]
        [KeywordTestingVerificationMethod]
        public bool VerifyOptionDoesNotExist(string option)
        {
            return !VerifyOptionExists(option);
        }

        [KeywordTestingTypeAheadList]
        [KeywordTestingVerificationMethod]
        public bool VerifyOptionIsSelected(string option)
        {
            List<string> selectedItems = CollectSelectedItems();
            return selectedItems.Contains(option);
        }

        [KeywordTestingTypeAheadList]
        [KeywordTestingCollectionMethod]
        public List<string> CollectSelectedItems()
        {
            IWebElement selectedItemHolder = this.FindElement(By.CssSelector(".ui-select-match"));
            List<IWebElement> selectedItems = selectedItemHolder.FindElements(By.CssSelector(".ng-binding.ng-scope")).ToList();
            return selectedItems.Select(item => item.Text).ToList();
        }
    }
}
