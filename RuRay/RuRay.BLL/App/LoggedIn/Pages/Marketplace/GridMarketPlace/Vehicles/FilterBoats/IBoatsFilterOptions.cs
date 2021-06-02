namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBoatsFilterOptions" />.
    /// </summary>
    public interface IBoatsFilterOptions :
        IVehicleSort,
        IPrice,
        IYear,
        IVehicleExteriorColor,
        IVehicleInteriorColor
    {
    }
}
