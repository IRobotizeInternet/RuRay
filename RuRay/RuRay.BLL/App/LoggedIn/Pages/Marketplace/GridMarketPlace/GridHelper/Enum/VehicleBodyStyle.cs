using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleBodyStyle.
    /// </summary>
    public enum VehicleBodyStyle
    {
        /// <summary>
        /// Defines the Convertibles.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Convertible), typeof(ResBodyStyle))]
        Convertibles = 1,

        /// <summary>
        /// Defines the Coupe.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Coupe), typeof(ResBodyStyle))]
        Coupe = 2,

        /// <summary>
        /// Defines the Hatchback.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Hatchback), typeof(ResBodyStyle))]
        Hatchback = 3,

        /// <summary>
        /// Defines the Minivan.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Minivan), typeof(ResBodyStyle))]
        Minivan = 4,

        /// <summary>
        /// Defines the Sedan.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Sedan), typeof(ResBodyStyle))]
        Sedan = 5,

        /// <summary>
        /// Defines the StationWagon.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.StationWagon), typeof(ResBodyStyle))]
        StationWagon = 6,

        /// <summary>
        /// Defines the SUV.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.SUV), typeof(ResBodyStyle))]
        SUV = 7,

        /// <summary>
        /// Defines the Truck.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Truck), typeof(ResBodyStyle))]
        Truck = 8,

        /// <summary>
        /// Defines the SmallCar.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.SmallCar), typeof(ResBodyStyle))]
        SmallCar = 9,

        /// <summary>
        /// Defines the Other.
        /// </summary>
        [LocalizedDescription(nameof(ResBodyStyle.Other), typeof(ResBodyStyle))]
        Other = 10
    }
}
