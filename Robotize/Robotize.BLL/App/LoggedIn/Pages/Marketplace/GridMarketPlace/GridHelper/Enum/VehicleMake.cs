using RobotizeToolbox.CustomAttributes;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum VehicleMake
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))] 
        All = 1,
        [LocalizedDescription(nameof(ResCategory.Acura), typeof(ResCategory))] 
        Acura = 2,
        [LocalizedDescription(nameof(ResCategory.AlfaRomeo), typeof(ResCategory))] 
        AlfaRomeo = 3,
        [LocalizedDescription(nameof(ResCategory.AstonMartin), typeof(ResCategory))] 
        AstonMartin = 4,
        [LocalizedDescription(nameof(ResCategory.Audi), typeof(ResCategory))] 
        Audi = 5,
        [LocalizedDescription(nameof(ResCategory.Bently), typeof(ResCategory))] 
        Bently = 6,
        [LocalizedDescription(nameof(ResCategory.BMW), typeof(ResCategory))] 
        BMW = 7,
        [LocalizedDescription(nameof(ResCategory.Buick), typeof(ResCategory))] 
        Buick = 8,
        [LocalizedDescription(nameof(ResCategory.Cadillac), typeof(ResCategory))] 
        Cadillac = 9,
        [LocalizedDescription(nameof(ResCategory.Chevrolet), typeof(ResCategory))] 
        Chevrolet = 10,
        [LocalizedDescription(nameof(ResCategory.Chrysler), typeof(ResCategory))] 
        Chrysler = 11,
        [LocalizedDescription(nameof(ResCategory.CODA), typeof(ResCategory))] 
        CODA = 12,
        [LocalizedDescription(nameof(ResCategory.Daewoo), typeof(ResCategory))] 
        Daewoo = 13,
        [LocalizedDescription(nameof(ResCategory.Daihatsu), typeof(ResCategory))] 
        Daihatsu = 14,
        [LocalizedDescription(nameof(ResCategory.Doge), typeof(ResCategory))] 
        Doge = 15,
        [LocalizedDescription(nameof(ResCategory.Eagle), typeof(ResCategory))] 
        Eagle = 16,
        [LocalizedDescription(nameof(ResCategory.Ferrari), typeof(ResCategory))] 
        Ferrari = 17,
        [LocalizedDescription(nameof(ResCategory.Fiat), typeof(ResCategory))] 
        Fiat = 18,
        [LocalizedDescription(nameof(ResCategory.Fisker), typeof(ResCategory))] 
        Fisker = 19,
        [LocalizedDescription(nameof(ResCategory.Ford), typeof(ResCategory))] 
        Ford = 20,
        [LocalizedDescription(nameof(ResCategory.Freightliner), typeof(ResCategory))] 
        Freightliner = 21,
        [LocalizedDescription(nameof(ResCategory.Genesis), typeof(ResCategory))] 
        Genesis = 22,
        [LocalizedDescription(nameof(ResCategory.Geo), typeof(ResCategory))] 
        Geo = 23,
        [LocalizedDescription(nameof(ResCategory.GMC), typeof(ResCategory))] 
        GMC = 24,
        [LocalizedDescription(nameof(ResCategory.Honda), typeof(ResCategory))] 
        Honda = 25,
        [LocalizedDescription(nameof(ResCategory.Hummer), typeof(ResCategory))] 
        Hummer = 26,
        [LocalizedDescription(nameof(ResCategory.Hyundai), typeof(ResCategory))] 
        Hyundai = 27,
        [LocalizedDescription(nameof(ResCategory.Infiniti), typeof(ResCategory))] 
        Infiniti = 28,
        [LocalizedDescription(nameof(ResCategory.Isuzu), typeof(ResCategory))] 
        Isuzu = 29,
        [LocalizedDescription(nameof(ResCategory.Jaguar), typeof(ResCategory))] 
        Jaguar = 30,
        [LocalizedDescription(nameof(ResCategory.Jeep), typeof(ResCategory))] 
        Jeep = 31,
        [LocalizedDescription(nameof(ResCategory.Kia), typeof(ResCategory))] 
        Kia = 32,
        [LocalizedDescription(nameof(ResCategory.Lamborghini), typeof(ResCategory))] 
        Lamborghini = 33,
        [LocalizedDescription(nameof(ResCategory.LandRover), typeof(ResCategory))] 
        LandRover = 34,
        [LocalizedDescription(nameof(ResCategory.Lexus), typeof(ResCategory))] 
        Lexus = 35,
        [LocalizedDescription(nameof(ResCategory.Lincoln), typeof(ResCategory))] 
        Lincoln = 36,
        [LocalizedDescription(nameof(ResCategory.Lotus), typeof(ResCategory))] 
        Lotus = 37,
        [LocalizedDescription(nameof(ResCategory.Maserati), typeof(ResCategory))] 
        Maserati = 38,
        [LocalizedDescription(nameof(ResCategory.Maybach), typeof(ResCategory))] 
        Maybach = 39,
        [LocalizedDescription(nameof(ResCategory.Mazda), typeof(ResCategory))] 
        Mazda = 40,
        [LocalizedDescription(nameof(ResCategory.Mclaren), typeof(ResCategory))] 
        Mclaren = 41,
        [LocalizedDescription(nameof(ResCategory.MercedesBenz), typeof(ResCategory))] 
        MercedesBenz = 42,
        [LocalizedDescription(nameof(ResCategory.Mercury), typeof(ResCategory))] 
        Mercury = 43,
        [LocalizedDescription(nameof(ResCategory.Mini), typeof(ResCategory))] 
        Mini = 44,
        [LocalizedDescription(nameof(ResCategory.Mitsubishi), typeof(ResCategory))] 
        Mitsubishi = 45,
        [LocalizedDescription(nameof(ResCategory.Nissan), typeof(ResCategory))] 
        Nissan = 46,
        [LocalizedDescription(nameof(ResCategory.Oldsmobile), typeof(ResCategory))] 
        Oldsmobile = 47,
        [LocalizedDescription(nameof(ResCategory.Panoz), typeof(ResCategory))] 
        Panoz = 48,
        [LocalizedDescription(nameof(ResCategory.Plymouth), typeof(ResCategory))] 
        Plymouth = 49,
        [LocalizedDescription(nameof(ResCategory.Pontiac), typeof(ResCategory))] 
        Pontiac = 50,
        [LocalizedDescription(nameof(ResCategory.Porsche), typeof(ResCategory))] 
        Porsche = 51,
        [LocalizedDescription(nameof(ResCategory.Ram), typeof(ResCategory))] 
        Ram = 52,
        [LocalizedDescription(nameof(ResCategory.Rivian), typeof(ResCategory))] 
        Rivian = 53,
        [LocalizedDescription(nameof(ResCategory.RollsRoyce), typeof(ResCategory))] 
        RollsRoyce = 54,
        [LocalizedDescription(nameof(ResCategory.Saturn), typeof(ResCategory))] 
        Saturn = 55,
        [LocalizedDescription(nameof(ResCategory.Scion), typeof(ResCategory))] 
        Scion = 56,
        [LocalizedDescription(nameof(ResCategory.Smart), typeof(ResCategory))] 
        Smart = 57,
        [LocalizedDescription(nameof(ResCategory.Srt), typeof(ResCategory))] 
        Srt = 58,
        [LocalizedDescription(nameof(ResCategory.Subaru), typeof(ResCategory))] 
        Subaru = 59,
        [LocalizedDescription(nameof(ResCategory.Suzuki), typeof(ResCategory))] 
        Suzuki = 60,
        [LocalizedDescription(nameof(ResCategory.Tesla), typeof(ResCategory))] 
        Tesla = 61,
        [LocalizedDescription(nameof(ResCategory.Toyota), typeof(ResCategory))] 
        Toyota = 62,
        [LocalizedDescription(nameof(ResCategory.Volkswagen), typeof(ResCategory))] 
        Volkswagen = 63,
        [LocalizedDescription(nameof(ResCategory.Volvo), typeof(ResCategory))] 
        Volvo = 64
    }
}
