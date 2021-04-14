using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum Network
    {
        [LocalizedDescription(nameof(ResNetwork.ATAndT), typeof(ResNetwork))]
        ATAndT = 0,
        [LocalizedDescription(nameof(ResNetwork.BoostMobile), typeof(ResNetwork))]
        BoostMobile = 1,
        [LocalizedDescription(nameof(ResNetwork.CricketWireless), typeof(ResNetwork))]
        CricketWireless = 2,
        [LocalizedDescription(nameof(ResNetwork.MetroByTMobile), typeof(ResNetwork))]
        MetroByTMobile = 3,
        [LocalizedDescription(nameof(ResNetwork.Sprint), typeof(ResNetwork))]
        Sprint = 4,
        [LocalizedDescription(nameof(ResNetwork.StraightTalk), typeof(ResNetwork))]
        StraightTalk = 5,
        [LocalizedDescription(nameof(ResNetwork.TMobile), typeof(ResNetwork))]
        TMobile = 6,
        [LocalizedDescription(nameof(ResNetwork.Unlocked), typeof(ResNetwork))]
        Unlocked = 7,
        [LocalizedDescription(nameof(ResNetwork.Verizon), typeof(ResNetwork))]
        Verizon = 8
    }
}
