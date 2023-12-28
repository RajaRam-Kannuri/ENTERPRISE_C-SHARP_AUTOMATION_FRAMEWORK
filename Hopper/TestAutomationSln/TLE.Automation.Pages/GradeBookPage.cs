using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class GradeBookPage : UnitPlanWizardPage
    {
        public Table Names { get; private set; }

        public Table Scores { get; private set; }

        public Table PointsAndAverages { get; private set; }

        public WebElement CumulativeAverage { get; private set; }

        public WebElement CumulativeLetterGrade { get; private set; }

        public WebElement StandardAchievementCode { get; private set; }

        public Button SaveButton { get; private set; }

        public Button SubmitFinalGradesButton { get; private set; }

        public Modal SubmitGradesConfirmationModal { get; private set; }

        public Button ConfirmSubmitGradesButton { get; private set; }

        public GradeBookPage(IWebDriver driver)
            : base(driver)
        {
            Names = new Table(Driver, By.Id("bottomLeft"));
            Scores = new Table(Driver, By.Id("bottomCenter"));
            PointsAndAverages = new Table(Driver, By.Id("bottomRight"));
            CumulativeAverage = new WebElement(Driver, By.CssSelector(""));
            CumulativeLetterGrade = new WebElement(Driver, By.CssSelector(""));
            StandardAchievementCode = new WebElement(Driver, By.CssSelector(""));
            SaveButton = new Button(Driver, By.CssSelector("input[ng-click=\"vm.save(false)\"]"));
            SubmitFinalGradesButton = new Button(Driver, By.CssSelector("input[ng-click=\"vm.save(true)\"]"));
            SubmitGradesConfirmationModal = new Modal(Driver, By.CssSelector(".modal-content"));
            ConfirmSubmitGradesButton = new Button(Driver, By.CssSelector("button[data-ng-click=\"ok()\"]"));
        }
    }
}
