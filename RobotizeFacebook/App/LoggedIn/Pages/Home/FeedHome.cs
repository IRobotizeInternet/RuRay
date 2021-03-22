namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedHome : FeedComponent
    {
        public CreatePost SectionCreatePost => new CreatePost();

        public override string FeedUrl => "/";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public FeedHome(string baseXPath = "//div[@role='feed']", string positionXPath = "//div[@aria-posinset='{0}']") : base(baseXPath, positionXPath)
        {
        }
    }
}
