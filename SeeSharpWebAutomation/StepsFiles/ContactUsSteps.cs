using System;
using TechTalk.SpecFlow;
using SeeSharpWebAutomation.PageObject;
using OpenQA.Selenium;

namespace SeeSharpWebAutomation.StepsFiles
{
    [Binding]
    public class ContactUsSteps
    {
        IWebDriver driver;

        MainPage main = new MainPage();
        ContactUs contact = new ContactUs();
        public ContactUsSteps()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@"As the user picks contactUs button")]
        public void GivenAsTheUserPicksContactUsButton()
        {
            main.EnterContactUs(driver);
            contact.ContactUsForm(driver);
        }
        
        [When(@"User fills the form")]
        public void WhenUserFillsTheForm()
        {
            contact.FillingForm(driver);
        }
        
        [Then(@"User sends form")]
        public void ThenUserSendsForm()
        {
            contact.SendMessage(driver);
        }
    }
}
