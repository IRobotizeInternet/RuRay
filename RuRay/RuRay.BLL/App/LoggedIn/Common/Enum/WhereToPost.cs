using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Enum
{
    /// <summary>
    /// Defines the WhereToPost.
    /// </summary>
    public enum WhereToPost
    {
        /// <summary>
        /// Defines the PostOnTimeline.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.PostOnTimeline), typeof(ResLeftNav))] PostOnTimeline = 0,

        /// <summary>
        /// Defines the PostToPageYouManage.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.PostToPageYouManage), typeof(ResLeftNav))] PostToPageYouManage = 1,

        /// <summary>
        /// Defines the PostInGroup.
        /// </summary>
        [LocalizedDescription(nameof(ResLeftNav.PostInGroup), typeof(ResLeftNav))] PostInGroup = 2,
    }
}
