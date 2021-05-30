using RuRayToolbox.CustomAttributes;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn
{
    public enum VehicleModel
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1
    }
}
