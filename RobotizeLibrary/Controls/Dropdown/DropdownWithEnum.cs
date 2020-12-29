using OpenQA.Selenium.Remote;
using RobotizeLibrary.Extensions;
using System;

namespace RobotizeToolbox.Controls
{
    /// <summary>
    /// Represents dropdown with elements whose values available for <typeparamref name="TEnum"/>.
    /// </summary>
    public abstract class DropdownWithEnum<TEnum> : Combobox where TEnum : struct, IConvertible
    {
        protected DropdownWithEnum(RemoteWebDriver driver, ExtendBy byForDropdown): base(driver, byForDropdown)
        {
        }

        public void Select(TEnum option)
        {

        }
    }
}