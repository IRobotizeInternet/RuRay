namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedReviewTagsOnYourPosts : FeedComponent
    {
        public override string FeedUrl => "/allactivity/?category_key=tagreview&log_filter=tagreview";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
