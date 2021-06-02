using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the DisplayTechnology.
    /// </summary>
    public enum DisplayTechnology
    {
        /// <summary>
        /// Defines the CRT.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.CRT), typeof(ResDisplayTechnology))]
        CRT = 0,

        /// <summary>
        /// Defines the DLP.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.DLP), typeof(ResDisplayTechnology))]
        DLP = 1,

        /// <summary>
        /// Defines the LCD.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.LCD), typeof(ResDisplayTechnology))]
        LCD = 2,

        /// <summary>
        /// Defines the LED.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.LED), typeof(ResDisplayTechnology))]
        LED = 3,

        /// <summary>
        /// Defines the OLED.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.OLED), typeof(ResDisplayTechnology))]
        OLED = 4,

        /// <summary>
        /// Defines the Plasma.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.Plasma), typeof(ResDisplayTechnology))]
        Plasma = 5,

        /// <summary>
        /// Defines the QLED.
        /// </summary>
        [LocalizedDescription(nameof(ResDisplayTechnology.QLED), typeof(ResDisplayTechnology))]
        QLED = 6
    }
}
