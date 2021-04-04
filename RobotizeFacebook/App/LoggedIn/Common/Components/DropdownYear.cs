using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Enum;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn
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
