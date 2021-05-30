
namespace RuRayFacebook.App.LoggedIn
{
    public interface IShoesFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandShoe>
    {
    }
}
