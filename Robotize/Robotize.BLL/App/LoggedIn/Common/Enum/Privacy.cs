using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn.Enum
{
    public enum Privacy
    {
        [LocalizedDescription(nameof(ResMiscellaneous.Private), typeof(ResMiscellaneous))] Private = 0,
        [LocalizedDescription(nameof(ResMiscellaneous.Public), typeof(ResMiscellaneous))] Public = 1,
        [LocalizedDescription(nameof(ResMiscellaneous.Friends), typeof(ResMiscellaneous))] Friends = 2,
        [LocalizedDescription(nameof(ResMiscellaneous.Group), typeof(ResMiscellaneous))] Group = 3,

    }
}
