using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum VehicleBodyStyle
    {
        [LocalizedDescription(nameof(ResBodyStyle.Convertible), typeof(ResBodyStyle))]
        Convertibles = 1,
        [LocalizedDescription(nameof(ResBodyStyle.Coupe), typeof(ResBodyStyle))]
        Coupe = 2,
        [LocalizedDescription(nameof(ResBodyStyle.Hatchback), typeof(ResBodyStyle))]
        Hatchback = 3,
        [LocalizedDescription(nameof(ResBodyStyle.Minivan), typeof(ResBodyStyle))]
        Minivan = 4,
        [LocalizedDescription(nameof(ResBodyStyle.Sedan), typeof(ResBodyStyle))]
        Sedan = 5,
        [LocalizedDescription(nameof(ResBodyStyle.StationWagon), typeof(ResBodyStyle))]
        StationWagon = 6,
        [LocalizedDescription(nameof(ResBodyStyle.SUV), typeof(ResBodyStyle))]
        SUV = 7,
        [LocalizedDescription(nameof(ResBodyStyle.Truck), typeof(ResBodyStyle))]
        Truck = 8,
        [LocalizedDescription(nameof(ResBodyStyle.SmallCar), typeof(ResBodyStyle))]
        SmallCar = 9,
        [LocalizedDescription(nameof(ResBodyStyle.Other), typeof(ResBodyStyle))]
        Other = 10
    }
}