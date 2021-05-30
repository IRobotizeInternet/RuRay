
namespace RuRayFacebook.App.LoggedIn
{
    public interface IApartmentsForRentFilterOptions : 
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
