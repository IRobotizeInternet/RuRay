using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum Feature
    {
        [LocalizedDescription(nameof(ResFeature.FourK), typeof(ResFeature))]
        FourK = 0,
        [LocalizedDescription(nameof(ResFeature.EightK), typeof(ResFeature))]
        EightK = 1,
        [LocalizedDescription(nameof(ResFeature.FullHD), typeof(ResFeature))]
        FullHD = 2,
        [LocalizedDescription(nameof(ResFeature.SmartTVs), typeof(ResFeature))]
        SmartTVs = 3,
    }
}
