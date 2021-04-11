namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedReviewTagsOnYourPosts : Feed
    {
        public override string FeedUrl => "/allactivity/?category_key=tagreview&log_filter=tagreview";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
