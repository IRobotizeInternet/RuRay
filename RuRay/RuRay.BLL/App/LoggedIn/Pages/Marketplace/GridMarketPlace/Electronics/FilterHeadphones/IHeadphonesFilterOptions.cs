namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IHeadphonesFilterOptions" />.
    /// </summary>
    public interface IHeadphonesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
