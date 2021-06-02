using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="Header" />.
    /// </summary>
    public class Header : IHeaderNavigation
    {
        /// <summary>
        /// Gets the RightMenu.
        /// </summary>
        public HeaderRightMenu RightMenu { get; }

        /// <summary>
        /// Gets the MiddleMenu.
        /// </summary>
        public HeaderMiddleMenu MiddleMenu { get; }

        /// <summary>
        /// Gets the LeftMenu.
        /// </summary>
        public HeaderLeftMenu LeftMenu { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        public Header()
        {
            RightMenu = new HeaderRightMenu();
            MiddleMenu = new HeaderMiddleMenu();
            LeftMenu = new HeaderLeftMenu();
        }

        /// <summary>
        /// The Get.
        /// </summary>
        public void Get()
        {
        }
    }
}
