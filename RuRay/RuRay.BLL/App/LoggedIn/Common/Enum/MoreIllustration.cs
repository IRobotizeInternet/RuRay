using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Enum
{
    /// <summary>
    /// Defines the MoreIllustration.
    /// </summary>
    public enum MoreIllustration
    {
        /// <summary>
        /// Defines the Holiday.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.Holiday), typeof(ResLeftNav))] Holiday = 0,

        /// <summary>
        /// Defines the Recreation.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.Recreation), typeof(ResLeftNav))] Recreation = 1,

        /// <summary>
        /// Defines the Seasons.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.Seasons), typeof(ResLeftNav))] Seasons = 2,

        /// <summary>
        /// Defines the Travel.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.Travel), typeof(ResLeftNav))] Travel = 3,
    }
}
