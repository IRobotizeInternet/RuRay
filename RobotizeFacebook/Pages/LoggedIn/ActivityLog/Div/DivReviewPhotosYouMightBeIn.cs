using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages
{
    public class DivReviewPhotosYouMightBeIn : PageBase
    {
        public override string PageUrl => "/allactivity/?category_key=facealerts&log_filter=photoreview";

        public DivReviewPhotosYouMightBeIn(RemoteWebDriver driver, WebDriverWait wait)
        {

        }
    }
}
