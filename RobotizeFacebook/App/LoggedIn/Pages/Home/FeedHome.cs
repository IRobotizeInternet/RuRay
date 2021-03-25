namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedHome : FeedComponent
    {
        public CreatePost SectionCreatePost => new CreatePost();

        public override string FeedUrl => "/";

        public FeedHome()
        {
            base.BaseXPath = "//div[contains(@data-pagelet,'Feed')]";
            base.PositionXPath = "//div[@aria-posinset='{0}']";
        }

        public void TryToSetCurrentFeedIndex()
        {
            
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
