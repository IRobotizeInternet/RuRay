﻿using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedDiscover : Feed
    {
        public override string FeedUrl => "/pages/?category=top&ref=bookmarks";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
