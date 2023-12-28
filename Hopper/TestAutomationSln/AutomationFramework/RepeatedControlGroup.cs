using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class RepeatedControlGroup : WebElement
    {
        public RepeatedControlGroup(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
        }

        [KeywordTestingRepeatedControlGroup]
        [KeywordTestingFindMethod]
        public int FindSetWith(string textToFind)
        {
            List<IWebElement> allInstances = this.LocateAll().ToList();
            for (int i = 0; i < allInstances.Count; i++)
            {
                if (allInstances[i].Text.Contains(textToFind))
                    return i;
            }
            return -1;
        }

        [KeywordTestingRepeatedControlGroup]
        [KeywordTestingFindMethod]
        public int UsingSet(int setItemIndex)
        {
            return setItemIndex - 1;
        }
    }
}
