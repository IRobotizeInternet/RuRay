using RuRay.BLL.Resources;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemCallPeopleToJoin" />.
    /// </summary>
    public class ListItemCallPeopleToJoin : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemCallPeopleToJoin"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="xIndex">The xIndex<see cref="int"/>.</param>
        /// <param name="yIndex">The yIndex<see cref="int"/>.</param>
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
