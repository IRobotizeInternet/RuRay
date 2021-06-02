using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the RentalType.
    /// </summary>
    public enum RentalType
    {
        /// <summary>
        /// Defines the Apartment_Condo.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.ApartmentCondo), typeof(ResCategory))]
        Apartment_Condo = 0,

        /// <summary>
        /// Defines the House.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.House), typeof(ResCategory))]
        House = 1,

        /// <summary>
        /// Defines the RoomOnly.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.RoomOnly), typeof(ResCategory))]
        RoomOnly = 2,

        /// <summary>
        /// Defines the Townhouse.
        /// </summary>
        [LocalizedDescription(nameof(ResCategory.Townhouse), typeof(ResCategory))]
        Townhouse = 3,
    }
}
