using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedYourAccountSaved : Feed
    {
        public override string FeedUrl => "/marketplace/you/saved";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
