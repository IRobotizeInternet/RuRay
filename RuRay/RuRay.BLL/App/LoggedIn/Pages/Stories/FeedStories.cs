﻿using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedStories : Feed
    {
        public override string FeedUrl => "/stories";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
