﻿using RobotizeLibrary.CustomAttributes;
using RobotizeLibrary.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader
{
    public enum PostBackgroundcolor
    {
        [LocalizedDescription(nameof(ResPostBackGroundColor.Nobackground), typeof(ResPostBackGroundColor))]
        Nobackground =1,
        [LocalizedDescription(nameof(ResPostBackGroundColor.CloseupChevronKnit), typeof(ResPostBackGroundColor))]
        CloseupChevronKnit = 2,
        [LocalizedDescription(nameof(ResPostBackGroundColor.BlueMountains), typeof(ResPostBackGroundColor))]
        BlueMountains = 3,
        [LocalizedDescription(nameof(ResPostBackGroundColor.CloseupKnitFabric), typeof(ResPostBackGroundColor))]
        CloseupKnitFabric = 4,
        [LocalizedDescription(nameof(ResPostBackGroundColor.FamilyWearingSkisSitting), typeof(ResPostBackGroundColor))]
        FamilyWearingSkisSitting = 5,
        [LocalizedDescription(nameof(ResPostBackGroundColor.SnowCappedMountains), typeof(ResPostBackGroundColor))]
        SnowCappedMountains = 6,
        [LocalizedDescription(nameof(ResPostBackGroundColor.PeoplePlayingAndSkiing), typeof(ResPostBackGroundColor))]
        PeoplePlayingAndSkiing = 7,
        [LocalizedDescription(nameof(ResPostBackGroundColor.SolidOrange), typeof(ResPostBackGroundColor))]
        SolidOrange = 6,
        [LocalizedDescription(nameof(ResPostBackGroundColor.SolidRed), typeof(ResPostBackGroundColor))]
        SolidRed = 7,
    }
}
