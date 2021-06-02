namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IStorageAndOrganizationFilterOptions" />.
    /// </summary>
    public interface IStorageAndOrganizationFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
