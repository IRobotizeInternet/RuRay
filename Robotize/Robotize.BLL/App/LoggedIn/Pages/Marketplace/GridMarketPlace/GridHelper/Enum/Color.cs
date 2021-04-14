using RobotizeToolbox.CustomAttributes;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum ColorVehicleInteriorExterior
    {
        [LocalizedDescription(nameof(ResColor.Black), typeof(ResColor))]
        Black = 1,
        [LocalizedDescription(nameof(ResColor.Charcoal), typeof(ResColor))]
        Charcoal = 2,
        [LocalizedDescription(nameof(ResColor.Grey), typeof(ResColor))]
        Grey = 3,
        [LocalizedDescription(nameof(ResColor.Silver), typeof(ResColor))]
        Silver = 4,
        [LocalizedDescription(nameof(ResColor.White), typeof(ResColor))]
        White = 5,
        [LocalizedDescription(nameof(ResColor.OffWhite), typeof(ResColor))]
        OffWhite = 6,
        [LocalizedDescription(nameof(ResColor.Tan), typeof(ResColor))]
        Tan = 7,
        [LocalizedDescription(nameof(ResColor.Beige), typeof(ResColor))]
        Beige = 8,
        [LocalizedDescription(nameof(ResColor.Yellow), typeof(ResColor))]
        Yellow = 9,
        [LocalizedDescription(nameof(ResColor.Gold), typeof(ResColor))]
        Gold = 10,
        [LocalizedDescription(nameof(ResColor.Brown), typeof(ResColor))]
        Brown = 11,
        [LocalizedDescription(nameof(ResColor.Orange), typeof(ResColor))]
        Orange = 12,
        [LocalizedDescription(nameof(ResColor.Red), typeof(ResColor))]
        Red = 13,
        [LocalizedDescription(nameof(ResColor.Burgundy), typeof(ResColor))]
        Burgundy = 14,
        [LocalizedDescription(nameof(ResColor.Pink), typeof(ResColor))]
        Pink = 15,
        [LocalizedDescription(nameof(ResColor.Purple), typeof(ResColor))]
        Purple = 16,
        [LocalizedDescription(nameof(ResColor.Turquoise), typeof(ResColor))]
        Turquoise = 17,
        [LocalizedDescription(nameof(ResColor.Green), typeof(ResColor))]
        Green = 18,
        [LocalizedDescription(nameof(ResColor.Other), typeof(ResColor))]
        Other = 19
    }

    public enum ColorWomenApparel
    {
        [LocalizedDescription(nameof(ResColor.Beige), typeof(ResColor))]
        Beige = 1,
        [LocalizedDescription(nameof(ResColor.Black), typeof(ResColor))]
        Black = 2,
        [LocalizedDescription(nameof(ResColor.Brown), typeof(ResColor))]
        Brown = 3,
        [LocalizedDescription(nameof(ResColor.Gold), typeof(ResColor))]
        Gold = 4,
        [LocalizedDescription(nameof(ResColor.Gray), typeof(ResColor))]
        Gray = 5,
        [LocalizedDescription(nameof(ResColor.Green), typeof(ResColor))]
        Green = 6,
        [LocalizedDescription(nameof(ResColor.MultiColor), typeof(ResColor))]
        MultiColor = 7,
        [LocalizedDescription(nameof(ResColor.Orange), typeof(ResColor))]
        Orange = 8,
        [LocalizedDescription(nameof(ResColor.Pink), typeof(ResColor))]
        Pink = 9,
        [LocalizedDescription(nameof(ResColor.Purple), typeof(ResColor))]
        Purple = 10
    }
}