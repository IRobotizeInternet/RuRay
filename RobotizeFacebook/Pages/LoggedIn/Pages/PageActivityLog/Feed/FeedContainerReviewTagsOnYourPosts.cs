using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public class FeedContainerReviewTagsOnYourPosts : FeedContainer
    {
        public override string FeedUrl => "/allactivity/?category_key=tagreview&log_filter=tagreview";
    }
}
