﻿using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedLikedPages : Feed
    {
        public override string FeedUrl => "/pages/?category=liked&ref=bookmarks";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
