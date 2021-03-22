namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedAdTopics : FeedComponent
    {
        public override string FeedUrl => "/adpreferences/advertisers/?entry_product=account_settings_menu";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
