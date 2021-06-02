using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleType.
    /// </summary>
    public enum VehicleType
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,

        /// <summary>
        /// Defines the CarsAndTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CarsAndTrucks), typeof(ResCategory))]
        CarsAndTrucks = 2,

        /// <summary>
        /// Defines the Motorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Motorcycles), typeof(ResCategory))]
        Motorcycles = 3,

        /// <summary>
        /// Defines the Powersports.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Powersports), typeof(ResCategory))]
        Powersports = 4,

        /// <summary>
        /// Defines the RVSAndCampers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RVSAndCampers), typeof(ResCategory))]
        RVSAndCampers = 5,

        /// <summary>
        /// Defines the Boats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Boats), typeof(ResCategory))]
        Boats = 6,

        /// <summary>
        /// Defines the CommercialAndIndustrial.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CommercialAndIndustrial), typeof(ResCategory))]
        CommercialAndIndustrial = 7,

        /// <summary>
        /// Defines the Trailers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Trailers), typeof(ResCategory))]
        Trailers = 8,

        /// <summary>
        /// Defines the Other.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Other), typeof(ResCategory))]
        Other = 9
    }
}
