﻿using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccountFollowing : Feed
    {
        public override string FeedUrl => "/marketplace/you/following";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
