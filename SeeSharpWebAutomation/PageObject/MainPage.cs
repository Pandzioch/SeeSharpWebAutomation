using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpWebAutomation.PageObject
{
    class MainPage
    {
        [FindsBy(How=How.XPath, Using = "//a[@title='Contact Us']")]
        public IWebElement ContactUsButton { get; set; }

       public void EnterContactUs(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            ContactUsButton.Click();
        }
    }
}
