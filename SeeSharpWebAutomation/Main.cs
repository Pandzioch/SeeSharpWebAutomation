using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeeSharpWebAutomation
{
    [Binding]
    public sealed class Main
    {
        IWebDriver driver = new ChromeDriver();

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Window.FullScreen();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
