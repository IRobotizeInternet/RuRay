﻿using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    public enum BedSize
    {
        [LocalizedDescription(nameof(ResBedSize.Full), typeof(ResBedSize))]
        Womens = 0,
        [LocalizedDescription(nameof(ResBedSize.King), typeof(ResBedSize))]
        Mens = 1,
        [LocalizedDescription(nameof(ResBedSize.Queen), typeof(ResBedSize))]
        KidsClothing = 2,
        [LocalizedDescription(nameof(ResBedSize.Twin), typeof(ResBedSize))]
        BabyClothing = 3
    }
}
