using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="HoverOverLike" />.
    /// </summary>
    public class HoverOverLike : BaseHoverOver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoverOverLike"/> class.
        /// </summary>
        public HoverOverLike()
        {
        }

        /// <summary>
        /// Defines the BaseXPath.
        /// </summary>
        public string BaseXPath = "//div[@data-pagelet='page']/following-sibling::div/div//div";

        /// <summary>
        /// Gets the ButtonReactionLike.
        /// </summary>
        public Button ButtonReactionLike => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Like}')]"));

        /// <summary>
        /// Gets the ButtonReactionLove.
        /// </summary>
        public Button ButtonReactionLove => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Love}')]"));

        /// <summary>
        /// Gets the ButtonReactionCare.
        /// </summary>
        public Button ButtonReactionCare => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Care}')]"));

        /// <summary>
        /// Gets the ButtonReactionHaha.
        /// </summary>
        public Button ButtonReactionHaha => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Haha}')]"));

        /// <summary>
        /// Gets the ButtonReactionWow.
        /// </summary>
        public Button ButtonReactionWow => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Wow}')]"));

        /// <summary>
        /// Gets the ButtonReactionSad.
        /// </summary>
        public Button ButtonReactionSad => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Sad}')]"));

        /// <summary>
        /// Gets the ButtonReactionAngry.
        /// </summary>
        public Button ButtonReactionAngry => new Button(Driver, By.XPath($"{BaseXPath}[contains(@aria-label,'{ResHomePage.Angry}')]"));
    }
}
