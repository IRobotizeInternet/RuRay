namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IRVCampersFilterOptions" />.
    /// </summary>
    public interface IRVCampersFilterOptions :
        IFilterOptions,
        IVehicleSort,
        IPrice,
        IYear,
        IVehicleExteriorColor,
        IVehicleInteriorColor
    {
    }
}
