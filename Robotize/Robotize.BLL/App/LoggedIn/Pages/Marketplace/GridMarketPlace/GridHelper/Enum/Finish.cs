using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum Finish
    {
        [LocalizedDescription(nameof(ResFinish.Distressed), typeof(ResFinish))] Distressed = 0,
        [LocalizedDescription(nameof(ResFinish.Mirrored), typeof(ResFinish))] Mirrored = 1,
        [LocalizedDescription(nameof(ResFinish.Painted), typeof(ResFinish))] Painted = 2,
        [LocalizedDescription(nameof(ResFinish.Stained), typeof(ResFinish))] Stained = 3,
    }
}
