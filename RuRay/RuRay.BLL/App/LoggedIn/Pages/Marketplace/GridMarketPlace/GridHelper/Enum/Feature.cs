using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the Feature.
    /// </summary>
    public enum Feature
    {
        /// <summary>
        /// Defines the FourK.
        /// </summary>
        [LocalizedDescription(nameof(ResFeature.FourK), typeof(ResFeature))]
        FourK = 0,

        /// <summary>
        /// Defines the EightK.
        /// </summary>
        [LocalizedDescription(nameof(ResFeature.EightK), typeof(ResFeature))]
        EightK = 1,

        /// <summary>
        /// Defines the FullHD.
        /// </summary>
        [LocalizedDescription(nameof(ResFeature.FullHD), typeof(ResFeature))]
        FullHD = 2,

        /// <summary>
        /// Defines the SmartTVs.
        /// </summary>
        [LocalizedDescription(nameof(ResFeature.SmartTVs), typeof(ResFeature))]
        SmartTVs = 3,
    }
}
