using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleTransmissionType.
    /// </summary>
    public enum VehicleTransmissionType
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,

        /// <summary>
        /// Defines the Automatic.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Automatic), typeof(ResCategory))]
        Automatic = 2,

        /// <summary>
        /// Defines the Manual.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Manual), typeof(ResCategory))]
        Manual = 3
    }
}
