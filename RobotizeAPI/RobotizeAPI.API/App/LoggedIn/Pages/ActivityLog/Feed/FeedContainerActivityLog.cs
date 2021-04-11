namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedActivityLog : Feed
    {
        public override string FeedUrl => "/allactivity/?category_key=SEARCH&log_filter=search";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
