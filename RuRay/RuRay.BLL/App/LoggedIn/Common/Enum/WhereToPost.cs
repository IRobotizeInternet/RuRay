using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Enum
{
    public enum WhereToPost
    {
        [LocalizedDescription(nameof(ResLeftNav.PostOnTimeline), typeof(ResLeftNav))] PostOnTimeline = 0,
        [LocalizedDescription(nameof(ResLeftNav.PostToPageYouManage), typeof(ResLeftNav))] PostToPageYouManage = 1,
        [LocalizedDescription(nameof(ResLeftNav.PostInGroup), typeof(ResLeftNav))] PostInGroup = 2,
    }
}
