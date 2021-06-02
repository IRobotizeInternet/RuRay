using OpenQA.Selenium.Remote;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="DropdownYear" />.
    /// </summary>
    public class DropdownYear : DropdownWithEnum<FilterYear>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownYear"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForDropdown">The byForDropdown<see cref="ExtendBy"/>.</param>
        public DropdownYear(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }

    /// <summary>
    /// Defines the <see cref="DropdownWhereToPost" />.
    /// </summary>
    public class DropdownWhereToPost : DropdownWithEnum<WhereToPost>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownWhereToPost"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForDropdown">The byForDropdown<see cref="ExtendBy"/>.</param>
        public DropdownWhereToPost(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }
}
