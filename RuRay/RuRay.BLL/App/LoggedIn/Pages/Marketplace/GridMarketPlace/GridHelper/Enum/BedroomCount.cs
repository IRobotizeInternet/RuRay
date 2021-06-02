using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the BedroomCount.
    /// </summary>
    public enum BedroomCount
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,

        /// <summary>
        /// Defines the one.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._1), typeof(ResCategory))]
        one = 1,

        /// <summary>
        /// Defines the two.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._2), typeof(ResCategory))]
        two = 2,

        /// <summary>
        /// Defines the three.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._3), typeof(ResCategory))]
        three = 3,

        /// <summary>
        /// Defines the four.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._4), typeof(ResCategory))]
        four = 4,

        /// <summary>
        /// Defines the five.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._5), typeof(ResCategory))]
        five = 5,

        /// <summary>
        /// Defines the six.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._6), typeof(ResCategory))]
        six = 6,
    }
}
