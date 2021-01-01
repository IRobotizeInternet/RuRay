
namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IApartmentsForRentFilterOptions : 
        IFilterOptions,
        ISortBy<PropertyRentalsSortOption>,
        IPrice
    {
    }
}
