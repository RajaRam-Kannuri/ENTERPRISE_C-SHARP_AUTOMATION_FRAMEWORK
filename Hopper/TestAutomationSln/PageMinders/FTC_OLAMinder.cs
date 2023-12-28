using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class FTC_OLAMinder : PageMinder
    {
        public string Program { get { return StringConstants.FTC_OLA; } }

        public FTC_OLAMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.FTC_OLA), Utilities.GetBrowser())
        {
        }

        public FTC_OLAMinder() { }
    }
}
