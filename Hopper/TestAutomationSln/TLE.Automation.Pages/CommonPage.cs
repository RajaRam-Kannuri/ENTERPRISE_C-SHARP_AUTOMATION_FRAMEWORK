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
    public class CommonPage : BasePage
    {
        public string ClassSettingsUrl { get { return "Attendance/Settings"; } }

        public string RecordAttendanceUrl { get { return "Attendance/RecordAdmin"; } }

        public string AttendanceReportsUrl { get { return "Attendance/Report"; } }

        public string LunchCountSettingsUrl { get { return "LunchCount/Settings"; } }

        public string CafeteriaReportsUrl { get { return "LunchCount/Report"; } }

        public string ClassTemplatesUrl { get { return "Class/ListClassTemplate"; } }

        public string GradingPeriodSettingsUrl { get { return "SchoolSettings/GradingPeriodSettings"; } }

        public string ConductScaleUrl { get { return "ConductGrade/Edit"; } }

        public string DisplayOptionsUrl { get { return "ReportCard/List"; } }

        public string GradingScaleSettingsUrl { get { return "GradingScale/List"; } }

        public string FacultyAndStaffUrl { get { return "Admin/FacultyUserAdministration"; } }

        public string StudentsAndGuardiansUrl { get { return "Admin/StudentUserAdministration"; } }

        public string HelpUrl { get { return "#"; } }

        public Link HeaderLink { get; private set; }

        public Link UserMenu { get; private set; }

        public Link ChangePasswordLink { get; private set; }

        public Link LogOffLink { get; private set; }

        public Link HomeMenuItem { get; private set; }

        public Link SchoolMenuItem { get; private set; }

        public Link StudentsMenuItem { get; private set; }

        public Link ClassesMenuItem { get; private set; }

        public Link AdminMenuItem { get; private set; }

        public Link AdditionalStandardsMenuItem { get; private set; }

        public Link AttendanceMenuItem { get; private set; }

        public Link ClassSettingsMenuItem { get; private set; }

        public Link RecordAttendanceMenuItem { get; private set; }

        public Link AttendanceReportsMenuItem { get; private set; }

        public Link CafeteriaMenuItem { get; private set; }

        public Link LunchCountSettingsMenuItem { get; private set; }

        public Link CafeteriaReportsMenuItem { get; private set; }

        public Link ClassTemplatesMenuItem { get; private set; }

        public Link GradingPeriodSettingsMenuItem { get; private set; }

        public Link ReportCardSettingsMenuItem { get; private set; }

        public Link ConductScaleMenuItem { get; private set; }

        public Link DisplayOptionsMenuItem { get; private set; }

        public Link GradingScaleSettingsMenuItem { get; private set; }

        public Link UserAdministrationMenuItem { get; private set; }

        public Link FacultyAndStaffMenuItem { get; private set; }

        public Link StudentsAndGuardiansMenuItem { get; private set; }

        public Link HelpMenuItem { get; private set; }

        public Link ContactUsMenuItem { get; private set; }

        public Link HelpVideosMenuItem { get; private set; }

        public Link TLEUserGuideMenuItem { get; private set; }

        public Link RecentMenuItem { get; private set; }

        public Link NeedHelpLink { get; private set; }

        public Link BreadCrumbs { get; private set; }

        public Text AsyncMessage { get; private set; }

        public Text ToastSuccess { get; private set; }

        public CommonPage(IWebDriver driver)
            : base(driver)
        {
            HeaderLink = new Link(Driver, By.CssSelector(""));
            UserMenu = new Link(Driver, By.CssSelector(""));
            ChangePasswordLink = new Link(Driver, By.Id("btnChangePassword"));
            LogOffLink = new Link(Driver, By.Id("btnLogOff"));
            HomeMenuItem = new Link(Driver, By.CssSelector("a[href=\"/\"]"));
            SchoolMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Admin/SelectSchool\"]"));
            StudentsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Student/List\"]"));
            ClassesMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Class/List\"]"));
            AdminMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Admin\"]"));
            AdditionalStandardsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/SchoolSettings/ManageAdditionalStandards\"]"));
            AttendanceMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Attendance\"]"));
            ClassSettingsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Attendance/Settings\"]"));
            RecordAttendanceMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Attendance/RecordAdmin\"]"));
            AttendanceReportsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Attendance/Report\"]"));
            CafeteriaMenuItem = new Link(Driver, By.CssSelector("a[href=\"/LunchCount/Settings\"]"));
            LunchCountSettingsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/LunchCount/Settings\"]"));
            CafeteriaReportsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/LunchCount/Report\"]"));
            ClassTemplatesMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Class/ListClassTemplate\"]"));
            GradingPeriodSettingsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/SchoolSettings/GradingPeriodSettings\"]"));
            ReportCardSettingsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/ReportCard\"]"));
            ConductScaleMenuItem = new Link(Driver, By.CssSelector("a[href=\"/ConductGrade/Edit\"]"));
            DisplayOptionsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/ReportCard/List\"]"));
            GradingScaleSettingsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/GradingScale/List\"]"));
            UserAdministrationMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Admin/FacultyUserAdministration\"]"));
            FacultyAndStaffMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Admin/FacultyUserAdministration\"]"));
            StudentsAndGuardiansMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Admin/StudentUserAdministration\"]"));
            HelpMenuItem = new Link(Driver, By.CssSelector("a[href=\"#\"]"));
            ContactUsMenuItem = new Link(Driver, By.CssSelector("a[href=\"/Class/EmailOSLStaff\"]"));
            HelpVideosMenuItem = new Link(Driver, By.CssSelector("a[href=\"https://www.stepupforstudents.org/learning-compact-videos\"]"));
            TLEUserGuideMenuItem = new Link(Driver, By.CssSelector("a[href=\"/UserGuide\"]"));
            RecentMenuItem = new Link(Driver, By.CssSelector("a[href=\"javascript:void();\"]"));
            NeedHelpLink = new Link(Driver, By.LinkText(" Need Help?"));
            BreadCrumbs = new Link(Driver, By.CssSelector(".breadcrumb"));
            AsyncMessage = new Text(Driver, By.CssSelector(".toast-message"));
            ToastSuccess = new Text(Driver, By.CssSelector(".toast-success"));
        }
    }
}
