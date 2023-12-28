using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class PowerBIMinder : PageMinder
    {
        public string Program { get { return StringConstants.PowerBI; } }

        public PowerBIMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.PowerBI), Utilities.GetBrowser())
        {
        }

        public PowerBIMinder() { }
    }
}
