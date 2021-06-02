using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the Finish.
    /// </summary>
    public enum Finish
    {
        /// <summary>
        /// Defines the Distressed.
        /// </summary>
        [LocalizedDescription(nameof(ResFinish.Distressed), typeof(ResFinish))] Distressed = 0,

        /// <summary>
        /// Defines the Mirrored.
        /// </summary>
        [LocalizedDescription(nameof(ResFinish.Mirrored), typeof(ResFinish))] Mirrored = 1,

        /// <summary>
        /// Defines the Painted.
        /// </summary>
        [LocalizedDescription(nameof(ResFinish.Painted), typeof(ResFinish))] Painted = 2,

        /// <summary>
        /// Defines the Stained.
        /// </summary>
        [LocalizedDescription(nameof(ResFinish.Stained), typeof(ResFinish))] Stained = 3,
    }
}
