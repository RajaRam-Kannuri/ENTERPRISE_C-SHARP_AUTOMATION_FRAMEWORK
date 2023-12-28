using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEPostAMJobPage : MJEBasePage
    {
        public EditField JobNameTextbox { get; private set; }
        public EditField TotalPriceTextbox { get; private set; }
        public EditField NumberOfSessionsTextbox { get; private set; }
        public EditField SessionLengthTextbox { get; private set; }
        public OLAWorkflowDropdown ServiceCategoryDropdown { get; private set; }
        public OLAWorkflowDropdown LocationOfServiceDropdown { get; private set; }
        public EditField GradeLevelTextbox { get; private set; }
        public EditField DescriptionTextbox { get; private set; }
        public Button SaveButton { get; private set; }
        public Button DiscardButton { get; private set; }
        public Button DeleteFirstGradeChoiceButton { get; private set; }
        public Text JobNameIsRequiredErrorMessage { get; private set; }
        public Text TotalPriceSpecifyAValidAmountErrorMessage { get; private set; }
        public Text TotalPriceValueGreaterThanOrEqualTo1ErrorMessage { get; private set; }
        public Text TotalPriceValueLessThanOrEqualTo1500ErrorMessage { get; private set; }
        public Text NumberOfSessionsIsRequiredErrorMessage { get; private set; }
        public Text SessionLengthIsRequiredErrorMessage { get; private set; }
        public Text ServiceCategoryIsRequiredErrorMessage { get; private set; }
        public Text LocationOfServiceIsRequiredErrorMessage { get; private set; }
        public Text GradeLevelsIsRequiredErrorMessage { get; private set; }
        public Text DescriptionIsRequiredErrorMessage { get; private set; }
        public Text GalleryIsRequiredErrorMessage { get; private set; }
        public OLADocUploadButton GalleryUploadButton { get; private set; }
        public Button GalleryDeleteImageButton { get; private set; }

        public MJEPostAMJobPage (IWebDriver driver)
            : base(driver)
        {
            JobNameTextbox = new EditField(Driver, By.Name("post_title"));
            TotalPriceTextbox = new EditField(Driver, By.Name("et_budget"));
            NumberOfSessionsTextbox = new EditField(Driver, By.Name("et_number_sessions"));
            SessionLengthTextbox = new EditField(Driver, By.Name("et_session_length"));
            ServiceCategoryDropdown = new OLAWorkflowDropdown(Driver, By.CssSelector("#mjob_category_chosen > div"));
            LocationOfServiceDropdown = new OLAWorkflowDropdown(Driver, By.CssSelector("#mjob_category_chosen > div"));
            GradeLevelTextbox = new EditField(Driver, By.Id("mjob_grade_levels_chosen"));
            DescriptionTextbox = new EditField(Driver, By.Id("tinymce"));
            GalleryUploadButton = new OLADocUploadButton(Driver, By.XPath("//*[contains(@src, 'icon-plus.png')]"));
            GalleryDeleteImageButton = new Button(Driver, By.XPath("//*[contains(@id, 'mjob-delete')]"));
            SaveButton = new Button(Driver, By.XPath("//button[text() = 'SAVE']"));
            DiscardButton = new Button(Driver, By.XPath("//button[text() = 'DISCARD']"));
            DeleteFirstGradeChoiceButton = new Button(Driver, By.ClassName("search-choice-close"));
            JobNameIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[1]/div/label[2]"));
            TotalPriceSpecifyAValidAmountErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[2]/div[1]/div/label[2]"));
            TotalPriceValueGreaterThanOrEqualTo1ErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[2]/div[1]/div/label[2]"));
            TotalPriceValueLessThanOrEqualTo1500ErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[2]/div[1]/div/label[2]"));
            NumberOfSessionsIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[2]/div[2]/div/label[2]"));
            SessionLengthIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[2]/div[2]/div/label[2]"));
            ServiceCategoryIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[4]/div[1]/div/label[2]"));
            LocationOfServiceIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[4]/div[2]/div/label[2]"));
            GradeLevelsIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='step - post']/form/div[4]/div[3]/div/label[2]"));
            DescriptionIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='wp - post_content - editor - container']/label"));
            GalleryIsRequiredErrorMessage = new Text(Driver, By.XPath("//*[@id='gallery_container']/div/div[1]/div/label"));
        }
    }
}
