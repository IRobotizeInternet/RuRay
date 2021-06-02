using System;
using System.ComponentModel;

namespace RuRayToolbox.Enums
{
    /// <summary>
    /// Defines the <see cref="EnumExt" />.
    /// </summary>
    public static class EnumExt
    {
        /// <summary>
        /// The GetDescription.
        /// </summary>
        /// <param name="enumValue">The enumValue<see cref="Enum"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes != null && attributes.Length > 0
                ? attributes[0].Description
                : enumValue.ToString();
        }
    }
}
