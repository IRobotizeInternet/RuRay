using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemContactGroupConversation" />.
    /// </summary>
    public class ListItemContactGroupConversation : BaseDiv, IListItem
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
        /// Gets the LabelGroupName.
        /// </summary>
        public Label LabelGroupName => new Label(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//span[text()]"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemContactGroupConversation"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="xIndex">The xIndex<see cref="int"/>.</param>
        /// <param name="yIndex">The yIndex<see cref="int"/>.</param>
        public ListItemContactGroupConversation(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='RightRail']/div[3]//ul/li";
            XIndex = xIndex;
            YIndex = yIndex;
        }
    }
}
