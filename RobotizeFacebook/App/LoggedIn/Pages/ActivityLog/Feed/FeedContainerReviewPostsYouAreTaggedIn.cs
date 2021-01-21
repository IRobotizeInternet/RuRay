namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedReviewPostsYouAreTaggedIn : Feed
    {
        public override string FeedUrl => "allactivity/?category_key=review&log_filter=review";
    }
}
