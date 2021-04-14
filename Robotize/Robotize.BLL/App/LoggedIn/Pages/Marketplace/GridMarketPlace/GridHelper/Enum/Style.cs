using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn
{
    public enum StyleDecorStyle
    {
        [LocalizedDescription(nameof(ResDecorStyle.Bohemian), typeof(ResDecorStyle))] Bohemian = 0,
        [LocalizedDescription(nameof(ResDecorStyle.Coastal), typeof(ResDecorStyle))] Coastal = 1,
        [LocalizedDescription(nameof(ResDecorStyle.Contemporary), typeof(ResDecorStyle))] Contemporary = 2,
        [LocalizedDescription(nameof(ResDecorStyle.CountryAndCottage), typeof(ResDecorStyle))] CountryAndCottage = 3,
        [LocalizedDescription(nameof(ResDecorStyle.CraftsmanAndMission), typeof(ResDecorStyle))] CraftsmanAndMission = 4,
        [LocalizedDescription(nameof(ResDecorStyle.DanishModern), typeof(ResDecorStyle))] DanishModern = 5,
        [LocalizedDescription(nameof(ResDecorStyle.Farmhouse), typeof(ResDecorStyle))] Farmhouse = 6,
        [LocalizedDescription(nameof(ResDecorStyle.FrenchCountry), typeof(ResDecorStyle))] FrenchCountry = 7,
        [LocalizedDescription(nameof(ResDecorStyle.Glam), typeof(ResDecorStyle))] Glam = 8,
        [LocalizedDescription(nameof(ResDecorStyle.Industrial), typeof(ResDecorStyle))] Industrial = 9,
        [LocalizedDescription(nameof(ResDecorStyle.MidCenturyModern), typeof(ResDecorStyle))] MidCenturyModern = 10,
        [LocalizedDescription(nameof(ResDecorStyle.Modern), typeof(ResDecorStyle))] Modern = 11,
        [LocalizedDescription(nameof(ResDecorStyle.Rustic), typeof(ResDecorStyle))] Rustic = 12,
        [LocalizedDescription(nameof(ResDecorStyle.Scandinavian), typeof(ResDecorStyle))] Scandinavian = 13,
        [LocalizedDescription(nameof(ResDecorStyle.Traditional), typeof(ResDecorStyle))] Traditional = 14,
    }

    public enum HomeDecorStyle
    {
        [LocalizedDescription(nameof(ResDecorStyle.Bohemian), typeof(ResDecorStyle))] Bohemian = 0,
        [LocalizedDescription(nameof(ResDecorStyle.Coastal), typeof(ResDecorStyle))] Coastal = 1,
        [LocalizedDescription(nameof(ResDecorStyle.Contemporary), typeof(ResDecorStyle))] Contemporary = 2,
        [LocalizedDescription(nameof(ResDecorStyle.CountryAndCottage), typeof(ResDecorStyle))] CountryAndCottage = 3,
        [LocalizedDescription(nameof(ResDecorStyle.CraftsmanAndMission), typeof(ResDecorStyle))] CraftsmanAndMission = 4,
        [LocalizedDescription(nameof(ResDecorStyle.DanishModern), typeof(ResDecorStyle))] DanishModern = 5,
        [LocalizedDescription(nameof(ResDecorStyle.Farmhouse), typeof(ResDecorStyle))] Farmhouse = 6,
        [LocalizedDescription(nameof(ResDecorStyle.FrenchCountry), typeof(ResDecorStyle))] FrenchCountry = 7,
        [LocalizedDescription(nameof(ResDecorStyle.Glam), typeof(ResDecorStyle))] Glam = 8,
        [LocalizedDescription(nameof(ResDecorStyle.Industrial), typeof(ResDecorStyle))] Industrial = 9,
        [LocalizedDescription(nameof(ResDecorStyle.MidCenturyModern), typeof(ResDecorStyle))] MidCenturyModern = 10,
        [LocalizedDescription(nameof(ResDecorStyle.Modern), typeof(ResDecorStyle))] Modern = 11,
        [LocalizedDescription(nameof(ResDecorStyle.Rustic), typeof(ResDecorStyle))] Rustic = 12,
        [LocalizedDescription(nameof(ResDecorStyle.Scandinavian), typeof(ResDecorStyle))] Scandinavian = 13,
        [LocalizedDescription(nameof(ResDecorStyle.Traditional), typeof(ResDecorStyle))] Traditional = 14,
        [LocalizedDescription(nameof(ResDecorStyle.ArtDeco), typeof(ResDecorStyle))] ArtDeco = 15,
        [LocalizedDescription(nameof(ResDecorStyle.Vintage), typeof(ResDecorStyle))] Vintage = 16
    }

    public enum Material
    {
        [LocalizedDescription(nameof(ResMiscellaneous.Wicker), typeof(ResDecorStyle))] Bohemian = 0,
    }
}
