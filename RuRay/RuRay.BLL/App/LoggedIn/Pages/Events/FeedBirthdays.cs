using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedBirthdays : Feed
    {
        public override string FeedUrl => "/events/birthdays/";

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
