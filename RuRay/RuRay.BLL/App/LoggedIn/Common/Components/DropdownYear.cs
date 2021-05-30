using OpenQA.Selenium.Remote;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRayLibrary.Extensions;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn
{
    public class DropdownYear : DropdownWithEnum<FilterYear>
    {
        public DropdownYear(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }

    public class DropdownWhereToPost : DropdownWithEnum<WhereToPost>
    {
        public DropdownWhereToPost(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }
    }
}
