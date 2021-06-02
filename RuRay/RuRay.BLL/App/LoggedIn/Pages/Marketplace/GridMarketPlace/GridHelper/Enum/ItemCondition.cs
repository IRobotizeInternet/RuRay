using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the ItemCondition.
    /// </summary>
    public enum ItemCondition
    {
        /// <summary>
        /// Defines the All.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,

        /// <summary>
        /// Defines the New.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.New), typeof(ResCategory))]
        New = 2,

        /// <summary>
        /// Defines the Used.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Used), typeof(ResCategory))]
        Used = 3
    }
}
