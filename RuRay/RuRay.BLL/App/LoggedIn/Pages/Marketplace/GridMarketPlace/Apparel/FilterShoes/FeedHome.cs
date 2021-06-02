using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class FeedHome : Feed, IFeedContainer
    {
        public CreatePost SectionCreatePost => new CreatePost();

        public override string FeedUrl => "/";
        public int FeedIndex = 1;

        public FeedHome() :
            base(baseXPath: "//div[contains(@data-pagelet,'Feed')]", positionXPath: "//div[@aria-posinset='{0}']")
        {

        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
