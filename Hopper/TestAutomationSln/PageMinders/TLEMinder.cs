using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class TLEMinder : PageMinder
    {
        public string Program { get { return StringConstants.TLE; } }

        public TLEMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.TLE), Utilities.GetBrowser())
        {
        }

        public TLEMinder() { }

        public void OpenSchool()
        {
            CommonPage.SchoolMenuItem.Click();
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }

        public void OpenStudents()
        {
            CommonPage.StudentsMenuItem.Click();
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }

        public void OpenClasses()
        {
            CommonPage.ClassesMenuItem.Click();
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }

        public void OpenClassSettings()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.ClassSettingsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenRecordAttendance()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.RecordAttendanceUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenAttendanceReports()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.AttendanceReportsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenLunchCountSettings()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.LunchCountSettingsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenCafeteriaReports()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.CafeteriaReportsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenClassTemplates()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.ClassTemplatesUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenGradingPeriodSettings()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.GradingPeriodSettingsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenConductScale()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.ConductScaleUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenDisplayOptions()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.DisplayOptionsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenGradingScaleSettings()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.GradingScaleSettingsUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenFacultyAndStaff()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.FacultyAndStaffUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenStudentsAndGuardians()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.StudentsAndGuardiansUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }


        public void OpenHelp()
        {
            Driver.Navigate().GoToUrl(TestUrl + CommonPage.HelpUrl);
            UIElementManager.WaitForPageLoadWithSpinners(CommonPage.Driver);
        }
    }
}
