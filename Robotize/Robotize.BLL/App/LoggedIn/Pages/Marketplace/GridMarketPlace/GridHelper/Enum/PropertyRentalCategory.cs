using Robotize.BLL.Resources;
using RobotizeToolbox.CustomAttributes;

namespace RobotizeFacebook.App.LoggedIn.Components.Grid.PropertyRentals.Enum
{
    public enum PropertyRentalCategory
    {
        [LocalizedDescription(nameof(ResCategory.ApartmentsForRent), typeof(ResCategory))]
        ApartmentsForRent = 1,
        [LocalizedDescription(nameof(ResCategory.CondosForRent), typeof(ResCategory))]
        CondosForRent = 2,
        [LocalizedDescription(nameof(ResCategory.HousesForRent), typeof(ResCategory))]
        HousesForRent = 3,
        [LocalizedDescription(nameof(ResCategory.TownhousesForRent), typeof(ResCategory))]
        TownhousesForRent = 4
    }

    public enum ApartmentsForRentCategory
    {
        [LocalizedDescription(nameof(ResCategory.OneBedroomApartments), typeof(ResCategory))]
        OneBedroomApartments = 1,
        [LocalizedDescription(nameof(ResCategory.TwoBedroomApartments), typeof(ResCategory))]
        TwoBedroomApartments = 2,
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomApartments), typeof(ResCategory))]
        ThreeBedroomApartments = 3,
        [LocalizedDescription(nameof(ResCategory.FourBedroomApartments), typeof(ResCategory))]
        FourBedroomApartments = 4
    }

    public enum CondosForRentCategory
    {
        [LocalizedDescription(nameof(ResCategory.OneBedroomCondos), typeof(ResCategory))]
        OneBedroomCondos = 1,
        [LocalizedDescription(nameof(ResCategory.TwoBedroomCondos), typeof(ResCategory))]
        TwoBedroomCondos = 2,
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomCondos), typeof(ResCategory))]
        ThreeBedroomCondos = 3,
        [LocalizedDescription(nameof(ResCategory.FourBedroomCondos), typeof(ResCategory))]
        FourBedroomCondos = 4
    }

    public enum HousesForRentCategory
    {
        [LocalizedDescription(nameof(ResCategory.OneBedroomHouses), typeof(ResCategory))]
        OneBedroomHouses = 1,
        [LocalizedDescription(nameof(ResCategory.TwoBedroomHouses), typeof(ResCategory))]
        TwoBedroomHouses = 2,
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomHouses), typeof(ResCategory))]
        ThreeBedroomHouses = 3,
        [LocalizedDescription(nameof(ResCategory.FourBedroomHouses), typeof(ResCategory))]
        FourBedroomHouses = 4
    }

    public enum TownhousesForRentCategory
    {
        [LocalizedDescription(nameof(ResCategory.OneBedroomTownhouses), typeof(ResCategory))]
        OneBedroomTownhouses = 1,
        [LocalizedDescription(nameof(ResCategory.TwoBedroomTownhouses), typeof(ResCategory))]
        TwoBedroomTownhouses = 2,
        [LocalizedDescription(nameof(ResCategory.ThreeBedroomTownhouses), typeof(ResCategory))]
        ThreeBedroomTownhouses = 3,
        [LocalizedDescription(nameof(ResCategory.FourBedroomTownhouses), typeof(ResCategory))]
        FourBedroomTownhouses = 4
    }
}
