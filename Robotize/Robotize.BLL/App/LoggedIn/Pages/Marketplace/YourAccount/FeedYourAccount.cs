﻿using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccount : Feed
    {
        public override string FeedUrl => "/marketplace/you/selling";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
