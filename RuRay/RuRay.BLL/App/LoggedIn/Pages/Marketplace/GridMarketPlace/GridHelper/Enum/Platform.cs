using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the Platform.
    /// </summary>
    public enum Platform
    {
        /// <summary>
        /// Defines the Nintendo2DS.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.Nintendo2DS), typeof(ResPlatform))]
        Nintendo2DS = 0,

        /// <summary>
        /// Defines the Nintendo3DS.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.Nintendo3DS), typeof(ResPlatform))]
        Nintendo3DS = 1,

        /// <summary>
        /// Defines the NintendoDS.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.NintendoDS), typeof(ResPlatform))]
        NintendoDS = 2,

        /// <summary>
        /// Defines the NintendoGameBoy.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.NintendoGameBoy), typeof(ResPlatform))]
        NintendoGameBoy = 3,

        /// <summary>
        /// Defines the NintendoSwitch.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.NintendoSwitch), typeof(ResPlatform))]
        NintendoSwitch = 4,

        /// <summary>
        /// Defines the NintendoWii.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.NintendoWii), typeof(ResPlatform))]
        NintendoWii = 5,

        /// <summary>
        /// Defines the PlayStation2.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.PlayStation2), typeof(ResPlatform))]
        PlayStation2 = 6,

        /// <summary>
        /// Defines the PlayStation4.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.PlayStation4), typeof(ResPlatform))]
        PlayStation4 = 7,

        /// <summary>
        /// Defines the Playstation3.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.Playstation3), typeof(ResPlatform))]
        Playstation3 = 8,

        /// <summary>
        /// Defines the Xbox360.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.Xbox360), typeof(ResPlatform))]
        Xbox360 = 9,

        /// <summary>
        /// Defines the XboxOne.
        /// </summary>
        [LocalizedDescription(nameof(ResPlatform.XboxOne), typeof(ResPlatform))]
        XboxOne = 10
    }
}
