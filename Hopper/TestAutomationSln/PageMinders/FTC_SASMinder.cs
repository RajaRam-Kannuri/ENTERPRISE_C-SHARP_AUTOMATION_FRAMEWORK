using AutomationFramework;
using KWDT.Core;
using FTC.SAS.Automation.Pages;


namespace PageMinders
{
    public partial class FTC_SASMinder : PageMinder
    {
        public string Program { get { return StringConstants.FTC_SAS; } }

        public FTC_SASMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.FTC_SAS), Utilities.GetBrowser())
        {
            WorksheetURL = "APCWorksheet.html";
        }
    }
}
