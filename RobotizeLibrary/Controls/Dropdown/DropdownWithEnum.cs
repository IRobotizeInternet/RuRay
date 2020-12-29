using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace RobotizeToolbox.Controls
{
    /// <summary>
    /// Represents dropdown with elements whose values available for <typeparamref name="TEnum"/>.
    /// </summary>
    public abstract class DropdownWithEnum<TEnum> : Combobox where TEnum : struct, IConvertible
    {
        protected DropdownWithEnum(RemoteWebDriver driver, By byForDropdown): base(driver, byForDropdown)
        {
        }

        public void Select(TEnum option)
        {

        }
    }
}