
namespace RuRayFacebook.App.LoggedIn
{
    public interface IBabyClothingFilterOptions :
        IFilterOptions,
        IPrice,
        IItemCondition<ItemCondition>,
        IBabyAndToddlerSize<BabyAndToddlerSize>
    {
    }
}
