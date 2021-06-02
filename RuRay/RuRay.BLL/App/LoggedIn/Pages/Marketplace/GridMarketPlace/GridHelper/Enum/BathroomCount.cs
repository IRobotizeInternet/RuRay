using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the BathroomCount.
    /// </summary>
    public enum BathroomCount
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 0,

        /// <summary>
        /// Defines the One.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._1), typeof(ResCategory))]
        One = 1,

        /// <summary>
        /// Defines the OneAndHalf.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._1_5), typeof(ResCategory))]
        OneAndHalf = 15,

        /// <summary>
        /// Defines the Two.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._2), typeof(ResCategory))]
        Two = 2,

        /// <summary>
        /// Defines the Three.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._3), typeof(ResCategory))]
        Three = 3,

        /// <summary>
        /// Defines the Four.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._4), typeof(ResCategory))]
        Four = 4,

        /// <summary>
        /// Defines the Five.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._5), typeof(ResCategory))]
        Five = 5,

        /// <summary>
        /// Defines the Six.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory._6), typeof(ResCategory))]
        Six = 6,
    }
}
