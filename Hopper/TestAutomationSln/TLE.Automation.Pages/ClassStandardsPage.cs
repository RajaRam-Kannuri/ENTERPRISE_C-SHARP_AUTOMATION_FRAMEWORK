using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ClassStandardsPage : CommonPage
    {
        public Button PrintClassStandardsButton { get; private set; }

        public Button SelectStandardsButton { get; private set; }

        public Button SaveClassStandardsTemplateButton { get; private set; }

        public Table StandardsTable { get; private set; }

        public Table StandardsTableHeader { get; private set; }

        public Text CodeSelectorFlyout { get; private set; }

        public ClassStandardsPage(IWebDriver driver)
            : base(driver)
        {
            PrintClassStandardsButton = new Button(Driver, By.CssSelector(""));
            SelectStandardsButton = new Button(Driver, By.Id("btnSelectMathCCSS"));
            SaveClassStandardsTemplateButton = new Button(Driver, By.Id("btnSaveCCSSTemplate"));
            StandardsTable = new Table(Driver, By.CssSelector(".class-standards"));
            CodeSelectorFlyout = new Text(Driver, By.CssSelector(".popover.fade"));
            StandardsTableHeader = new Table(Driver, By.CssSelector(".patt"));
        }
    }
}
