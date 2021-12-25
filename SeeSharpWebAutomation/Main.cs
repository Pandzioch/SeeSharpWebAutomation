using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SeeSharpWebAutomation
{
    [Binding]
    public class Main
    {
        IWebDriver driver;
        WebDriverWait wait;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            ScenarioContext.Current.Add("Wait", wait);
            ScenarioContext.Current.Add("currentDriver", driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
