using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the BedSize.
    /// </summary>
    public enum BedSize
    {
        /// <summary>
        /// Defines the Womens.
        /// </summary>
        [LocalizedDescription(nameof(ResBedSize.Full), typeof(ResBedSize))]
        Womens = 0,

        /// <summary>
        /// Defines the Mens.
        /// </summary>
        [LocalizedDescription(nameof(ResBedSize.King), typeof(ResBedSize))]
        Mens = 1,

        /// <summary>
        /// Defines the KidsClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResBedSize.Queen), typeof(ResBedSize))]
        KidsClothing = 2,

        /// <summary>
        /// Defines the BabyClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResBedSize.Twin), typeof(ResBedSize))]
        BabyClothing = 3
    }
}
