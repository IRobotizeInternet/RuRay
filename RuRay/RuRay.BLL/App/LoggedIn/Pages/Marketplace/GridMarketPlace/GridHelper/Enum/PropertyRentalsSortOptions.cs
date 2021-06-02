using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the PropertyRentalsSortOption.
    /// </summary>
    public enum PropertyRentalsSortOption
    {
        /// <summary>
        /// Defines the Recommended.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Recommended), typeof(ResCategory))]
        Recommended = 1,

        /// <summary>
        /// Defines the PriceLowestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PriceLowestFirst), typeof(ResCategory))]
        PriceLowestFirst = 2,

        /// <summary>
        /// Defines the PriceHighestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PriceHighestFirst), typeof(ResCategory))]
        PriceHighestFirst = 3,

        /// <summary>
        /// Defines the DistanceNearestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DistanceNearestFirst), typeof(ResCategory))]
        DistanceNearestFirst = 4,

        /// <summary>
        /// Defines the DistanceFarthestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DistanceFarthestFirst), typeof(ResCategory))]
        DistanceFarthestFirst = 5
    }
}
