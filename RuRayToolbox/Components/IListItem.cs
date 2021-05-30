namespace RuRayToolbox.Components
{
    public interface IListItem
    {
        int XIndex { get; set; }
        int YIndex { get; set; }
        void RunConformance();
    }
}
