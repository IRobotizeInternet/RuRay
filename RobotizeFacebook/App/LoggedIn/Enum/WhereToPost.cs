using RobotizeFacebook.Resources;
using RobotizeToolbox.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.App.LoggedIn.Enum
{
    public enum WhereToPost
    {
        [LocalizedDescription(nameof(ResLeftNav.PostOnTimeline), typeof(ResLeftNav))] PostOnTimeline = 0,
        [LocalizedDescription(nameof(ResLeftNav.PostToPageYouManage), typeof(ResLeftNav))] PostToPageYouManage = 1,
        [LocalizedDescription(nameof(ResLeftNav.PostInGroup), typeof(ResLeftNav))] PostInGroup = 2,

    }
}
