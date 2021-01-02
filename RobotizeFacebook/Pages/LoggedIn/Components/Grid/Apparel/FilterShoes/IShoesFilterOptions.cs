
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IShoesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandShoe>
    {
    }
}
