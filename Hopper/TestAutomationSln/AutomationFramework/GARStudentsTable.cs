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
    public class GARStudentsTable : WebElement
    {
        public GARStudentsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingGARStudentsTable]
        public String CollectNameOfFirstStudent()
        {
            var name = _driver.FindElement(By.Id("controls_householdinfo_householdinformation_ascx124_GVStudents_ctl02_lblStudentName"));

            var parsedName = name.Text.Split(' ');
            var fullName = String.Empty;

            if(parsedName[2] != null)
                fullName = parsedName.First() + " " + parsedName[2];
            else
                fullName = parsedName.First();

            return fullName;
        }

        [KeywordTestingGARStudentsTable]
        public String CollectNameOfSecondStudent()
        {
            var name = _driver.FindElement(By.Id("controls_householdinfo_householdinformation_ascx124_GVStudents_ctl03_lblStudentName"));

            var parsedName = name.Text.Split(' ');
            var fullName = String.Empty;

            if (parsedName[2] != null)
                fullName = parsedName.First() + " " + parsedName[2];
            else
                fullName = parsedName.First();

            return fullName;
        }

        [KeywordTestingGARStudentsTable]
        public String CollectNameOfThirdStudent()
        {
            var name = _driver.FindElement(By.Id("controls_householdinfo_householdinformation_ascx124_GVStudents_ctl04_lblStudentName"));

            var parsedName = name.Text.Split(' ');
            var fullName = String.Empty;

            if (parsedName[2] != null)
                fullName = parsedName.First() + " " + parsedName[2];
            else
                fullName = parsedName.First();

            return fullName;
        }

        [KeywordTestingGARStudentsTable]
        public String CollectNameOfFourthStudent()
        {
            var name = _driver.FindElement(By.Id("controls_householdinfo_householdinformation_ascx124_GVStudents_ctl05_lblStudentName"));

            var parsedName = name.Text.Split(' ');
            var fullName = String.Empty;

            if (parsedName[2] != null)
                fullName = parsedName.First() + " " + parsedName[2];
            else
                fullName = parsedName.First();

            return fullName;
        }

        [KeywordTestingGARStudentsTable]
        public String CollectNameOfFifthStudent()
        {
            var name = _driver.FindElement(By.Id("controls_householdinfo_householdinformation_ascx124_GVStudents_ctl06_lblStudentName"));

            var parsedName = name.Text.Split(' ');
            var fullName = String.Empty;

            if (parsedName[2] != null)
                fullName = parsedName.First() + " " + parsedName[2];
            else
                fullName = parsedName.First();

            return fullName;
        }
    }
}
