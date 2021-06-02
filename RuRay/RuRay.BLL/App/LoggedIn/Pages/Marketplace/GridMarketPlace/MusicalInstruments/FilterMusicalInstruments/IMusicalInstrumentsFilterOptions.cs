namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IMusicalInstrumentsFilterOptions" />.
    /// </summary>
    public interface IMusicalInstrumentsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
