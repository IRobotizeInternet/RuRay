namespace RobotizeToolbox.Components
{
    public interface IListItem
    {
        int Index { get; set; }
        void RunConformance();
    }
}
