using OpenQA.Selenium.Remote;
using RuRayLibrary.Extensions;
using RuRayToolbox.Enums;
using System;

namespace RuRayToolbox.Controls
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