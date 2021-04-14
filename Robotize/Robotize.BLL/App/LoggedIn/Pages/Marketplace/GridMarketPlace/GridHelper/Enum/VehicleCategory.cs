using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum VehicleCategory
    {
        [LocalizedDescription(nameof(ResCategory.Boats), typeof(ResCategory))]
        Boats = 1,
        [LocalizedDescription(nameof(ResCategory.Cars), typeof(ResCategory))]
        Cars = 2,
        [LocalizedDescription(nameof(ResCategory.Motorcycles), typeof(ResCategory))]
        Motorcycles = 3,
        [LocalizedDescription(nameof(ResCategory.PowersportVehicles), typeof(ResCategory))]
        PowersportVehicles = 4,
        [LocalizedDescription(nameof(ResCategory.RVCampers), typeof(ResCategory))]
        RVCampers = 5,
        [LocalizedDescription(nameof(ResCategory.Trailers), typeof(ResCategory))]
        Trailers = 6,
        [LocalizedDescription(nameof(ResCategory.Trucks), typeof(ResCategory))]
        Trucks = 7,
    }

    public enum BoatCategory
    {
        [LocalizedDescription(nameof(ResCategory.Sailboats), typeof(ResCategory))]
        Sailboats = 1
    }

    public enum CarCategory
    {
        [LocalizedDescription(nameof(ResCategory.Convertibles), typeof(ResCategory))]
        Convertibles = 1,
        [LocalizedDescription(nameof(ResCategory.Coupes), typeof(ResCategory))]
        Coupes = 2,
        [LocalizedDescription(nameof(ResCategory.Hatchbacks), typeof(ResCategory))]
        Hatchbacks = 3,
        [LocalizedDescription(nameof(ResCategory.Minivans), typeof(ResCategory))]
        Minivans = 4,
        [LocalizedDescription(nameof(ResCategory.SUVs), typeof(ResCategory))]
        SUVs = 5,
        [LocalizedDescription(nameof(ResCategory.Sedans), typeof(ResCategory))]
        Sedans = 6,
        [LocalizedDescription(nameof(ResCategory.StationWagons), typeof(ResCategory))]
        StationWagons = 7
    }

    public enum MotorcycleCategory
    {
        [LocalizedDescription(nameof(ResCategory.HondaCBRMotorcycles), typeof(ResCategory))]
        HondaCBRMotorcycles = 1,
        [LocalizedDescription(nameof(ResCategory.HondaCRMotorcycles), typeof(ResCategory))]
        HondaCRMotorcycles = 2,
        [LocalizedDescription(nameof(ResCategory.HondaCRFMotorcycles), typeof(ResCategory))]
        HondaCRFMotorcycles = 3,
        [LocalizedDescription(nameof(ResCategory.HondaShadowMotorcycles), typeof(ResCategory))]
        HondaShadowMotorcycles = 4,
        [LocalizedDescription(nameof(ResCategory.HondaXRMotorcycles), typeof(ResCategory))]
        HondaXRMotorcycles = 5,
        [LocalizedDescription(nameof(ResCategory.KawasakiKXMotorcycles), typeof(ResCategory))]
        KawasakiKXMotorcycles = 6,
        [LocalizedDescription(nameof(ResCategory.KawasakiNinjaMotorcycles), typeof(ResCategory))]
        KawasakiNinjaMotorcycles = 7,
        [LocalizedDescription(nameof(ResCategory.MotorScooters), typeof(ResCategory))]
        MotorScooters = 8,
        [LocalizedDescription(nameof(ResCategory.SuzukiGSXRMotorcycles), typeof(ResCategory))]
        SuzukiGSXRMotorcycles = 9,
        [LocalizedDescription(nameof(ResCategory.YamahaVStarMotorcycles), typeof(ResCategory))]
        YamahaVStarMotorcycles = 10,
        [LocalizedDescription(nameof(ResCategory.YamahaYZMotorcycles), typeof(ResCategory))]
        YamahaYZMotorcycles = 11,
        [LocalizedDescription(nameof(ResCategory.YamahaYZ250FMotorcycles), typeof(ResCategory))]
        YamahaYZ250FMotorcycles = 12,
        [LocalizedDescription(nameof(ResCategory.YamahaYZFMotorcycles), typeof(ResCategory))]
        YamahaYZFMotorcycles = 13,
        [LocalizedDescription(nameof(ResCategory.YamahaYzfr), typeof(ResCategory))]
        YamahaYzfr = 14
    }

    public enum PowersportCategory
    {
        [LocalizedDescription(nameof(ResCategory.ATVsFourWheelers), typeof(ResCategory))]
        ATVsFourWheelers = 1,
        [LocalizedDescription(nameof(ResCategory.DirtBikes), typeof(ResCategory))]
        DirtBikes = 2,
        [LocalizedDescription(nameof(ResCategory.GoKarts), typeof(ResCategory))]
        GoKarts = 3,
        [LocalizedDescription(nameof(ResCategory.GolfCarts), typeof(ResCategory))]
        HondaShadowMotorcycles = 4,
        [LocalizedDescription(nameof(ResCategory.JetSkis), typeof(ResCategory))]
        HondaXRMotorcycles = 5,
        [LocalizedDescription(nameof(ResCategory.Snowmobiles), typeof(ResCategory))]
        Snowmobiles = 6
    }

    public enum TruckCategory
    {
        [LocalizedDescription(nameof(ResCategory.ChevroletS10Trucks), typeof(ResCategory))]
        ChevroletS10Trucks = 1,
        [LocalizedDescription(nameof(ResCategory.ChevroletSilverado1500Trucks), typeof(ResCategory))]
        ChevroletSilverado1500Trucks = 2,
        [LocalizedDescription(nameof(ResCategory.ChevroletSilverado2500Trucks), typeof(ResCategory))]
        ChevroletSilverado2500Trucks = 3,
        [LocalizedDescription(nameof(ResCategory.DodgeRam1500Trucks), typeof(ResCategory))]
        DodgeRam1500Trucks = 4,
        [LocalizedDescription(nameof(ResCategory.DodgePowerWagons), typeof(ResCategory))]
        DodgePowerWagons = 5,
        [LocalizedDescription(nameof(ResCategory.FordF150Trucks), typeof(ResCategory))]
        FordF150Trucks = 6,
        [LocalizedDescription(nameof(ResCategory.FordF250SuperDutyTrucks), typeof(ResCategory))]
        FordF250SuperDutyTrucks = 7,
        [LocalizedDescription(nameof(ResCategory.FordF350Trucks), typeof(ResCategory))]
        FordF350Trucks = 8,
        [LocalizedDescription(nameof(ResCategory.FordRangerTrucks), typeof(ResCategory))]
        FordRangerTrucks = 9,
        [LocalizedDescription(nameof(ResCategory.GMCSierraTrucks), typeof(ResCategory))]
        GMCSierraTrucks = 10,
        [LocalizedDescription(nameof(ResCategory.ToyotaTacomaTrucks), typeof(ResCategory))]
        ToyotaTacomaTrucks = 11
    }
}
