using RuRay.BLL.Resources;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class ListItemCallPeopleToJoin : BaseDiv, IListItem
    {
        public int XIndex { get; set; }
        public int YIndex { get; set; }

        public ListItemCallPeopleToJoin(
            string baseXPath,
            int xIndex = 1,
            int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
            BaseXPath = baseXPath ?? $"//div[text()='{ResHomePage.SUGGESTED}']/following-sibling::div";
        }
    }
}
