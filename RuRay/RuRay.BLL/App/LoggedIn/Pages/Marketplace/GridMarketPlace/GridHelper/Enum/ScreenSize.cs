using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the ScreenSize.
    /// </summary>
    public enum ScreenSize
    {
        /// <summary>
        /// Defines the ThirtyTwoInAndUnder.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.ThirtyTwoInAndUnder), typeof(ResScreenSize))]
        ThirtyTwoInAndUnder = 0,

        /// <summary>
        /// Defines the ThirtyIn43In.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.ThirtyIn43In), typeof(ResScreenSize))]
        ThirtyIn43In = 1,

        /// <summary>
        /// Defines the FortyFourIn49In.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.FortyFourIn49In), typeof(ResScreenSize))]
        FortyFourIn49In = 2,

        /// <summary>
        /// Defines the FiftyIn59In.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.FiftyIn59In), typeof(ResScreenSize))]
        FiftyIn59In = 3,

        /// <summary>
        /// Defines the SixtyIn69In.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.SixtyIn69In), typeof(ResScreenSize))]
        SixtyIn69In = 4,

        /// <summary>
        /// Defines the SeventyInAndUp.
        /// </summary>
        [LocalizedDescription(nameof(ResScreenSize.SeventyInAndUp), typeof(ResScreenSize))]
        SeventyInAndUp = 5
    }
}
