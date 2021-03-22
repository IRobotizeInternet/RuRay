using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedLikedPages : FeedComponent
    {
        public override string FeedUrl => "/pages/?category=liked&ref=bookmarks";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
