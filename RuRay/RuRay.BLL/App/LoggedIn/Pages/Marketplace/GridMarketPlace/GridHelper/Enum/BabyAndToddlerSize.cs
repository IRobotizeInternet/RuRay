using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the BabyAndToddlerSize.
    /// </summary>
    public enum BabyAndToddlerSize
    {
        /// <summary>
        /// Defines the Womens.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.Preemie), typeof(ResBabyAndToddlerSize))]
        Womens = 0,

        /// <summary>
        /// Defines the Mens.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.Newborn), typeof(ResBabyAndToddlerSize))]
        Mens = 1,

        /// <summary>
        /// Defines the KidsClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ZeroToThreeMonths), typeof(ResBabyAndToddlerSize))]
        KidsClothing = 2,

        /// <summary>
        /// Defines the BabyClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ThreeToSixMonths), typeof(ResBabyAndToddlerSize))]
        BabyClothing = 3,

        /// <summary>
        /// Defines the Shoes.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.SixToNineMonths), typeof(ResBabyAndToddlerSize))]
        Shoes = 4,

        /// <summary>
        /// Defines the JewelryAndAccessories.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.NineTo12Months), typeof(ResBabyAndToddlerSize))]
        JewelryAndAccessories = 5,

        /// <summary>
        /// Defines the BagsAndLuggage.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.TwelveTo18Months), typeof(ResBabyAndToddlerSize))]
        BagsAndLuggage = 6,

        /// <summary>
        /// Defines the HalloweenAndKidsCostumes.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.EighteenTo24Months), typeof(ResBabyAndToddlerSize))]
        HalloweenAndKidsCostumes = 7,

        /// <summary>
        /// Defines the UniformsAndWorkClothing.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.TwoT), typeof(ResBabyAndToddlerSize))]
        UniformsAndWorkClothing = 8,

        /// <summary>
        /// Defines the ThreeT.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ThreeT), typeof(ResBabyAndToddlerSize))]
        ThreeT = 9,

        /// <summary>
        /// Defines the FourT.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.FourT), typeof(ResBabyAndToddlerSize))]
        FourT = 10,

        /// <summary>
        /// Defines the FiveT.
        /// </summary>
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.FiveT), typeof(ResBabyAndToddlerSize))]
        FiveT = 11,
    }
}
