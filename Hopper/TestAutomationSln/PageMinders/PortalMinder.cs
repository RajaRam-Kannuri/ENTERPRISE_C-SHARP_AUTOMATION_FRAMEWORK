using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class PortalMinder : PageMinder
    {
        public string Program { get { return StringConstants.Portal; } }

        public PortalMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.Portal), Utilities.GetBrowser())
        {
        }

        public PortalMinder() { }
    }
}
