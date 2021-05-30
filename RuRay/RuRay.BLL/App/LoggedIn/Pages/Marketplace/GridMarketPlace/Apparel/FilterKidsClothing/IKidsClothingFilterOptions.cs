
namespace RuRayFacebook.App.LoggedIn
{
    public interface IKidsClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBrand<BrandKidsClothing>
    {
    }
}
