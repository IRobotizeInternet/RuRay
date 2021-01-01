namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IYear: IFilterOptions
    {
        IApplyFilter Year(int? min, int? max);
    }
}
