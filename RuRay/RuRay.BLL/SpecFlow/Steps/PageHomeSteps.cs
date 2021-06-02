using TechTalk.SpecFlow;

namespace RuRay.BLL.SpecFlow.Features
{
    /// <summary>
    /// Defines the <see cref="PageHomeSteps" />.
    /// </summary>
    [Binding]
    public class PageHomeSteps
    {
        /// <summary>
        /// The GivenClickTheSearchBarInTheTopLeftOfAnyFacebookPage_.
        /// </summary>
        [Given(@"Click the search bar in the top left of any Facebook page\.")]
        public void GivenClickTheSearchBarInTheTopLeftOfAnyFacebookPage_()
        {
        }

        /// <summary>
        /// The ThenTypeYourFriendSNameIntoTheSearchBarAndClick.
        /// </summary>
        [Then(@"Type your friend's name into the search bar and click")]
        public void ThenTypeYourFriendSNameIntoTheSearchBarAndClick()
        {
        }

        /// <summary>
        /// The ThenToSendSomeoneAFriendRequestClickNextToTheirProfilePicture_.
        /// </summary>
        [Then(@"To send someone a friend request, click  next to their profile picture\.")]
        public void ThenToSendSomeoneAFriendRequestClickNextToTheirProfilePicture_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
