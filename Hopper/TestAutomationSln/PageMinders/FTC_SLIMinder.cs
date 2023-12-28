using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class FTC_SLIMinder : PageMinder
    {
        public string Program { get { return StringConstants.FTC_SLI; } }

        public FTC_SLIMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.FTC_SLI), Utilities.GetBrowser())
        {
        }

        public FTC_SLIMinder() { }
    }
}
