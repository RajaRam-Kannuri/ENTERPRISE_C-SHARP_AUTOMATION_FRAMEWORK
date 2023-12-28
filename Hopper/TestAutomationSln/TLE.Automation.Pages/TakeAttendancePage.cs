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
    public class TakeAttendancePage : CommonPage
    {
        public EditField Date { get; private set; }

        public Link PrintLink { get; private set; }

        public Link ReportsLink { get; private set; }

        public Table EnrolledStudentsTable { get; private set; }

        public Button SaveButton { get; private set; }

        public TakeAttendancePage(IWebDriver driver)
            : base(driver)
        {
            Date = new EditField(Driver, By.Id("attendanceDate"));
            PrintLink = new Link(Driver, By.Id("btnPrint"));
            ReportsLink = new Link(Driver, By.Id("btnReport"));
            EnrolledStudentsTable = new Table(Driver, By.Id("enrolledStudents"));
            SaveButton = new Button(Driver, By.Id("btnSave"));
        }
    }
}
