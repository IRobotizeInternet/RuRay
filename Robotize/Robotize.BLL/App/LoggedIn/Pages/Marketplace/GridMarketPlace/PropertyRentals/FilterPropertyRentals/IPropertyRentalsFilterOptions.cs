
namespace RuRayFacebook.App.LoggedIn
{
    public interface IPropertyRentalsFilterOptions : 
        IFilterOptions,
        ISortBy<VehicleSortOption>,
        IPrice,
        IBedroomsCount<BathroomCount>,
        IBathroomsCount<BathroomCount>,
        IRentalType<RentalType>
    {
    }
}
