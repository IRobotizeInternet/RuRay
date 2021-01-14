using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class DivReviewTagsOnYourPosts : PageBase
    {
        public override string PageUrl => "/allactivity/?category_key=tagreview&log_filter=tagreview";

        public DivReviewTagsOnYourPosts(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
