﻿using System;

namespace RuRayFacebook.App.LoggedIn
{
    public class FeedFacebookPay : Feed
    {
        public override string FeedUrl => "/facebook_pay/?referrer=bookmark";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
