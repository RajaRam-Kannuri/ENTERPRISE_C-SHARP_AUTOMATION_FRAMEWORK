using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class FTC_PLIMinder : PageMinder
    {
        public string Program { get { return StringConstants.FTC_PLI; } }

        public FTC_PLIMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.FTC_PLI), Utilities.GetBrowser())
        {
        }

        public FTC_PLIMinder() { }
    }
}
