using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class AdvancedSchoolSearchPage : HomePage
    {
        public EditField AdvSchoolYear { get; private set; }

        public EditField AdvSchoolCode { get; private set; }

        public EditField AdvSchoolName { get; private set; }

        public Dropdown City { get; private set; }

        public Dropdown District { get; private set; }

        public EditField ZipCode { get; private set; }

        public Dropdown Region { get; private set; }

        public Dropdown FTC { get; private set; }

        public Dropdown SUFSPart { get; private set; }

        public Dropdown HasSUFSStudents { get; private set; }

        public EditField SchoolContactFirstName { get; private set; }

        public EditField SchoolContactLastName { get; private set; }

        public EditField SchoolContactEmail { get; private set; }

        public EditField SchoolContactPone { get; private set; }

        public EditField MainSchoolPhone { get; private set; }

        public EditField SchoolContactFax { get; private set; }

        public Dropdown GradesServedFrom { get; private set; }

        public Dropdown GradesServedTo { get; private set; }

        public Dropdown Denomination { get; private set; }

        public Dropdown TuitionAndFeeSchedule { get; private set; }

        public Button SearchButton { get; private set; }

        public Dropdown Year { get; private set; }

        public AdvancedSchoolSearchPage(IWebDriver driver)
            : base(driver)
        {
            AdvSchoolYear = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlApplicationYear"));
            AdvSchoolCode = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbSchoolCode"));
            AdvSchoolName = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbSchoolName"));
            City = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbSchoolName"));
            District = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlDistrictID"));
            ZipCode = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbZipcode"));
            Region = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlRegionID"));
            FTC = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlIsFTC"));
            SUFSPart = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlIsSUFS"));
            HasSUFSStudents = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlHasSUFSStudents"));
            SchoolContactFirstName = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbContactFirst"));
            SchoolContactLastName = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbContactLast"));
            SchoolContactEmail = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbContactEmail"));
            SchoolContactPone = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbContactPhone"));
            MainSchoolPhone = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbSchoolPhone"));
            SchoolContactFax = new EditField(driver, By.Id("controls_search_schooladvancedsearch_ascx290_tbPrimaryContactFax"));
            GradesServedFrom = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlGradeServedMinID"));
            GradesServedTo = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlGradeServedMaxID"));
            Denomination = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlDenominationID"));
            TuitionAndFeeSchedule = new Dropdown(driver, By.Id("controls_search_schooladvancedsearch_ascx290_ddlTuitionFeeScheduleStatusID"));
            SearchButton = new Button(driver, By.Id("controls_search_schooladvancedsearch_ascx290_btnRunAdvancedSearch"));
            Year = new Dropdown(driver, By.Id("controls_search_advancedsearch_ascx131_ddlApplicationYear"));
        }
    }
}
