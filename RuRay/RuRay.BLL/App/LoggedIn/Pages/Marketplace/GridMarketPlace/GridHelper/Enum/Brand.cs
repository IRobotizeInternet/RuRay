using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the BrandBagsAndLuggage.
    /// </summary>
    public enum BrandBagsAndLuggage
    {
        /// <summary>
        /// Defines the Loungefly.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Loungefly), typeof(ResBrand))]
        Loungefly = 0,
    }

    /// <summary>
    /// Defines the BrandRemoteControlToys.
    /// </summary>
    public enum BrandRemoteControlToys
    {
        /// <summary>
        /// Defines the Axial.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.DavidYurman), typeof(ResBrand))]
        Axial = 0,

        /// <summary>
        /// Defines the Traxxas.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Traxxas = 1,
    }

    /// <summary>
    /// Defines the BrandJewelryAndAccessories.
    /// </summary>
    public enum BrandJewelryAndAccessories
    {
        /// <summary>
        /// Defines the DavidYurman.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.DavidYurman), typeof(ResBrand))]
        DavidYurman = 0,

        /// <summary>
        /// Defines the Gucci.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Gucci = 1,

        /// <summary>
        /// Defines the KendraScott.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.KendraScott), typeof(ResBrand))]
        KendraScott = 2,

        /// <summary>
        /// Defines the Pandora.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Pandora), typeof(ResBrand))]
        Pandora = 3,

        /// <summary>
        /// Defines the Swarovski.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Swarovski), typeof(ResBrand))]
        Swarovski = 4,

        /// <summary>
        /// Defines the Versace.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Versace), typeof(ResBrand))]
        Versace = 5
    }

    /// <summary>
    /// Defines the BrandPowerTools.
    /// </summary>
    public enum BrandPowerTools
    {
        /// <summary>
        /// Defines the Bosch.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Bosch), typeof(ResBrand))] Bosch = 0,

        /// <summary>
        /// Defines the DEWALT.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.DEWALT), typeof(ResBrand))] DEWALT = 1,

        /// <summary>
        /// Defines the Lincoln.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Lincoln), typeof(ResBrand))] Lincoln = 2,

        /// <summary>
        /// Defines the Makita.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Makita), typeof(ResBrand))] Makita = 3,

        /// <summary>
        /// Defines the Miller.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Miller), typeof(ResBrand))] Miller = 4,

        /// <summary>
        /// Defines the Milwaukee.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Milwaukee), typeof(ResBrand))] Milwaukee = 5,

        /// <summary>
        /// Defines the PORTERCABLE.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.PORTERCABLE), typeof(ResBrand))] PORTERCABLE = 6,
    }

    /// <summary>
    /// Defines the BrandHomeGoodTools.
    /// </summary>
    public enum BrandHomeGoodTools
    {
        /// <summary>
        /// Defines the Bosch.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Bosch), typeof(ResBrand))] Bosch = 0,

        /// <summary>
        /// Defines the Lincoln.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Lincoln), typeof(ResBrand))] Lincoln = 1,

        /// <summary>
        /// Defines the Makita.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Makita), typeof(ResBrand))] Makita = 2,

        /// <summary>
        /// Defines the Miller.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Miller), typeof(ResBrand))] Miller = 3
    }

    /// <summary>
    /// Defines the BrandKidsClothing.
    /// </summary>
    public enum BrandKidsClothing
    {
        /// <summary>
        /// Defines the Adidas.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,

        /// <summary>
        /// Defines the MatildaJane.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.MatildaJane), typeof(ResBrand))]
        MatildaJane = 1
    }

    /// <summary>
    /// Defines the BrandOutdoorCooking.
    /// </summary>
    public enum BrandOutdoorCooking
    {
        /// <summary>
        /// Defines the Weber.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Weber), typeof(ResBrand))]
        Weber = 0
    }

    /// <summary>
    /// Defines the BrandShoe.
    /// </summary>
    public enum BrandShoe
    {
        /// <summary>
        /// Defines the Adidas.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,

        /// <summary>
        /// Defines the Gucci.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Gucci = 1,

        /// <summary>
        /// Defines the Nike.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Nike), typeof(ResBrand))]
        Nike = 2
    }

    /// <summary>
    /// Defines the BrandCamera.
    /// </summary>
    public enum BrandCamera
    {
        /// <summary>
        /// Defines the Fujifilm.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Fujifilm), typeof(ResBrand))]
        Fujifilm = 0,

        /// <summary>
        /// Defines the GoPro.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.GoPro), typeof(ResBrand))]
        GoPro = 1,

        /// <summary>
        /// Defines the Kodak.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Kodak), typeof(ResBrand))]
        Kodak = 2,

        /// <summary>
        /// Defines the Nikon.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Nikon), typeof(ResBrand))]
        Nikon = 3,

        /// <summary>
        /// Defines the Polaroid.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Polaroid), typeof(ResBrand))]
        Polaroid = 4,

        /// <summary>
        /// Defines the Samsung.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 5
    }

    /// <summary>
    /// Defines the BrandFurniture.
    /// </summary>
    public enum BrandFurniture
    {
        /// <summary>
        /// Defines the EthanAllen.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.EthanAllen), typeof(ResBrand))]
        EthanAllen = 0,

        /// <summary>
        /// Defines the ZGallerie.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.ZGallerie), typeof(ResBrand))]
        ZGallerie = 1
    }

    /// <summary>
    /// Defines the BrandLawnMowers.
    /// </summary>
    public enum BrandLawnMowers
    {
        /// <summary>
        /// Defines the Craftsman.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Craftsman), typeof(ResBrand))] Craftsman = 0,

        /// <summary>
        /// Defines the Honda.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Honda), typeof(ResBrand))] Honda = 1,

        /// <summary>
        /// Defines the JohnDeere.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.JohnDeere), typeof(ResBrand))] JohnDeere = 2,

        /// <summary>
        /// Defines the Snapper.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Snapper), typeof(ResBrand))] Snapper = 3,

        /// <summary>
        /// Defines the Toro.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Toro), typeof(ResBrand))] Toro = 4
    }

    /// <summary>
    /// Defines the BrandPetSupply.
    /// </summary>
    public enum BrandPetSupply
    {
        /// <summary>
        /// Defines the Chaco.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Chaco), typeof(ResBrand))]
        Chaco = 0
    }

    /// <summary>
    /// Defines the BrandCellPhoneAccesories.
    /// </summary>
    public enum BrandCellPhoneAccesories
    {
        /// <summary>
        /// Defines the MichaelKors.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.MichaelKors), typeof(ResBrand))]
        MichaelKors = 0
    }

    /// <summary>
    /// Defines the BrandCellPhone.
    /// </summary>
    public enum BrandCellPhone
    {
        /// <summary>
        /// Defines the Apple.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Apple), typeof(ResBrand))]
        Apple = 0,

        /// <summary>
        /// Defines the Google.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Google), typeof(ResBrand))]
        Google = 1,

        /// <summary>
        /// Defines the HTC.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.HTC), typeof(ResBrand))]
        HTC = 2,

        /// <summary>
        /// Defines the Huawei.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Huawei), typeof(ResBrand))]
        Huawei = 3,

        /// <summary>
        /// Defines the LG.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.LG), typeof(ResBrand))]
        LG = 4,

        /// <summary>
        /// Defines the Motorola.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Motorola), typeof(ResBrand))]
        Motorola = 5,

        /// <summary>
        /// Defines the OPPO.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.OPPO), typeof(ResBrand))]
        OPPO = 6,

        /// <summary>
        /// Defines the Samsung.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 7,

        /// <summary>
        /// Defines the Xiaomi.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Xiaomi), typeof(ResBrand))]
        Xiaomi = 8
    }

    /// <summary>
    /// Defines the BrandHomeAudioAndVideoSystems.
    /// </summary>
    public enum BrandHomeAudioAndVideoSystems
    {
        /// <summary>
        /// Defines the Apple.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Apple), typeof(ResBrand))]
        Apple = 0,

        /// <summary>
        /// Defines the BeatsByDrDre.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.BeatsByDrDre), typeof(ResBrand))]
        BeatsByDrDre = 1,

        /// <summary>
        /// Defines the Bose.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Bose), typeof(ResBrand))]
        Bose = 2,

        /// <summary>
        /// Defines the JBLByHarman.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.JBLByHarman), typeof(ResBrand))]
        JBLByHarman = 3,

        /// <summary>
        /// Defines the Samsung.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 4,

        /// <summary>
        /// Defines the SamsungGalaxy.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.SamsungGalaxy), typeof(ResBrand))]
        SamsungGalaxy = 5,

        /// <summary>
        /// Defines the Sony.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Sony), typeof(ResBrand))]
        Sony = 6
    }

    /// <summary>
    /// Defines the BrandTVs.
    /// </summary>
    public enum BrandTVs
    {
        /// <summary>
        /// Defines the Element.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Element), typeof(ResBrand))]
        Element = 0,

        /// <summary>
        /// Defines the Haier.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Haier), typeof(ResBrand))]
        Haier = 1,

        /// <summary>
        /// Defines the Hisense.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Hisense), typeof(ResBrand))]
        Hisense = 2,

        /// <summary>
        /// Defines the Hitachi.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Hitachi), typeof(ResBrand))]
        Hitachi = 3,

        /// <summary>
        /// Defines the Insignia.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Insignia), typeof(ResBrand))]
        Insignia = 4,

        /// <summary>
        /// Defines the LG.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.LG), typeof(ResBrand))]
        LG = 5,

        /// <summary>
        /// Defines the Panasonic.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Panasonic), typeof(ResBrand))]
        Panasonic = 6,

        /// <summary>
        /// Defines the Philips.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Philips), typeof(ResBrand))]
        Philips = 7,

        /// <summary>
        /// Defines the RCA.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.RCA), typeof(ResBrand))]
        RCA = 8,

        /// <summary>
        /// Defines the Roku.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Roku), typeof(ResBrand))]
        Roku = 9,

        /// <summary>
        /// Defines the Samsung.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Samsung), typeof(ResBrand))]
        Samsung = 10,

        /// <summary>
        /// Defines the Sharp.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Sharp), typeof(ResBrand))]
        Sharp = 11,

        /// <summary>
        /// Defines the Sony.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Sony), typeof(ResBrand))]
        Sony = 12,

        /// <summary>
        /// Defines the TCL.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.TCL), typeof(ResBrand))]
        TCL = 13,

        /// <summary>
        /// Defines the Toshiba.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.Toshiba), typeof(ResBrand))]
        Toshiba = 14,

        /// <summary>
        /// Defines the VIZIO.
        /// </summary>
        [LocalizedDescription(nameof(ResBrand.VIZIO), typeof(ResBrand))]
        VIZIO = 15
    }
}
