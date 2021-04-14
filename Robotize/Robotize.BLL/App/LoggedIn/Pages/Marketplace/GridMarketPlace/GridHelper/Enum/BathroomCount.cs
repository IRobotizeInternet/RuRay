using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;
namespace RobotizeFacebook.App.LoggedIn
{
    public enum BathroomCount
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 0,
        [LocalizedDescription(nameof(ResCategory._1), typeof(ResCategory))]
        One = 1,
        [LocalizedDescription(nameof(ResCategory._1_5), typeof(ResCategory))]
        OneAndHalf = 15,
        [LocalizedDescription(nameof(ResCategory._2), typeof(ResCategory))]
        Two = 2,
        [LocalizedDescription(nameof(ResCategory._3), typeof(ResCategory))]
        Three = 3,
        [LocalizedDescription(nameof(ResCategory._4), typeof(ResCategory))]
        Four = 4,
        [LocalizedDescription(nameof(ResCategory._5), typeof(ResCategory))]
        Five = 5,
        [LocalizedDescription(nameof(ResCategory._6), typeof(ResCategory))]
        Six = 6,
    }
}
