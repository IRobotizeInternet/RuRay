using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleCategory.
    /// </summary>
    public enum VehicleCategory
    {
        /// <summary>
        /// Defines the Boats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Boats), typeof(ResCategory))]
        Boats = 1,

        /// <summary>
        /// Defines the Cars.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cars), typeof(ResCategory))]
        Cars = 2,

        /// <summary>
        /// Defines the Motorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Motorcycles), typeof(ResCategory))]
        Motorcycles = 3,

        /// <summary>
        /// Defines the PowersportVehicles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.PowersportVehicles), typeof(ResCategory))]
        PowersportVehicles = 4,

        /// <summary>
        /// Defines the RVCampers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RVCampers), typeof(ResCategory))]
        RVCampers = 5,

        /// <summary>
        /// Defines the Trailers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Trailers), typeof(ResCategory))]
        Trailers = 6,

        /// <summary>
        /// Defines the Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Trucks), typeof(ResCategory))]
        Trucks = 7,
    }

    /// <summary>
    /// Defines the BoatCategory.
    /// </summary>
    public enum BoatCategory
    {
        /// <summary>
        /// Defines the Sailboats.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Sailboats), typeof(ResCategory))]
        Sailboats = 1
    }

    /// <summary>
    /// Defines the CarCategory.
    /// </summary>
    public enum CarCategory
    {
        /// <summary>
        /// Defines the Convertibles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Convertibles), typeof(ResCategory))]
        Convertibles = 1,

        /// <summary>
        /// Defines the Coupes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Coupes), typeof(ResCategory))]
        Coupes = 2,

        /// <summary>
        /// Defines the Hatchbacks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Hatchbacks), typeof(ResCategory))]
        Hatchbacks = 3,

        /// <summary>
        /// Defines the Minivans.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Minivans), typeof(ResCategory))]
        Minivans = 4,

        /// <summary>
        /// Defines the SUVs.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SUVs), typeof(ResCategory))]
        SUVs = 5,

        /// <summary>
        /// Defines the Sedans.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Sedans), typeof(ResCategory))]
        Sedans = 6,

        /// <summary>
        /// Defines the StationWagons.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.StationWagons), typeof(ResCategory))]
        StationWagons = 7
    }

    /// <summary>
    /// Defines the MotorcycleCategory.
    /// </summary>
    public enum MotorcycleCategory
    {
        /// <summary>
        /// Defines the HondaCBRMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HondaCBRMotorcycles), typeof(ResCategory))]
        HondaCBRMotorcycles = 1,

        /// <summary>
        /// Defines the HondaCRMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HondaCRMotorcycles), typeof(ResCategory))]
        HondaCRMotorcycles = 2,

        /// <summary>
        /// Defines the HondaCRFMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HondaCRFMotorcycles), typeof(ResCategory))]
        HondaCRFMotorcycles = 3,

        /// <summary>
        /// Defines the HondaShadowMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HondaShadowMotorcycles), typeof(ResCategory))]
        HondaShadowMotorcycles = 4,

        /// <summary>
        /// Defines the HondaXRMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HondaXRMotorcycles), typeof(ResCategory))]
        HondaXRMotorcycles = 5,

        /// <summary>
        /// Defines the KawasakiKXMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KawasakiKXMotorcycles), typeof(ResCategory))]
        KawasakiKXMotorcycles = 6,

        /// <summary>
        /// Defines the KawasakiNinjaMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.KawasakiNinjaMotorcycles), typeof(ResCategory))]
        KawasakiNinjaMotorcycles = 7,

        /// <summary>
        /// Defines the MotorScooters.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MotorScooters), typeof(ResCategory))]
        MotorScooters = 8,

        /// <summary>
        /// Defines the SuzukiGSXRMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.SuzukiGSXRMotorcycles), typeof(ResCategory))]
        SuzukiGSXRMotorcycles = 9,

        /// <summary>
        /// Defines the YamahaVStarMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YamahaVStarMotorcycles), typeof(ResCategory))]
        YamahaVStarMotorcycles = 10,

        /// <summary>
        /// Defines the YamahaYZMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YamahaYZMotorcycles), typeof(ResCategory))]
        YamahaYZMotorcycles = 11,

        /// <summary>
        /// Defines the YamahaYZ250FMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YamahaYZ250FMotorcycles), typeof(ResCategory))]
        YamahaYZ250FMotorcycles = 12,

        /// <summary>
        /// Defines the YamahaYZFMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YamahaYZFMotorcycles), typeof(ResCategory))]
        YamahaYZFMotorcycles = 13,

        /// <summary>
        /// Defines the YamahaYzfr.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.YamahaYzfr), typeof(ResCategory))]
        YamahaYzfr = 14
    }

    /// <summary>
    /// Defines the PowersportCategory.
    /// </summary>
    public enum PowersportCategory
    {
        /// <summary>
        /// Defines the ATVsFourWheelers.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ATVsFourWheelers), typeof(ResCategory))]
        ATVsFourWheelers = 1,

        /// <summary>
        /// Defines the DirtBikes.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DirtBikes), typeof(ResCategory))]
        DirtBikes = 2,

        /// <summary>
        /// Defines the GoKarts.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GoKarts), typeof(ResCategory))]
        GoKarts = 3,

        /// <summary>
        /// Defines the HondaShadowMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GolfCarts), typeof(ResCategory))]
        HondaShadowMotorcycles = 4,

        /// <summary>
        /// Defines the HondaXRMotorcycles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.JetSkis), typeof(ResCategory))]
        HondaXRMotorcycles = 5,

        /// <summary>
        /// Defines the Snowmobiles.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Snowmobiles), typeof(ResCategory))]
        Snowmobiles = 6
    }

    /// <summary>
    /// Defines the TruckCategory.
    /// </summary>
    public enum TruckCategory
    {
        /// <summary>
        /// Defines the ChevroletS10Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChevroletS10Trucks), typeof(ResCategory))]
        ChevroletS10Trucks = 1,

        /// <summary>
        /// Defines the ChevroletSilverado1500Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChevroletSilverado1500Trucks), typeof(ResCategory))]
        ChevroletSilverado1500Trucks = 2,

        /// <summary>
        /// Defines the ChevroletSilverado2500Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ChevroletSilverado2500Trucks), typeof(ResCategory))]
        ChevroletSilverado2500Trucks = 3,

        /// <summary>
        /// Defines the DodgeRam1500Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DodgeRam1500Trucks), typeof(ResCategory))]
        DodgeRam1500Trucks = 4,

        /// <summary>
        /// Defines the DodgePowerWagons.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.DodgePowerWagons), typeof(ResCategory))]
        DodgePowerWagons = 5,

        /// <summary>
        /// Defines the FordF150Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FordF150Trucks), typeof(ResCategory))]
        FordF150Trucks = 6,

        /// <summary>
        /// Defines the FordF250SuperDutyTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FordF250SuperDutyTrucks), typeof(ResCategory))]
        FordF250SuperDutyTrucks = 7,

        /// <summary>
        /// Defines the FordF350Trucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FordF350Trucks), typeof(ResCategory))]
        FordF350Trucks = 8,

        /// <summary>
        /// Defines the FordRangerTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FordRangerTrucks), typeof(ResCategory))]
        FordRangerTrucks = 9,

        /// <summary>
        /// Defines the GMCSierraTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GMCSierraTrucks), typeof(ResCategory))]
        GMCSierraTrucks = 10,

        /// <summary>
        /// Defines the ToyotaTacomaTrucks.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ToyotaTacomaTrucks), typeof(ResCategory))]
        ToyotaTacomaTrucks = 11
    }
}
