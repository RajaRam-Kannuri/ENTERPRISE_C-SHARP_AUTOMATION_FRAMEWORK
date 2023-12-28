using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class AribaSearchResultsPage : AribaApplicationWizardPage
    {
        public Button FirstItem { get; private set; }
        public Button SecondItem { get; private set; }
        public Button AddFirstItemToCart { get; private set; }
        public AribaRefineCatalog RefineCatalogResults { get; private set; }

        public AribaSearchResultsPage(IWebDriver driver)
            : base(driver)
        {
            FirstItem = new Button(Driver, By.CssSelector("#catalog > div > div:nth-child(3) > div > item-tile > div > div.thumbnail.result-item-with-image > div.with-image-layout > div.image-container > img"));
            SecondItem = new Button(Driver, By.CssSelector("#popular > div > div > div.col-md-12.col-sm-12.col-xs-12 > general-carousel > div > div > slick > div > div > div:nth-child(2) > div > item-tile > div > div.thumbnail.result-item-with-image > div.product-add-to-cart-flip-over > div.product-details > div.product-desc"));
            AddFirstItemToCart = new Button(Driver, By.CssSelector("#catalog > div > div:nth-child(3) > div > item-tile:nth-child(1) > div > div.thumbnail.result-item-with-image > div.product-add-to-cart > div:nth-child(3) > button > span"));
            RefineCatalogResults = new AribaRefineCatalog(Driver, By.CssSelector("#gbsection > div > aside"));
        }
    }
}
