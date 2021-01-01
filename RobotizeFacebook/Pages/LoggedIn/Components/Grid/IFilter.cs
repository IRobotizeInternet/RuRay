namespace RobotizeFacebook.Pages.LoggedIn
{
    public interface IFilter<out TFilterOptions> where TFilterOptions : IFilterOptions
    {
        void ClearFilter();
        TFilterOptions FilterBy { get; }
    }
}
