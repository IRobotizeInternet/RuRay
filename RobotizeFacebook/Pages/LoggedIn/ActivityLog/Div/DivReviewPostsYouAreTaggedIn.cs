using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class DivReviewPostsYouAreTaggedIn : PageBase
    {
        public override string PageUrl => "allactivity/?category_key=review&log_filter=review";

        public DivReviewPostsYouAreTaggedIn(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
