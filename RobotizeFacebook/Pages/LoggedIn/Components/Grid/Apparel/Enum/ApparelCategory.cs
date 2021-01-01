using RobotizeFacebook.Resources;
using RobotizeToolbox.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Components.Grid.Apparel.Enum
{
    public enum ApparelCategory
    {
        [LocalizedDescription(nameof(ResCategory.Womens), typeof(ResCategory))]
        Womens = 0,
        [LocalizedDescription(nameof(ResCategory.Mens), typeof(ResCategory))]
        Mens = 1,
        [LocalizedDescription(nameof(ResCategory.KidsClothing), typeof(ResCategory))]
        KidsClothing = 2,
        [LocalizedDescription(nameof(ResCategory.BabyClothing), typeof(ResCategory))]
        BabyClothing = 3,
        [LocalizedDescription(nameof(ResCategory.Shoes), typeof(ResCategory))]
        Shoes = 4,
        [LocalizedDescription(nameof(ResCategory.JewelryAndAccessories), typeof(ResCategory))]
        JewelryAndAccessories = 5,
        [LocalizedDescription(nameof(ResCategory.BagsAndLuggage), typeof(ResCategory))]
        BagsAndLuggage = 6,
        [LocalizedDescription(nameof(ResCategory.HalloweenAndKidsCostumes), typeof(ResCategory))]
        HalloweenAndKidsCostumes = 7,
        [LocalizedDescription(nameof(ResCategory.UniformsAndWorkClothing), typeof(ResCategory))]
        UniformsAndWorkClothing = 8
    }
    
    public enum BagsAndLuggageCategory
    {
        [LocalizedDescription(nameof(ResCategory.Womens), typeof(ResCategory))]
        Womens = 0,
        [LocalizedDescription(nameof(ResCategory.Mens), typeof(ResCategory))]
        Mens = 1,
        [LocalizedDescription(nameof(ResCategory.KidsClothing), typeof(ResCategory))]
        KidsClothing = 2,
        [LocalizedDescription(nameof(ResCategory.BabyClothing), typeof(ResCategory))]
        BabyClothing = 3,
        [LocalizedDescription(nameof(ResCategory.Shoes), typeof(ResCategory))]
        Shoes = 4,
        [LocalizedDescription(nameof(ResCategory.JewelryAndAccessories), typeof(ResCategory))]
        JewelryAndAccessories = 5,
        [LocalizedDescription(nameof(ResCategory.BagsAndLuggage), typeof(ResCategory))]
        BagsAndLuggage = 6,
        [LocalizedDescription(nameof(ResCategory.HalloweenAndKidsCostumes), typeof(ResCategory))]
        HalloweenAndKidsCostumes = 7,
        [LocalizedDescription(nameof(ResCategory.UniformsAndWorkClothing), typeof(ResCategory))]
        UniformsAndWorkClothing = 8
    }
}
