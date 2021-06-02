namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IWhiteboardsFilterOptions" />.
    /// </summary>
    public interface IWhiteboardsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
