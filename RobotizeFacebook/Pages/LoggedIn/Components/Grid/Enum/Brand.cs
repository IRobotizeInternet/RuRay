using RobotizeFacebook.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public enum BrandBagsAndLuggage
    {
        [LocalizedDescription(nameof(ResBrand.Loungefly), typeof(ResBrand))]
        Loungefly = 0,
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

    public enum BrandKidsClothing
    {
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,
        [LocalizedDescription(nameof(ResBrand.MatildaJane), typeof(ResBrand))]
        MatildaJane = 1
    }

    public enum BrandShoes
    {
        [LocalizedDescription(nameof(ResBrand.Adidas), typeof(ResBrand))]
        Adidas = 0,
        [LocalizedDescription(nameof(ResBrand.Gucci), typeof(ResBrand))]
        Gucci = 1,
        [LocalizedDescription(nameof(ResBrand.Nike), typeof(ResBrand))]
        Nike = 2
    }
}
