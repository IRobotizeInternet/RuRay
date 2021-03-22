namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedReviewPostsYouAreTaggedIn : FeedComponent
    {
        public override string FeedUrl => "allactivity/?category_key=review&log_filter=review";

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
