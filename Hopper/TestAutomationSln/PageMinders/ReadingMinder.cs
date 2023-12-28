using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class ReadingMinder : PageMinder
    {
        public string Program { get { return StringConstants.Reading; } }

        public ReadingMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.Reading), Utilities.GetBrowser())
        {
        }

        public ReadingMinder() { }
    }
}
