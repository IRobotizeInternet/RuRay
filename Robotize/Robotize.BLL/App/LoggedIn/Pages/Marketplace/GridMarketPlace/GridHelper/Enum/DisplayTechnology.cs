using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum DisplayTechnology
    {
        [LocalizedDescription(nameof(ResDisplayTechnology.CRT), typeof(ResDisplayTechnology))]
        CRT = 0,
        [LocalizedDescription(nameof(ResDisplayTechnology.DLP), typeof(ResDisplayTechnology))]
        DLP = 1,
        [LocalizedDescription(nameof(ResDisplayTechnology.LCD), typeof(ResDisplayTechnology))]
        LCD = 2,
        [LocalizedDescription(nameof(ResDisplayTechnology.LED), typeof(ResDisplayTechnology))]
        LED = 3,
        [LocalizedDescription(nameof(ResDisplayTechnology.OLED), typeof(ResDisplayTechnology))]
        OLED = 4,
        [LocalizedDescription(nameof(ResDisplayTechnology.Plasma), typeof(ResDisplayTechnology))]
        Plasma = 5,
        [LocalizedDescription(nameof(ResDisplayTechnology.QLED), typeof(ResDisplayTechnology))]
        QLED = 6
    }
}
