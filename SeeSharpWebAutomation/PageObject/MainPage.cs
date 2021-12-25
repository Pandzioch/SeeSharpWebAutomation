using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support;

namespace SeeSharpWebAutomation.PageObject
{
    class MainPage
    {

        [FindsBy(How=How.XPath, Using = "//a[@title='Contact Us']")]
        public IWebElement ContactUsButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        public IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='block_top_menu']/ul/li[1]/a")]
        public IWebElement WomenMenuButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='block_top_menu']/ul/li[2]/a")]
        public IWebElement DressesMenuButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='block_top_menu']/ul/li[3]/a")]
        public IWebElement TshirtsMenuButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='search_query_top']")]
        public IWebElement Searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='shopping_cart']/a")]
        public IWebElement ShopppingCart { get; set; }

        public void EnterContactUs(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            ContactUsButton.Click();
        }
    }
}
