using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework
{
    [KeywordTesting]
    public class Dropdown : WebElement
    {
        public Dropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        //[KeywordTestingDropdown]
        //[KeywordTestingCollectionMethod]
        //public List<string> CollectSelectedItems()
        //{
        //    return this.SelectedItems();
        //}

        //[KeywordTestingDropdown]
        //[KeywordTestingVerificationMethod]
        //[KeywordTestingCollectionMethod]
        //public bool VerifyOptionIsSelected(string option)
        //{
        //    List<string> selectedItems = CollectSelectedItems();
        //    return selectedItems.Contains(option);
        //}

        [KeywordTestingDropdown]
        [KeywordTestingVerificationMethod]
        public bool VerifyOptionExistsByPartialText(string option)
        {
            return this.GetOptions().Any(op => op.Contains(option));
        }

        [KeywordTestingDropdown]
        [KeywordTestingVerificationMethod]
        public bool VerifyOptionDoesNotExistByPartialText(string option)
        {
            return !VerifyOptionExistsByPartialText(option);
        }
    }
}
