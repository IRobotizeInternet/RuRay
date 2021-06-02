using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the VehicleModel.
    /// </summary>
    public enum VehicleModel
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1
    }
}
