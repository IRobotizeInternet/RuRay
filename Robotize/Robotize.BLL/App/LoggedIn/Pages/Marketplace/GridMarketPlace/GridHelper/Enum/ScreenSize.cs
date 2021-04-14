using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum ScreenSize
    {
        [LocalizedDescription(nameof(ResScreenSize.ThirtyTwoInAndUnder), typeof(ResScreenSize))]
        ThirtyTwoInAndUnder = 0,
        [LocalizedDescription(nameof(ResScreenSize.ThirtyIn43In), typeof(ResScreenSize))]
        ThirtyIn43In = 1,
        [LocalizedDescription(nameof(ResScreenSize.FortyFourIn49In), typeof(ResScreenSize))]
        FortyFourIn49In = 2,
        [LocalizedDescription(nameof(ResScreenSize.FiftyIn59In), typeof(ResScreenSize))]
        FiftyIn59In = 3,
        [LocalizedDescription(nameof(ResScreenSize.SixtyIn69In), typeof(ResScreenSize))]
        SixtyIn69In = 4,
        [LocalizedDescription(nameof(ResScreenSize.SeventyInAndUp), typeof(ResScreenSize))]
        SeventyInAndUp = 5
    }
}
