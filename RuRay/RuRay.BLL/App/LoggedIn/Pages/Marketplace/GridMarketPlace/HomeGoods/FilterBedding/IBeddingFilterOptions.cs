namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBeddingFilterOptions" />.
    /// </summary>
    public interface IBeddingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBedSize<BedSize>
    {
    }
}
