namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ITrucksFilterOptions" />.
    /// </summary>
    public interface ITrucksFilterOptions :
        IFilterOptions,
        IVehicleSort,
        IVehicleType,
        IPrice,
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
