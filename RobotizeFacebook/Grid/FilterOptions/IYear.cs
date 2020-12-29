namespace RobotizeFacebook.Grid
{
    public interface IYear: IFilterOptions
    {
        IApplyFilter Year(int? min, int? max);
    }
}
