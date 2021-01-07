
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IBeddingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBedSize<BedSize>
    {
    }
}
