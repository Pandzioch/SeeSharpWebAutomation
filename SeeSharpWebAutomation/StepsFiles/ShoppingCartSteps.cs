using System;
using TechTalk.SpecFlow;

namespace SeeSharpWebAutomation.StepsFiles
{
    [Binding]
    public class ShoppingCartSteps
    {
        [Given(@"As the user picks (.*)st promoted item from the cart")]
        public void GivenAsTheUserPicksStPromotedItemFromTheCart(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Checkouts to the cart")]
        public void GivenCheckoutsToTheCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User proceeds to check out")]
        public void WhenUserProceedsToCheckOut()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User Logs in")]
        public void ThenUserLogsIn(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User enters shipping address")]
        public void ThenUserEntersShippingAddress(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User picks a payment method")]
        public void ThenUserPicksAPaymentMethod()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Finishes")]
        public void ThenFinishes()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
