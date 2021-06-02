using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the Network.
    /// </summary>
    public enum Network
    {
        /// <summary>
        /// Defines the ATAndT.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.ATAndT), typeof(ResNetwork))]
        ATAndT = 0,

        /// <summary>
        /// Defines the BoostMobile.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.BoostMobile), typeof(ResNetwork))]
        BoostMobile = 1,

        /// <summary>
        /// Defines the CricketWireless.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.CricketWireless), typeof(ResNetwork))]
        CricketWireless = 2,

        /// <summary>
        /// Defines the MetroByTMobile.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.MetroByTMobile), typeof(ResNetwork))]
        MetroByTMobile = 3,

        /// <summary>
        /// Defines the Sprint.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.Sprint), typeof(ResNetwork))]
        Sprint = 4,

        /// <summary>
        /// Defines the StraightTalk.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.StraightTalk), typeof(ResNetwork))]
        StraightTalk = 5,

        /// <summary>
        /// Defines the TMobile.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.TMobile), typeof(ResNetwork))]
        TMobile = 6,

        /// <summary>
        /// Defines the Unlocked.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.Unlocked), typeof(ResNetwork))]
        Unlocked = 7,

        /// <summary>
        /// Defines the Verizon.
        /// </summary>
        [LocalizedDescription(nameof(ResNetwork.Verizon), typeof(ResNetwork))]
        Verizon = 8
    }
}
