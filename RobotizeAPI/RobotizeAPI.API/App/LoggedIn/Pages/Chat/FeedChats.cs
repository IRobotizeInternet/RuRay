namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedChats : Feed
    {
        public override string FeedUrl => "/messages";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
