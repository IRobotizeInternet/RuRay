using RobotizeLibrary.CustomAttributes;
using RobotizeLibrary.Resources;

namespace RobotizeLibrary.Controls.Grid
{
    public enum VehicleInteriorExteriorColor
    {
        [LocalizedDescription(nameof(ResCategory.Black), typeof(ResCategory))]
        Black = 1,
        [LocalizedDescription(nameof(ResCategory.Charcoal), typeof(ResCategory))]
        Charcoal = 2,
        [LocalizedDescription(nameof(ResCategory.Grey), typeof(ResCategory))]
        Grey = 3,
        [LocalizedDescription(nameof(ResCategory.Silver), typeof(ResCategory))]
        Silver = 4,
        [LocalizedDescription(nameof(ResCategory.White), typeof(ResCategory))]
        White = 5,
        [LocalizedDescription(nameof(ResCategory.OffWhite), typeof(ResCategory))]
        OffWhite = 6,
        [LocalizedDescription(nameof(ResCategory.Tan), typeof(ResCategory))]
        Tan = 7,
        [LocalizedDescription(nameof(ResCategory.Beige), typeof(ResCategory))]
        Beige = 8,
        [LocalizedDescription(nameof(ResCategory.Yellow), typeof(ResCategory))]
        Yellow = 9,
        [LocalizedDescription(nameof(ResCategory.Gold), typeof(ResCategory))]
        Gold = 10,
        [LocalizedDescription(nameof(ResCategory.Brown), typeof(ResCategory))]
        Brown = 11,
        [LocalizedDescription(nameof(ResCategory.Orange), typeof(ResCategory))]
        Orange = 12,
        [LocalizedDescription(nameof(ResCategory.Red), typeof(ResCategory))]
        Red = 13,
        [LocalizedDescription(nameof(ResCategory.Burgundy), typeof(ResCategory))]
        Burgundy = 14,
        [LocalizedDescription(nameof(ResCategory.Pink), typeof(ResCategory))]
        Pink = 15,
        [LocalizedDescription(nameof(ResCategory.Purple), typeof(ResCategory))]
        Purple = 16,
        [LocalizedDescription(nameof(ResCategory.Turquoise), typeof(ResCategory))]
        Turquoise = 17,
        [LocalizedDescription(nameof(ResCategory.Green), typeof(ResCategory))]
        Green = 18,
        [LocalizedDescription(nameof(ResCategory.Other), typeof(ResCategory))]
        Other = 19
    }
}