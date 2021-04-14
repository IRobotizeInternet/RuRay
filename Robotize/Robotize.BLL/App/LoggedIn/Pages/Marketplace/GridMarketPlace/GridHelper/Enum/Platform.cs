using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum Platform
    {
        [LocalizedDescription(nameof(ResPlatform.Nintendo2DS), typeof(ResPlatform))]
        Nintendo2DS = 0,
        [LocalizedDescription(nameof(ResPlatform.Nintendo3DS), typeof(ResPlatform))]
        Nintendo3DS = 1,
        [LocalizedDescription(nameof(ResPlatform.NintendoDS), typeof(ResPlatform))]
        NintendoDS = 2,
        [LocalizedDescription(nameof(ResPlatform.NintendoGameBoy), typeof(ResPlatform))]
        NintendoGameBoy = 3,
        [LocalizedDescription(nameof(ResPlatform.NintendoSwitch), typeof(ResPlatform))]
        NintendoSwitch = 4,
        [LocalizedDescription(nameof(ResPlatform.NintendoWii), typeof(ResPlatform))]
        NintendoWii = 5,
        [LocalizedDescription(nameof(ResPlatform.PlayStation2), typeof(ResPlatform))]
        PlayStation2 = 6,
        [LocalizedDescription(nameof(ResPlatform.PlayStation4), typeof(ResPlatform))]
        PlayStation4 = 7,
        [LocalizedDescription(nameof(ResPlatform.Playstation3), typeof(ResPlatform))]
        Playstation3 = 8,
        [LocalizedDescription(nameof(ResPlatform.Xbox360), typeof(ResPlatform))]
        Xbox360 = 9,
        [LocalizedDescription(nameof(ResPlatform.XboxOne), typeof(ResPlatform))]
        XboxOne = 10
    }
}
