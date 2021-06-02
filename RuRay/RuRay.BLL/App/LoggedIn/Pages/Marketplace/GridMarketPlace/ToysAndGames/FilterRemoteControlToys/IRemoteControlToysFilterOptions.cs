namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IRemoteControlToysFilterOptions" />.
    /// </summary>
    public interface IRemoteControlToysFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandRemoteControlToys>
    {
    }
}
