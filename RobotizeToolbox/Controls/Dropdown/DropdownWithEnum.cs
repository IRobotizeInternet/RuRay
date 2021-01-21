using OpenQA.Selenium.Remote;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.Enums;
using System;

namespace RobotizeToolbox.Controls
{
    /// <summary>
    /// Represents dropdown with elements whose values available for <typeparamref name="TEnum"/>.
    /// </summary>
    public abstract class DropdownWithEnum<TEnum> : Combobox where TEnum : Enum
    {
        protected DropdownWithEnum(RemoteWebDriver driver, ExtendBy byForDropdown): base(driver, byForDropdown)
        {
        }

        public void Select(TEnum option)
        {
            var enumVal = option.GetDescription();
            base.Select(enumVal);
        }
    }
}