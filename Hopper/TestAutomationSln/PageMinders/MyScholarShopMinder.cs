using AutomationFramework;
using KWDT.Core;

namespace PageMinders
{
    public partial class MyScholarShopMinder : PageMinder
    {
        public string Program { get { return StringConstants.MyScholarShop; } }

        public MyScholarShopMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.MyScholarShop), Utilities.GetBrowser())
        { }

        public MyScholarShopMinder() { }
    }
}
