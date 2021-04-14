using RobotizeToolbox.CustomAttributes;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum VehicleSortOption
    {
        [LocalizedDescription(nameof(ResCategory.Recommended), typeof(ResCategory))]
        Recommended = 1,
        [LocalizedDescription(nameof(ResCategory.PriceLowestFirst), typeof(ResCategory))]
        PriceLowestFirst = 2,
        [LocalizedDescription(nameof(ResCategory.PriceHighestFirst), typeof(ResCategory))]
        PriceHighestFirst = 3,
        [LocalizedDescription(nameof(ResCategory.DateListedNewestFirst), typeof(ResCategory))]
        DateListNewestFirst = 4,
        [LocalizedDescription(nameof(ResCategory.DateListedOldestFirst), typeof(ResCategory))]
        DateListOldestFirst = 5,
        [LocalizedDescription(nameof(ResCategory.DistanceNearestFirst), typeof(ResCategory))]
        DistanceNearestFirst = 6,
        [LocalizedDescription(nameof(ResCategory.DistanceFarthestFirst), typeof(ResCategory))]
        DistanceFarthestFirst = 7,
        [LocalizedDescription(nameof(ResCategory.MilageLowestFirst), typeof(ResCategory))]
        MilageLowestFirst = 8,
        [LocalizedDescription(nameof(ResCategory.MilageHigestFirst), typeof(ResCategory))]
        MilageHighestFirst = 9,
        [LocalizedDescription(nameof(ResCategory.YearNewestFirst), typeof(ResCategory))]
        YearNewestFirst = 10,
        [LocalizedDescription(nameof(ResCategory.YearOldestFirst), typeof(ResCategory))]
        YearOldestFirst = 11
    }
}
