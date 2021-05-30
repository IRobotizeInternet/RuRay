
namespace RuRayFacebook.App.LoggedIn
{
    public interface IHousesForRentFilterOptions :
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
