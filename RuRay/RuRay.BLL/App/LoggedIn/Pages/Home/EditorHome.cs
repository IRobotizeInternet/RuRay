using OpenQA.Selenium.Remote;
using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="EditorHome" />.
    /// </summary>
    public class EditorHome : Editor<Header, LeftMenuItemsHome, FeedHome>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorHome"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public EditorHome(RemoteWebDriver driver) : base(driver)
        {
        }
    }
}
