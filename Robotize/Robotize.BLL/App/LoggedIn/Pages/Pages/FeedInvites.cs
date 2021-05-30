using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedInvites : Feed
    {
        public override string FeedUrl => "/pages/?category=invites&ref=bookmarks";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
