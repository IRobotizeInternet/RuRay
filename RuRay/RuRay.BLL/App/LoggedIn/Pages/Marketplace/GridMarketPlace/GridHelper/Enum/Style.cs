using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the StyleDecorStyle.
    /// </summary>
    public enum StyleDecorStyle
    {
        /// <summary>
        /// Defines the Bohemian.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Bohemian), typeof(ResDecorStyle))] Bohemian = 0,

        /// <summary>
        /// Defines the Coastal.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Coastal), typeof(ResDecorStyle))] Coastal = 1,

        /// <summary>
        /// Defines the Contemporary.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Contemporary), typeof(ResDecorStyle))] Contemporary = 2,

        /// <summary>
        /// Defines the CountryAndCottage.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.CountryAndCottage), typeof(ResDecorStyle))] CountryAndCottage = 3,

        /// <summary>
        /// Defines the CraftsmanAndMission.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.CraftsmanAndMission), typeof(ResDecorStyle))] CraftsmanAndMission = 4,

        /// <summary>
        /// Defines the DanishModern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.DanishModern), typeof(ResDecorStyle))] DanishModern = 5,

        /// <summary>
        /// Defines the Farmhouse.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Farmhouse), typeof(ResDecorStyle))] Farmhouse = 6,

        /// <summary>
        /// Defines the FrenchCountry.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.FrenchCountry), typeof(ResDecorStyle))] FrenchCountry = 7,

        /// <summary>
        /// Defines the Glam.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Glam), typeof(ResDecorStyle))] Glam = 8,

        /// <summary>
        /// Defines the Industrial.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Industrial), typeof(ResDecorStyle))] Industrial = 9,

        /// <summary>
        /// Defines the MidCenturyModern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.MidCenturyModern), typeof(ResDecorStyle))] MidCenturyModern = 10,

        /// <summary>
        /// Defines the Modern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Modern), typeof(ResDecorStyle))] Modern = 11,

        /// <summary>
        /// Defines the Rustic.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Rustic), typeof(ResDecorStyle))] Rustic = 12,

        /// <summary>
        /// Defines the Scandinavian.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Scandinavian), typeof(ResDecorStyle))] Scandinavian = 13,

        /// <summary>
        /// Defines the Traditional.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Traditional), typeof(ResDecorStyle))] Traditional = 14,
    }

    /// <summary>
    /// Defines the HomeDecorStyle.
    /// </summary>
    public enum HomeDecorStyle
    {
        /// <summary>
        /// Defines the Bohemian.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Bohemian), typeof(ResDecorStyle))] Bohemian = 0,

        /// <summary>
        /// Defines the Coastal.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Coastal), typeof(ResDecorStyle))] Coastal = 1,

        /// <summary>
        /// Defines the Contemporary.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Contemporary), typeof(ResDecorStyle))] Contemporary = 2,

        /// <summary>
        /// Defines the CountryAndCottage.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.CountryAndCottage), typeof(ResDecorStyle))] CountryAndCottage = 3,

        /// <summary>
        /// Defines the CraftsmanAndMission.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.CraftsmanAndMission), typeof(ResDecorStyle))] CraftsmanAndMission = 4,

        /// <summary>
        /// Defines the DanishModern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.DanishModern), typeof(ResDecorStyle))] DanishModern = 5,

        /// <summary>
        /// Defines the Farmhouse.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Farmhouse), typeof(ResDecorStyle))] Farmhouse = 6,

        /// <summary>
        /// Defines the FrenchCountry.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.FrenchCountry), typeof(ResDecorStyle))] FrenchCountry = 7,

        /// <summary>
        /// Defines the Glam.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Glam), typeof(ResDecorStyle))] Glam = 8,

        /// <summary>
        /// Defines the Industrial.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Industrial), typeof(ResDecorStyle))] Industrial = 9,

        /// <summary>
        /// Defines the MidCenturyModern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.MidCenturyModern), typeof(ResDecorStyle))] MidCenturyModern = 10,

        /// <summary>
        /// Defines the Modern.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Modern), typeof(ResDecorStyle))] Modern = 11,

        /// <summary>
        /// Defines the Rustic.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Rustic), typeof(ResDecorStyle))] Rustic = 12,

        /// <summary>
        /// Defines the Scandinavian.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Scandinavian), typeof(ResDecorStyle))] Scandinavian = 13,

        /// <summary>
        /// Defines the Traditional.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Traditional), typeof(ResDecorStyle))] Traditional = 14,

        /// <summary>
        /// Defines the ArtDeco.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.ArtDeco), typeof(ResDecorStyle))] ArtDeco = 15,

        /// <summary>
        /// Defines the Vintage.
        /// </summary>
        [LocalizedDescription(nameof(ResDecorStyle.Vintage), typeof(ResDecorStyle))] Vintage = 16
    }

    /// <summary>
    /// Defines the Material.
    /// </summary>
    public enum Material
    {
        /// <summary>
        /// Defines the Bohemian.
        /// </summary>
        [LocalizedDescription(nameof(ResMiscellaneous.Wicker), typeof(ResDecorStyle))] Bohemian = 0,
    }
}
