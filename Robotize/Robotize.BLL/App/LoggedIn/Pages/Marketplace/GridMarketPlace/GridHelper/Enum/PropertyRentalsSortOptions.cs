using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum PropertyRentalsSortOption
    {
        [LocalizedDescription(nameof(ResCategory.Recommended), typeof(ResCategory))]
        Recommended = 1,
        [LocalizedDescription(nameof(ResCategory.PriceLowestFirst), typeof(ResCategory))]
        PriceLowestFirst = 2,
        [LocalizedDescription(nameof(ResCategory.PriceHighestFirst), typeof(ResCategory))]
        PriceHighestFirst = 3,
        [LocalizedDescription(nameof(ResCategory.DistanceNearestFirst), typeof(ResCategory))]
        DistanceNearestFirst = 4,
        [LocalizedDescription(nameof(ResCategory.DistanceFarthestFirst), typeof(ResCategory))]
        DistanceFarthestFirst = 5
    }
}
