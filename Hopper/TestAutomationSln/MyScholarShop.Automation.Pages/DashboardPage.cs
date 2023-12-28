using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace MyScholarShop.Automation.Pages
{
    public class DashboardPage : ApplicationWizardPage
    {
        public Button FirstItem { get; private set; }
        public Button SecondItem { get; private set; }
        public Button AddItemToCart { get; private set; }

        public DashboardPage(IWebDriver driver) : base(driver)
        {
            FirstItem = new Button(Driver, By.CssSelector("#popular > div > div > div.col-md-12.col-sm-12.col-xs-12 > general-carousel > div > div > slick > div > div > div.general-slick-item.slick-slide.slick-current.slick-active"));
            SecondItem = new Button(Driver, By.CssSelector("#popular > div > div > div.col-md-12.col-sm-12.col-xs-12 > general-carousel > div > div > slick > div > div > div:nth-child(2) > div > item-tile > div > div.thumbnail.result-item-with-image > div.product-add-to-cart-flip-over > div.product-details > div.product-desc"));
            AddItemToCart = new Button(Driver, By.CssSelector("img[src$=\"ng1/assets/images/icon-cart-default.png\"]"));
        }
    }
}
