using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleSortOption.
    /// </summary>
    public enum VehicleSortOption
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
        /// Defines the DateListNewestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DateListedNewestFirst), typeof(ResCategory))]
        DateListNewestFirst = 4,

        /// <summary>
        /// Defines the DateListOldestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DateListedOldestFirst), typeof(ResCategory))]
        DateListOldestFirst = 5,

        /// <summary>
        /// Defines the DistanceNearestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DistanceNearestFirst), typeof(ResCategory))]
        DistanceNearestFirst = 6,

        /// <summary>
        /// Defines the DistanceFarthestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DistanceFarthestFirst), typeof(ResCategory))]
        DistanceFarthestFirst = 7,

        /// <summary>
        /// Defines the MilageLowestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MilageLowestFirst), typeof(ResCategory))]
        MilageLowestFirst = 8,

        /// <summary>
        /// Defines the MilageHighestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MilageHigestFirst), typeof(ResCategory))]
        MilageHighestFirst = 9,

        /// <summary>
        /// Defines the YearNewestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YearNewestFirst), typeof(ResCategory))]
        YearNewestFirst = 10,

        /// <summary>
        /// Defines the YearOldestFirst.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YearOldestFirst), typeof(ResCategory))]
        YearOldestFirst = 11
    }
}
