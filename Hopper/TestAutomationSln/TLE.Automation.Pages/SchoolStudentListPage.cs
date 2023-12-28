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
    public class SchoolStudentListPage : CommonPage
    {
        public Text SchoolName { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Button CreateStudentButton { get; private set; }

        public Button UploadStudentsButton { get; private set; }

        public EditField StudentLastname { get; private set; }

        public Dropdown GradeLevel { get; private set; }

        public Dropdown Class { get; private set; }

        public Dropdown Active { get; private set; }

        public Button SearchButton { get; private set; }

        public Button PrintReportCardsButton { get; private set; }

        public Table StudentTable { get; private set; }

        public SchoolStudentListPage(IWebDriver driver)
            : base(driver)
        {
            SchoolName = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Dropdown(Driver, By.Id("SchoolYearId"));
            CreateStudentButton = new Button(Driver, By.CssSelector("a[href=\"/Student/Create\"]"));
            UploadStudentsButton = new Button(Driver, By.Id("btnOpenUpload"));
            StudentLastname = new EditField(Driver, By.Id("LastName"));
            GradeLevel = new Dropdown(Driver, By.Id("GradeLevelId"));
            Class = new Dropdown(Driver, By.Id("TeacherClassRoomId"));
            Active = new Dropdown(Driver, By.Id("ActiveFilter"));
            SearchButton = new Button(Driver, By.CssSelector("button[type=\"submit\"]"));
            PrintReportCardsButton = new Button(Driver, By.LinkText("Print Report Cards"));
            StudentTable = new Table(Driver, By.CssSelector(".table.table-striped"));
        }
    }
}
