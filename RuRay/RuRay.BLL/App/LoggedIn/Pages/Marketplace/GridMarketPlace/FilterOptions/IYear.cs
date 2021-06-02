namespace RuRayFacebook.App.LoggedIn
{
    public interface IYear : IFilterOptions
    {
        IApplyFilter Year(int? min, int? max);
    }
}
