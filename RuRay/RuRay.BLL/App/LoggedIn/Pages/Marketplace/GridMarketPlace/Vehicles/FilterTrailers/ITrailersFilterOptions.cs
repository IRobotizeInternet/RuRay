namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="ITrailersFilterOptions" />.
    /// </summary>
    public interface ITrailersFilterOptions :
        IFilterOptions,
        IVehicleSort,
        IPrice,
        IYear,
        IVehicleExteriorColor,
        IVehicleInteriorColor
    {
    }
}
