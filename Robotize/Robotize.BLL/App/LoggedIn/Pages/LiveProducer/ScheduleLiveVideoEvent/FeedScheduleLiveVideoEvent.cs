namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedScheduleLiveVideoEvent : Feed
    {
        public override string FeedUrl => "/live/producer/events/create/";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}