using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class AdvancedApplicationSearchPage : HomePage
    {
        public EditField AdultFirstName { get; private set; }

        public EditField AdultLastName { get; private set; }

        public EditField ChildFirstName { get; private set; }

        public EditField ChildLastName { get; private set; }

        public EditField StudentFirstNameAdv { get; private set; }

        public EditField StudentLastNameAdv { get; private set; }

        public EditField AdultLast4SSN { get; private set; }

        public EditField StudentLast4SSN { get; private set; }

        public EditField PrimaryGuardianEmail { get; private set; }

        public EditField SecondaryGuardianEmail { get; private set; }

        public EditField OtherAdultEmail { get; private set; }

        public EditField StudentEmail { get; private set; }

        public Dropdown PhysicalAddressCity { get; private set; }

        public Dropdown PhysicalAddressState { get; private set; }

        public EditField PhysicalAddressZip { get; private set; }

        public EditField PhysicalAddressStreetName { get; private set; }

        public EditField PhoneNumber { get; private set; }

        public Dropdown Year { get; private set; }

        public Button SearchButton { get; private set; }

        public ApplicationSearchResultsSection SearchResults { get; private set; }

        public AdvancedApplicationSearchPage(IWebDriver driver)
            : base(driver)
        {
            AdultFirstName = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtAdultFirst"));
            AdultLastName = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtAdultLast"));
            ChildFirstName = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtChildFirst"));
            ChildLastName = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtChildLast"));
            StudentFirstNameAdv = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtStudentFirst"));
            StudentLastNameAdv = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtStudentLast"));
            AdultLast4SSN = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtLastFourSSNAdult"));
            StudentLast4SSN = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtLastFourSSNStudent"));
            PrimaryGuardianEmail = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPrimaryGuardianEmail"));
            SecondaryGuardianEmail = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtSecondaryGuardianEmail"));
            OtherAdultEmail = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtOtherAdultEmail"));
            StudentEmail = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtStudentEmail"));
            PhysicalAddressCity = new Dropdown(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPhysicalAddressCity"));
            PhysicalAddressState = new Dropdown(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPhysicalAddressState"));
            PhysicalAddressZip = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPhysicalAddressZip"));
            PhysicalAddressStreetName = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPhysicalAddresStreet"));
            PhoneNumber = new EditField(Driver, By.Id("controls_search_advancedsearch_ascx131_txtPhone"));
            Year = new Dropdown(Driver, By.Id("controls_search_advancedsearch_ascx131_ddlApplicationYear"));
            SearchButton = new Button(Driver, By.Id("controls_search_advancedsearch_ascx131_btnRunAdvancedSearch"));
            SearchResults = new ApplicationSearchResultsSection(Driver);
        }

        public void FillOutSearchForm(ApplicationAdvancedSearchData data)
        {
            if (data == null) return;
            AdultFirstName.SetText(data.AdultFirstName);
            AdultLastName.SetText(data.AdultLastName);
            ChildFirstName.SetText(data.ChildFirstName);
            ChildLastName.SetText(data.ChildLastName);
            StudentFirstNameAdv.SetText(data.StudentFirstName);
            StudentLastNameAdv.SetText(data.StudentLastName);
            AdultLast4SSN.SetText(data.AdultLast4SSN);
            StudentLast4SSN.SetText(data.StudentLast4SSN);
            PrimaryGuardianEmail.SetText(data.PrimaryGuardianEmail);
            SecondaryGuardianEmail.SetText(data.SecondaryGuardianEmail);
            OtherAdultEmail.SetText(data.OtherAdultEmail);
            StudentEmail.SetText(data.StudentEmail);
            PhysicalAddressCity.SetText(data.PhysicalAddressCity);
            PhysicalAddressState.SetText(data.PhysicalAddressState);
            PhysicalAddressZip.SetText(data.PhysicalAddressZip);
            PhysicalAddressStreetName.SetText(data.PhysicalAddressStreetName);
            PhoneNumber.SetText(data.PhoneNumber);
            Year.Select(data.Year);
        }
    }
}
