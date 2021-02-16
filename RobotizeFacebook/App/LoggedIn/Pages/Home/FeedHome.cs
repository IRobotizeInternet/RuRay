namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedHome : Feed
    {
        public CreatePost SectionCreatePost => new CreatePost();

        public override string FeedUrl => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
