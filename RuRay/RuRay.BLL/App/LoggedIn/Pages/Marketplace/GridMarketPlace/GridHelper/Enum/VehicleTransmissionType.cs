﻿using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    public enum VehicleTransmissionType
    {
        [LocalizedDescription(nameof(ResCategory.All), typeof(ResCategory))]
        All = 1,
        [LocalizedDescription(nameof(ResCategory.Automatic), typeof(ResCategory))]
        Automatic = 2,
        [LocalizedDescription(nameof(ResCategory.Manual), typeof(ResCategory))]
        Manual = 3
    }
}