﻿using RobotizeToolbox.CustomAttributes;
using RobotizeFacebook.Resources;
namespace RobotizeFacebook.App.LoggedIn
{
    public enum ItemCondition
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,
        [LocalizedDescription(nameof(ResCategory.New), typeof(ResCategory))]
        New = 2,
        [LocalizedDescription(nameof(ResCategory.Used), typeof(ResCategory))]
        Used = 3
    }
}