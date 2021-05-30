namespace RuRayFacebook.App.LoggedIn
{
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
