using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedDiscover : Feed
    {
        public override string FeedUrl => "/pages/?category=top&ref=bookmarks";
    }
}
