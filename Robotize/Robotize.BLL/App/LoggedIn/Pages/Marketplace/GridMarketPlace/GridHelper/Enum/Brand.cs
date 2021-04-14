using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum BrandBagsAndLuggage
    {
        [LocalizedDescription(nameof(ResBrand.Loungefly), typeof(ResBrand))]
        Loungefly = 0,
    }

    public enum BrandRemoteControlToys
    {
        [LocalizedDescription(nameof(ResBrand.DavidYurman), typeof(ResBrand))]
        Axial = 0,
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Traxxas = 1,
    }

    public enum BrandJewelryAndAccessories
    {
        [LocalizedDescription(nameof(ResBrand.DavidYurman), typeof(ResBrand))]
        DavidYurman = 0,
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Gucci = 1,
        [LocalizedDescription(nameof(ResBrand.KendraScott), typeof(ResBrand))]
        KendraScott = 2,
        [LocalizedDescription(nameof(ResBrand.Pandora), typeof(ResBrand))]
        Pandora = 3,
        [LocalizedDescription(nameof(ResBrand.Swarovski), typeof(ResBrand))]
        Swarovski = 4,
        [LocalizedDescription(nameof(ResBrand.Versace), typeof(ResBrand))]
        Versace = 5
    }

    public enum BrandPowerTools
    {
        [LocalizedDescription(nameof(ResBrand.Bosch), typeof(ResBrand))] Bosch = 0,
        [LocalizedDescription(nameof(ResBrand.DEWALT), typeof(ResBrand))] DEWALT = 1,
        [LocalizedDescription(nameof(ResBrand.Lincoln), typeof(ResBrand))] Lincoln = 2,
        [LocalizedDescription(nameof(ResBrand.Makita), typeof(ResBrand))] Makita = 3,
        [LocalizedDescription(nameof(ResBrand.Miller), typeof(ResBrand))] Miller = 4,
        [LocalizedDescription(nameof(ResBrand.Milwaukee), typeof(ResBrand))] Milwaukee = 5,
        [LocalizedDescription(nameof(ResBrand.PORTERCABLE), typeof(ResBrand))] PORTERCABLE = 6,
    }

    public enum BrandHomeGoodTools
    {
        [LocalizedDescription(nameof(ResBrand.Bosch), typeof(ResBrand))] Bosch = 0,
        [LocalizedDescription(nameof(ResBrand.Lincoln), typeof(ResBrand))] Lincoln = 1,
        [LocalizedDescription(nameof(ResBrand.Makita), typeof(ResBrand))] Makita = 2,
        [LocalizedDescription(nameof(ResBrand.Miller), typeof(ResBrand))] Miller = 3
    }

    public enum BrandKidsClothing
    {
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,
        [LocalizedDescription(nameof(ResBrand.MatildaJane), typeof(ResBrand))]
        MatildaJane = 1
    }

    public enum BrandOutdoorCooking
    {
        [LocalizedDescription(nameof(ResBrand.Weber), typeof(ResBrand))]
        Weber = 0
    }

    public enum BrandShoe
    {
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Gucci = 1,
        [LocalizedDescription(nameof(ResBrand.Nike), typeof(ResBrand))]
        Nike = 2
    }

    public enum BrandCamera
    {
        [LocalizedDescription(nameof(ResBrand.Fujifilm), typeof(ResBrand))]
        Fujifilm = 0,
        [LocalizedDescription(nameof(ResBrand.GoPro), typeof(ResBrand))]
        GoPro = 1,
        [LocalizedDescription(nameof(ResBrand.Kodak), typeof(ResBrand))]
        Kodak = 2,
        [LocalizedDescription(nameof(ResBrand.Nikon), typeof(ResBrand))]
        Nikon = 3,
        [LocalizedDescription(nameof(ResBrand.Polaroid), typeof(ResBrand))]
        Polaroid = 4,
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 5
    }

    public enum BrandFurniture
    {
        [LocalizedDescription(nameof(ResBrand.EthanAllen), typeof(ResBrand))]
        EthanAllen = 0,
        [LocalizedDescription(nameof(ResBrand.ZGallerie), typeof(ResBrand))]
        ZGallerie = 1
    }

    public enum BrandLawnMowers
    {
        [LocalizedDescription(nameof(ResBrand.Craftsman), typeof(ResBrand))] Craftsman = 0,
        [LocalizedDescription(nameof(ResBrand.Honda), typeof(ResBrand))] Honda = 1,
        [LocalizedDescription(nameof(ResBrand.JohnDeere), typeof(ResBrand))] JohnDeere = 2,
        [LocalizedDescription(nameof(ResBrand.Snapper), typeof(ResBrand))] Snapper = 3,
        [LocalizedDescription(nameof(ResBrand.Toro), typeof(ResBrand))] Toro = 4
    }

    public enum BrandPetSupply
    {
        [LocalizedDescription(nameof(ResBrand.Chaco), typeof(ResBrand))]
        Chaco = 0
    }

    public enum BrandCellPhoneAccesories
    {
        [LocalizedDescription(nameof(ResBrand.MichaelKors), typeof(ResBrand))]
        MichaelKors = 0
    }

    public enum BrandCellPhone
    {
        [LocalizedDescription(nameof(ResBrand.Apple), typeof(ResBrand))]
        Apple = 0,
        [LocalizedDescription(nameof(ResBrand.Google), typeof(ResBrand))]
        Google = 1,
        [LocalizedDescription(nameof(ResBrand.HTC), typeof(ResBrand))]
        HTC = 2,
        [LocalizedDescription(nameof(ResBrand.Huawei), typeof(ResBrand))]
        Huawei = 3,
        [LocalizedDescription(nameof(ResBrand.LG), typeof(ResBrand))]
        LG = 4,
        [LocalizedDescription(nameof(ResBrand.Motorola), typeof(ResBrand))]
        Motorola = 5,
        [LocalizedDescription(nameof(ResBrand.OPPO), typeof(ResBrand))]
        OPPO = 6,
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 7,
        [LocalizedDescription(nameof(ResBrand.Xiaomi), typeof(ResBrand))]
        Xiaomi = 8
    }

    public enum BrandHomeAudioAndVideoSystems
    {
        [LocalizedDescription(nameof(ResBrand.Apple), typeof(ResBrand))]
        Apple = 0,
        [LocalizedDescription(nameof(ResBrand.BeatsByDrDre), typeof(ResBrand))]
        BeatsByDrDre = 1,
        [LocalizedDescription(nameof(ResBrand.Bose), typeof(ResBrand))]
        Bose = 2,
        [LocalizedDescription(nameof(ResBrand.JBLByHarman), typeof(ResBrand))]
        JBLByHarman = 3,
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 4,
        [LocalizedDescription(nameof(ResBrand.SamsungGalaxy), typeof(ResBrand))]
        SamsungGalaxy = 5,
        [LocalizedDescription(nameof(ResBrand.Sony), typeof(ResBrand))]
        Sony = 6
    }

    public enum BrandTVs
    {
        [LocalizedDescription(nameof(ResBrand.Element), typeof(ResBrand))]
        Element = 0,
        [LocalizedDescription(nameof(ResBrand.Haier), typeof(ResBrand))]
        Haier = 1,
        [LocalizedDescription(nameof(ResBrand.Hisense), typeof(ResBrand))]
        Hisense = 2,
        [LocalizedDescription(nameof(ResBrand.Hitachi), typeof(ResBrand))]
        Hitachi = 3,
        [LocalizedDescription(nameof(ResBrand.Insignia), typeof(ResBrand))]
        Insignia = 4,
        [LocalizedDescription(nameof(ResBrand.LG), typeof(ResBrand))]
        LG = 5,
        [LocalizedDescription(nameof(ResBrand.Panasonic), typeof(ResBrand))]
        Panasonic = 6,
        [LocalizedDescription(nameof(ResBrand.Philips), typeof(ResBrand))]
        Philips = 7,
        [LocalizedDescription(nameof(ResBrand.RCA), typeof(ResBrand))]
        RCA = 8,
        [LocalizedDescription(nameof(ResBrand.Roku), typeof(ResBrand))]
        Roku = 9,
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 10,
        [LocalizedDescription(nameof(ResBrand.Sharp), typeof(ResBrand))]
        Sharp = 11,
        [LocalizedDescription(nameof(ResBrand.Sony), typeof(ResBrand))]
        Sony = 12,
        [LocalizedDescription(nameof(ResBrand.TCL), typeof(ResBrand))]
        TCL = 13,
        [LocalizedDescription(nameof(ResBrand.Toshiba), typeof(ResBrand))]
        Toshiba = 14,
        [LocalizedDescription(nameof(ResBrand.VIZIO), typeof(ResBrand))]
        VIZIO = 15
    }
    
}
