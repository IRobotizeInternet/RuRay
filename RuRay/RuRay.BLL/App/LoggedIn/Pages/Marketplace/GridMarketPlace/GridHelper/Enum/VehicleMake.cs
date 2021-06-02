using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleMake.
    /// </summary>
    public enum VehicleMake
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,

        /// <summary>
        /// Defines the Acura.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Acura), typeof(ResCategory))]
        Acura = 2,

        /// <summary>
        /// Defines the AlfaRomeo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AlfaRomeo), typeof(ResCategory))]
        AlfaRomeo = 3,

        /// <summary>
        /// Defines the AstonMartin.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.AstonMartin), typeof(ResCategory))]
        AstonMartin = 4,

        /// <summary>
        /// Defines the Audi.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Audi), typeof(ResCategory))]
        Audi = 5,

        /// <summary>
        /// Defines the Bently.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Bently), typeof(ResCategory))]
        Bently = 6,

        /// <summary>
        /// Defines the BMW.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.BMW), typeof(ResCategory))]
        BMW = 7,

        /// <summary>
        /// Defines the Buick.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Buick), typeof(ResCategory))]
        Buick = 8,

        /// <summary>
        /// Defines the Cadillac.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Cadillac), typeof(ResCategory))]
        Cadillac = 9,

        /// <summary>
        /// Defines the Chevrolet.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Chevrolet), typeof(ResCategory))]
        Chevrolet = 10,

        /// <summary>
        /// Defines the Chrysler.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Chrysler), typeof(ResCategory))]
        Chrysler = 11,

        /// <summary>
        /// Defines the CODA.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CODA), typeof(ResCategory))]
        CODA = 12,

        /// <summary>
        /// Defines the Daewoo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Daewoo), typeof(ResCategory))]
        Daewoo = 13,

        /// <summary>
        /// Defines the Daihatsu.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Daihatsu), typeof(ResCategory))]
        Daihatsu = 14,

        /// <summary>
        /// Defines the Doge.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Doge), typeof(ResCategory))]
        Doge = 15,

        /// <summary>
        /// Defines the Eagle.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Eagle), typeof(ResCategory))]
        Eagle = 16,

        /// <summary>
        /// Defines the Ferrari.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Ferrari), typeof(ResCategory))]
        Ferrari = 17,

        /// <summary>
        /// Defines the Fiat.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Fiat), typeof(ResCategory))]
        Fiat = 18,

        /// <summary>
        /// Defines the Fisker.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Fisker), typeof(ResCategory))]
        Fisker = 19,

        /// <summary>
        /// Defines the Ford.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Ford), typeof(ResCategory))]
        Ford = 20,

        /// <summary>
        /// Defines the Freightliner.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Freightliner), typeof(ResCategory))]
        Freightliner = 21,

        /// <summary>
        /// Defines the Genesis.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Genesis), typeof(ResCategory))]
        Genesis = 22,

        /// <summary>
        /// Defines the Geo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Geo), typeof(ResCategory))]
        Geo = 23,

        /// <summary>
        /// Defines the GMC.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.GMC), typeof(ResCategory))]
        GMC = 24,

        /// <summary>
        /// Defines the Honda.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Honda), typeof(ResCategory))]
        Honda = 25,

        /// <summary>
        /// Defines the Hummer.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Hummer), typeof(ResCategory))]
        Hummer = 26,

        /// <summary>
        /// Defines the Hyundai.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Hyundai), typeof(ResCategory))]
        Hyundai = 27,

        /// <summary>
        /// Defines the Infiniti.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Infiniti), typeof(ResCategory))]
        Infiniti = 28,

        /// <summary>
        /// Defines the Isuzu.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Isuzu), typeof(ResCategory))]
        Isuzu = 29,

        /// <summary>
        /// Defines the Jaguar.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Jaguar), typeof(ResCategory))]
        Jaguar = 30,

        /// <summary>
        /// Defines the Jeep.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Jeep), typeof(ResCategory))]
        Jeep = 31,

        /// <summary>
        /// Defines the Kia.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Kia), typeof(ResCategory))]
        Kia = 32,

        /// <summary>
        /// Defines the Lamborghini.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Lamborghini), typeof(ResCategory))]
        Lamborghini = 33,

        /// <summary>
        /// Defines the LandRover.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.LandRover), typeof(ResCategory))]
        LandRover = 34,

        /// <summary>
        /// Defines the Lexus.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Lexus), typeof(ResCategory))]
        Lexus = 35,

        /// <summary>
        /// Defines the Lincoln.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Lincoln), typeof(ResCategory))]
        Lincoln = 36,

        /// <summary>
        /// Defines the Lotus.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Lotus), typeof(ResCategory))]
        Lotus = 37,

        /// <summary>
        /// Defines the Maserati.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Maserati), typeof(ResCategory))]
        Maserati = 38,

        /// <summary>
        /// Defines the Maybach.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Maybach), typeof(ResCategory))]
        Maybach = 39,

        /// <summary>
        /// Defines the Mazda.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mazda), typeof(ResCategory))]
        Mazda = 40,

        /// <summary>
        /// Defines the Mclaren.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mclaren), typeof(ResCategory))]
        Mclaren = 41,

        /// <summary>
        /// Defines the MercedesBenz.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.MercedesBenz), typeof(ResCategory))]
        MercedesBenz = 42,

        /// <summary>
        /// Defines the Mercury.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mercury), typeof(ResCategory))]
        Mercury = 43,

        /// <summary>
        /// Defines the Mini.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mini), typeof(ResCategory))]
        Mini = 44,

        /// <summary>
        /// Defines the Mitsubishi.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Mitsubishi), typeof(ResCategory))]
        Mitsubishi = 45,

        /// <summary>
        /// Defines the Nissan.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Nissan), typeof(ResCategory))]
        Nissan = 46,

        /// <summary>
        /// Defines the Oldsmobile.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Oldsmobile), typeof(ResCategory))]
        Oldsmobile = 47,

        /// <summary>
        /// Defines the Panoz.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Panoz), typeof(ResCategory))]
        Panoz = 48,

        /// <summary>
        /// Defines the Plymouth.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Plymouth), typeof(ResCategory))]
        Plymouth = 49,

        /// <summary>
        /// Defines the Pontiac.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Pontiac), typeof(ResCategory))]
        Pontiac = 50,

        /// <summary>
        /// Defines the Porsche.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Porsche), typeof(ResCategory))]
        Porsche = 51,

        /// <summary>
        /// Defines the Ram.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Ram), typeof(ResCategory))]
        Ram = 52,

        /// <summary>
        /// Defines the Rivian.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Rivian), typeof(ResCategory))]
        Rivian = 53,

        /// <summary>
        /// Defines the RollsRoyce.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RollsRoyce), typeof(ResCategory))]
        RollsRoyce = 54,

        /// <summary>
        /// Defines the Saturn.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Saturn), typeof(ResCategory))]
        Saturn = 55,

        /// <summary>
        /// Defines the Scion.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Scion), typeof(ResCategory))]
        Scion = 56,

        /// <summary>
        /// Defines the Smart.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Smart), typeof(ResCategory))]
        Smart = 57,

        /// <summary>
        /// Defines the Srt.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Srt), typeof(ResCategory))]
        Srt = 58,

        /// <summary>
        /// Defines the Subaru.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Subaru), typeof(ResCategory))]
        Subaru = 59,

        /// <summary>
        /// Defines the Suzuki.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Suzuki), typeof(ResCategory))]
        Suzuki = 60,

        /// <summary>
        /// Defines the Tesla.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Tesla), typeof(ResCategory))]
        Tesla = 61,

        /// <summary>
        /// Defines the Toyota.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Toyota), typeof(ResCategory))]
        Toyota = 62,

        /// <summary>
        /// Defines the Volkswagen.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Volkswagen), typeof(ResCategory))]
        Volkswagen = 63,

        /// <summary>
        /// Defines the Volvo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Volvo), typeof(ResCategory))]
        Volvo = 64
    }
}
