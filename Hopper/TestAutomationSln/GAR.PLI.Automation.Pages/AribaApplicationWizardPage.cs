using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public abstract class AribaApplicationWizardPage : BasePage
    {
        public Button ShoppingCartButton { get; private set; }
        public Button CheckOutButton { get; private set; }
        public Button MenuSearchBarButton { get; private set; }
        public EditField MenuSearchBar { get; private set; }
        public HiddenButton OnlineChatButton { get; private set; }

        public AribaApplicationWizardPage(IWebDriver driver)
            : base(driver)
        {
            OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
            ShoppingCartButton = new Button(Driver, By.CssSelector("#shoppingCart > div > div > div.fd-popover__control > button"));
            CheckOutButton = new Button(Driver, By.Id("shopping-cart-submit-button"));
            MenuSearchBarButton = new Button(Driver, By.CssSelector("#wrapper > app-root > div.ngx-fundamentals > gb-header > div.gb-ies-header > nav > div > af-shellbar > div > div.fd-shellbar__group.fd-shellbar__group--end > div > af-shellbar-search-input > div > div > div > div.fd-popover__control.fd-search-input__control > button"));
            MenuSearchBar = new EditField(Driver, By.CssSelector("#wrapper > app-root > div.ngx-fundamentals > gb-header > div.gb-ies-header > nav > div > af-shellbar > div > div.fd-shellbar__group.fd-shellbar__group--end > div > af-shellbar-search-input > div > div > div > div.fd-popover__control.fd-search-input__control > div > div > input"));
        }
    }
}
