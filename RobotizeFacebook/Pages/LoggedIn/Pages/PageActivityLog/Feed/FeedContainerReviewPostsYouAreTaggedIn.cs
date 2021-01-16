using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class FeedContainerReviewPostsYouAreTaggedIn : FeedContainer
    {
        public override string FeedUrl => "allactivity/?category_key=review&log_filter=review";
    }
}
