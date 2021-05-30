
namespace RuRayFacebook.App.LoggedIn
{
    public interface ITownhousesForRentFilterOptions :
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
