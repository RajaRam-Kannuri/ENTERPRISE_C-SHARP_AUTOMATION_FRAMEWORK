using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationElectronicSignaturePage : ApplicationWizardPage
    {
        public Text ApplicationNumber { get; private set;}

        public Checkbox CertifyInformation { get; private set; }

        public Checkbox CertifyAffiliation { get; private set;}

        public Checkbox CertifyRules { get; private set;}

        public EditField PrimaryParentSignature { get; private set;}

        public Text PrimaryParentName { get; private set; }

        public EditField SecondaryParentSignature { get; private set; }

        public Text SecondaryParentName { get; private set; }

        public ApplicationElectronicSignaturePage(IWebDriver driver)
            : base(driver)
        {
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"_lblApplicationNumber\"]"));
            CertifyInformation = new Checkbox(Driver, By.CssSelector("input[id$=\"_rbCertifyInformation\"]"));
            CertifyAffiliation = new Checkbox(Driver, By.CssSelector("input[id$=\"_rbCertifyAffiliation\"]"));
            CertifyRules = new Checkbox(Driver, By.CssSelector("input[id$=\"_rbCertifyRules\"]"));
            PrimaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtPrimaryParentSignature\"]"));
            PrimaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblPrimaryParentName\"]"));
            SecondaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtSecondaryParentSignature\"]"));
            SecondaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblSecondaryParentName\"]"));
        }
    }
}
