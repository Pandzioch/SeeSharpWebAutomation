using System;
using TechTalk.SpecFlow;

namespace SeeSharpWebAutomation.StepsFiles
{
    [Binding]
    public class EmptyShoppingcartSteps
    {
        [When(@"User deletes the items in the card")]
        public void WhenUserDeletesTheItemsInTheCard()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User signs out")]
        public void ThenUserSignsOut()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
