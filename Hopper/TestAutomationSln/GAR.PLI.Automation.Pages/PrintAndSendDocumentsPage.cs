using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class PrintAndSendDocumentsPage : HomePage
    {
        public Dropdown DocumentsForSchoolYear { get; private set; }

        public Text DocumentsForApplicationId { get; private set; }

        public Button InstructionsAndDocumentsButton { get; private set; }

        public DocUploadButton ChooseFile { get; private set; }

        //public EditField ChooseFile { get; private set; }

        public Button UploadDocumentsButton { get; private set; }

        public Text UploadStatusMessage { get; private set; }

        public Table UploadHistoryTable { get; private set; }

        public Text ID { get; private set; }

        public PrintAndSendDocumentsPage(IWebDriver driver)
            : base(driver)
        {
            DocumentsForSchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
            DocumentsForApplicationId = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            InstructionsAndDocumentsButton = new Button(Driver, By.CssSelector("input[id$=\"btnInstructions\"]"));
            ChooseFile = new DocUploadButton(Driver, By.CssSelector("input[id$=\"FileUploadControl\"]"));
            //ChooseFile = new EditField(Driver, By.CssSelector("input[id$=\"FileUploadControl\"]"));
            UploadDocumentsButton = new Button(Driver, By.CssSelector("input[id$=\"btnUpload\"]"));
            UploadStatusMessage = new Text(Driver, By.CssSelector("span[id*=\"uploaddocuments\"][id$=\"lblStatus\"]"));
            UploadHistoryTable = new Table(Driver, By.CssSelector("table[id$=\"gvUploadHistory\"]"));
            ID = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
        }
    }
}
