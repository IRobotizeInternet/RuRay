namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IViolinsFilterOptions" />.
    /// </summary>
    public interface IViolinsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
