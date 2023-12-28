using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class AdvancedStudentSearchPage : HomePage
    {
        public EditField AdvStudentSSN { get; private set; }

        public EditField AdvStudentFirstName { get; private set; }

        public EditField AdvStudentLastName { get; private set; }

        public Dropdown Gender { get; private set; }

        public Dropdown Grade { get; private set; }

        public Dropdown AdvSchoolYear { get; private set; }

        public EditField AdvSchoolCode { get; private set; }

        public EditField ApplicationId { get; private set; }

        public EditField PrimaryParentSSN { get; private set; }

        public Dropdown City { get; private set; }

        public EditField ZipCode { get; private set; }

        public Dropdown County { get; private set; }

        public Dropdown ApplicationStatus { get; private set; }

        public Dropdown StudentScholarshipStatus { get; private set; }

        public Dropdown StudentType { get; private set; }

        public Dropdown ApplicationType { get; private set; }

        public EditField AwardPercent { get; private set; }

        public Button SearchButton { get; private set; }

        public ApplicationTable ApplicationTable { get; private set; }

		public ApplicationTable SearchTable { get; private set; }

		public AdvancedStudentSearchPage(IWebDriver driver)
            : base(driver)
        {
            AdvStudentSSN = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbSSN"));
            AdvStudentFirstName = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbFirstName"));
            AdvStudentLastName = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbLastName"));
            Gender = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlGenderID"));
            Grade = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlGradeLevelID"));
            AdvSchoolYear = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlApplicationYear"));
            AdvSchoolCode = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbSchoolCode"));
            ApplicationId = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbApplicationID"));
            PrimaryParentSSN = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbPrimaryParentSSN"));
            City = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlCityID"));
            ZipCode = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbZipcode"));
            County = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlCountyID"));
            ApplicationStatus = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlApplicationStatus"));
            StudentScholarshipStatus = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlStudentScholarshipStatus"));
            StudentType = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlStudentTypeID"));
            ApplicationType = new Dropdown(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_ddlApplicationTypeID"));
            AwardPercent = new EditField(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_tbAwardPercent"));
            SearchButton = new Button(Driver, By.Id("controls_search_studentadvancedsearch_ascx292_btnRunAdvancedSearch"));
            ApplicationTable = new ApplicationTable(Driver, By.Id("tblResults"));
			SearchTable = new ApplicationTable(Driver, By.Id("tblResults"));
		}
	}
}
