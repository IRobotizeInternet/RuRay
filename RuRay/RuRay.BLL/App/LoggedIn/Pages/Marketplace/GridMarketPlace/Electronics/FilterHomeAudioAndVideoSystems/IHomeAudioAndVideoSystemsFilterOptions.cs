namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IHomeAudioAndVideoSystemsFilterOptions" />.
    /// </summary>
    public interface IHomeAudioAndVideoSystemsFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandHomeAudioAndVideoSystems>
    {
    }
}
