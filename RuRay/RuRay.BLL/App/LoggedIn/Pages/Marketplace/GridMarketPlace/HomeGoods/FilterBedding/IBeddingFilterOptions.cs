
namespace RuRayFacebook.App.LoggedIn
{
    public interface IBeddingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBedSize<BedSize>
    {
    }
}
