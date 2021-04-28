using System;
using TechTalk.SpecFlow;

namespace Robotize.BLL.SpecFlow.Features
{
    [Binding]
    public class PageHomeSteps
    {
        [Given(@"Click the search bar in the top left of any Facebook page\.")]
        public void GivenClickTheSearchBarInTheTopLeftOfAnyFacebookPage_()
        {
          
        }
        
        [Then(@"Type your friend's name into the search bar and click")]
        public void ThenTypeYourFriendSNameIntoTheSearchBarAndClick()
        {
            
        }
        
        [Then(@"To send someone a friend request, click  next to their profile picture\.")]
        public void ThenToSendSomeoneAFriendRequestClickNextToTheirProfilePicture_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
