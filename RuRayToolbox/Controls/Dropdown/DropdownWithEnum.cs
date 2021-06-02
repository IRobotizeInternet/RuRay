using System;
using OpenQA.Selenium.Remote;
using RuRayLibrary.Extensions;
using RuRayToolbox.Enums;

namespace RuRayToolbox.Controls
{
    /// <summary>
    /// Represents dropdown with elements whose values available for <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum">.</typeparam>
    public abstract class DropdownWithEnum<TEnum> : Combobox where TEnum : Enum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownWithEnum{TEnum}"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="byForDropdown">The byForDropdown<see cref="ExtendBy"/>.</param>
        protected DropdownWithEnum(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
        {
        }

        /// <summary>
        /// The Select.
        /// </summary>
        /// <param name="option">The option<see cref="TEnum"/>.</param>
        public void Select(TEnum option)
        {
            var enumVal = option.GetDescription();
            base.Select(enumVal);
        }
    }
}
