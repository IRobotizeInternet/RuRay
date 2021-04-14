using RobotizeToolbox.CustomAttributes;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum VehicleType
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,
        [LocalizedDescription(nameof(ResCategory.CarsAndTrucks), typeof(ResCategory))]
        CarsAndTrucks = 2,
        [LocalizedDescription(nameof(ResCategory.Motorcycles), typeof(ResCategory))]
        Motorcycles = 3,
        [LocalizedDescription(nameof(ResCategory.Powersports), typeof(ResCategory))]
        Powersports = 4,
        [LocalizedDescription(nameof(ResCategory.RVSAndCampers), typeof(ResCategory))]
        RVSAndCampers = 5,
        [LocalizedDescription(nameof(ResCategory.Boats), typeof(ResCategory))]
        Boats = 6,
        [LocalizedDescription(nameof(ResCategory.CommercialAndIndustrial), typeof(ResCategory))]
        CommercialAndIndustrial = 7,
        [LocalizedDescription(nameof(ResCategory.Trailers), typeof(ResCategory))]
        Trailers = 8,
        [LocalizedDescription(nameof(ResCategory.Other), typeof(ResCategory))]
        Other = 9
    }
}
