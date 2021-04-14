using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum BabyAndToddlerSize
    {
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.Preemie), typeof(ResBabyAndToddlerSize))]
        Womens = 0,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.Newborn), typeof(ResBabyAndToddlerSize))]
        Mens = 1,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ZeroToThreeMonths), typeof(ResBabyAndToddlerSize))]
        KidsClothing = 2,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ThreeToSixMonths), typeof(ResBabyAndToddlerSize))]
        BabyClothing = 3,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.SixToNineMonths), typeof(ResBabyAndToddlerSize))]
        Shoes = 4,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.NineTo12Months), typeof(ResBabyAndToddlerSize))]
        JewelryAndAccessories = 5,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.TwelveTo18Months), typeof(ResBabyAndToddlerSize))]
        BagsAndLuggage = 6,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.EighteenTo24Months), typeof(ResBabyAndToddlerSize))]
        HalloweenAndKidsCostumes = 7,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.TwoT), typeof(ResBabyAndToddlerSize))]
        UniformsAndWorkClothing = 8,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.ThreeT), typeof(ResBabyAndToddlerSize))]
        ThreeT = 9,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.FourT), typeof(ResBabyAndToddlerSize))]
        FourT = 10,
        [LocalizedDescription(nameof(ResBabyAndToddlerSize.FiveT), typeof(ResBabyAndToddlerSize))]
        FiveT = 11,
    }
}
