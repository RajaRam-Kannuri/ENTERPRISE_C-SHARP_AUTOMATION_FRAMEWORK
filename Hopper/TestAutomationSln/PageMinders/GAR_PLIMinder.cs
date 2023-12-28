using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class GAR_PLIMinder : PageMinder
    {
        public string Program { get { return StringConstants.GAR_PLI; } }

        public GAR_PLIMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.GAR_PLI), Utilities.GetBrowser())
        {
        }

        public GAR_PLIMinder() { }
    }
}
