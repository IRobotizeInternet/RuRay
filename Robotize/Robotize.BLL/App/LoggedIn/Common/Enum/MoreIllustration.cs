using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn.Enum
{
    public enum MoreIllustration
    {
        [LocalizedDescription(nameof(ResLeftNav.Holiday), typeof(ResLeftNav))] Holiday = 0,
        [LocalizedDescription(nameof(ResLeftNav.Recreation), typeof(ResLeftNav))] Recreation = 1,
        [LocalizedDescription(nameof(ResLeftNav.Seasons), typeof(ResLeftNav))] Seasons = 2,
        [LocalizedDescription(nameof(ResLeftNav.Travel), typeof(ResLeftNav))] Travel = 3,
    }
}
