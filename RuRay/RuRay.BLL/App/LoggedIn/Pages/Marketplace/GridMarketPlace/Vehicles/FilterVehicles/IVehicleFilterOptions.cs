namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IVehicleFilterOptions" />.
    /// </summary>
    public interface IVehicleFilterOptions :
        IVehicleSort,
        IPrice,
        IVehicleType,
        IYear,
        IVehicleMake,
        IVehicleModel,
        IVehicleBodyStyle,
        IMileage,
        IVehicleExteriorColor,
        IVehicleInteriorColor,
        IVehicleTransmissionType
    {
    }
}
