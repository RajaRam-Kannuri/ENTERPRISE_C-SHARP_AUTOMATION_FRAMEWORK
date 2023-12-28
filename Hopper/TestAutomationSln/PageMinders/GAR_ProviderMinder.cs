using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class GAR_ProviderMinder : PageMinder
    {
        public string Program { get { return StringConstants.GAR_Provider; } }

        public GAR_ProviderMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.GAR_Provider), Utilities.GetBrowser())
        { }

        public GAR_ProviderMinder() { }
    }
}
