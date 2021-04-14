using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum BedroomCount
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,
        [LocalizedDescription(nameof(ResCategory._1), typeof(ResCategory))]
        one = 1,
        [LocalizedDescription(nameof(ResCategory._2), typeof(ResCategory))]
        two = 2,
        [LocalizedDescription(nameof(ResCategory._3), typeof(ResCategory))]
        three = 3,
        [LocalizedDescription(nameof(ResCategory._4), typeof(ResCategory))]
        four = 4,
        [LocalizedDescription(nameof(ResCategory._5), typeof(ResCategory))]
        five = 5,
        [LocalizedDescription(nameof(ResCategory._6), typeof(ResCategory))]
        six = 6,
    }
}
