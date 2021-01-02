using RobotizeFacebook.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public enum VehicleBodyStyle
    {
        [LocalizedDescription(nameof(ResCategory.Convertible), typeof(ResCategory))]
        Convertibles = 1,
        [LocalizedDescription(nameof(ResCategory.Coupe), typeof(ResCategory))]
        Coupe = 2,
        [LocalizedDescription(nameof(ResCategory.Hatchback), typeof(ResCategory))]
        Hatchback = 3,
        [LocalizedDescription(nameof(ResCategory.Minivan), typeof(ResCategory))]
        Minivan = 4,
        [LocalizedDescription(nameof(ResCategory.Sedan), typeof(ResCategory))]
        Sedan = 5,
        [LocalizedDescription(nameof(ResCategory.StationWagon), typeof(ResCategory))]
        StationWagon = 6,
        [LocalizedDescription(nameof(ResCategory.SUV), typeof(ResCategory))]
        SUV = 7,
        [LocalizedDescription(nameof(ResCategory.Truck), typeof(ResCategory))]
        Truck = 8,
        [LocalizedDescription(nameof(ResCategory.SmallCar), typeof(ResCategory))]
        SmallCar = 9,
        [LocalizedDescription(nameof(ResCategory.Other), typeof(ResCategory))]
        Other = 10
    }
}