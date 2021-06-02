using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Components.Grid.PropertyRentals.Enum
{
    /// <summary>
    /// Defines the PropertyRentalCategory.
    /// </summary>
    public enum PropertyRentalCategory
    {
        /// <summary>
        /// Defines the ApartmentsForRent.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ApartmentsForRent), typeof(ResCategory))]
        ApartmentsForRent = 1,

        /// <summary>
        /// Defines the CondosForRent.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.CondosForRent), typeof(ResCategory))]
        CondosForRent = 2,

        /// <summary>
        /// Defines the HousesForRent.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.HousesForRent), typeof(ResCategory))]
        HousesForRent = 3,

        /// <summary>
        /// Defines the TownhousesForRent.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TownhousesForRent), typeof(ResCategory))]
        TownhousesForRent = 4
    }

    /// <summary>
    /// Defines the ApartmentsForRentCategory.
    /// </summary>
    public enum ApartmentsForRentCategory
    {
        /// <summary>
        /// Defines the OneBedroomApartments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OneBedroomApartments), typeof(ResCategory))]
        OneBedroomApartments = 1,

        /// <summary>
        /// Defines the TwoBedroomApartments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TwoBedroomApartments), typeof(ResCategory))]
        TwoBedroomApartments = 2,

        /// <summary>
        /// Defines the ThreeBedroomApartments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomApartments), typeof(ResCategory))]
        ThreeBedroomApartments = 3,

        /// <summary>
        /// Defines the FourBedroomApartments.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FourBedroomApartments), typeof(ResCategory))]
        FourBedroomApartments = 4
    }

    /// <summary>
    /// Defines the CondosForRentCategory.
    /// </summary>
    public enum CondosForRentCategory
    {
        /// <summary>
        /// Defines the OneBedroomCondos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OneBedroomCondos), typeof(ResCategory))]
        OneBedroomCondos = 1,

        /// <summary>
        /// Defines the TwoBedroomCondos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TwoBedroomCondos), typeof(ResCategory))]
        TwoBedroomCondos = 2,

        /// <summary>
        /// Defines the ThreeBedroomCondos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomCondos), typeof(ResCategory))]
        ThreeBedroomCondos = 3,

        /// <summary>
        /// Defines the FourBedroomCondos.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FourBedroomCondos), typeof(ResCategory))]
        FourBedroomCondos = 4
    }

    /// <summary>
    /// Defines the HousesForRentCategory.
    /// </summary>
    public enum HousesForRentCategory
    {
        /// <summary>
        /// Defines the OneBedroomHouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OneBedroomHouses), typeof(ResCategory))]
        OneBedroomHouses = 1,

        /// <summary>
        /// Defines the TwoBedroomHouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TwoBedroomHouses), typeof(ResCategory))]
        TwoBedroomHouses = 2,

        /// <summary>
        /// Defines the ThreeBedroomHouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomHouses), typeof(ResCategory))]
        ThreeBedroomHouses = 3,

        /// <summary>
        /// Defines the FourBedroomHouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FourBedroomHouses), typeof(ResCategory))]
        FourBedroomHouses = 4
    }

    /// <summary>
    /// Defines the TownhousesForRentCategory.
    /// </summary>
    public enum TownhousesForRentCategory
    {
        /// <summary>
        /// Defines the OneBedroomTownhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.OneBedroomTownhouses), typeof(ResCategory))]
        OneBedroomTownhouses = 1,

        /// <summary>
        /// Defines the TwoBedroomTownhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.TwoBedroomTownhouses), typeof(ResCategory))]
        TwoBedroomTownhouses = 2,

        /// <summary>
        /// Defines the ThreeBedroomTownhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomTownhouses), typeof(ResCategory))]
        ThreeBedroomTownhouses = 3,

        /// <summary>
        /// Defines the FourBedroomTownhouses.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.FourBedroomTownhouses), typeof(ResCategory))]
        FourBedroomTownhouses = 4
    }
}
