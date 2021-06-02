using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the PostBackgroundcolor.
    /// </summary>
    public enum PostBackgroundcolor
    {
        /// <summary>
        /// Defines the Nobackground.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.Nobackground), typeof(ResPostBackGroundColor))]
        Nobackground = 1,

        /// <summary>
        /// Defines the CloseupChevronKnit.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.CloseupChevronKnit), typeof(ResPostBackGroundColor))]
        CloseupChevronKnit = 2,

        /// <summary>
        /// Defines the BlueMountains.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.BlueMountains), typeof(ResPostBackGroundColor))]
        BlueMountains = 3,

        /// <summary>
        /// Defines the CloseupKnitFabric.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.CloseupKnitFabric), typeof(ResPostBackGroundColor))]
        CloseupKnitFabric = 4,

        /// <summary>
        /// Defines the FamilyWearingSkisSitting.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.FamilyWearingSkisSitting), typeof(ResPostBackGroundColor))]
        FamilyWearingSkisSitting = 5,

        /// <summary>
        /// Defines the SnowCappedMountains.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.SnowCappedMountains), typeof(ResPostBackGroundColor))]
        SnowCappedMountains = 6,

        /// <summary>
        /// Defines the PeoplePlayingAndSkiing.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.PeoplePlayingAndSkiing), typeof(ResPostBackGroundColor))]
        PeoplePlayingAndSkiing = 7,

        /// <summary>
        /// Defines the SolidOrange.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.SolidOrange), typeof(ResPostBackGroundColor))]
        SolidOrange = 6,

        /// <summary>
        /// Defines the SolidRed.
        /// </summary>
        [LocalizedDescription(nameof(ResPostBackGroundColor.SolidRed), typeof(ResPostBackGroundColor))]
        SolidRed = 7,
    }
}
