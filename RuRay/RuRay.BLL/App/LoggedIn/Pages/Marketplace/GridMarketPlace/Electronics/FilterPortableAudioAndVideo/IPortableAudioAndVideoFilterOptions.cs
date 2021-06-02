namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IPortableAudioAndVideoFilterOptions" />.
    /// </summary>
    public interface IPortableAudioAndVideoFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>
    {
    }
}
