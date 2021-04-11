
namespace RobotizeFacebook.App.LoggedIn
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
