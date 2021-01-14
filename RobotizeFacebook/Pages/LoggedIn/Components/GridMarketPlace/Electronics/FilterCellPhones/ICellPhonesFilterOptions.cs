
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface ICellPhonesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandCamera>,
        INetwork<Network>,
        IProductLine<ProductLine>
    {
    }
}
