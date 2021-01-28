using OpenQA.Selenium.Remote;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedHome : BaseDriver
    {
        public CreatePost SectionCreatePost => new CreatePost(_driver);

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
