using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemContact" />.
    /// </summary>
    public class ListItemContact : BaseDiv, IListItem
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
        /// Gets the LabelUserName.
        /// </summary>
        public Label LabelUserName => new Label(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//span[text()]"));

        /// <summary>
        /// Gets the ButtonHoverOver.
        /// </summary>
        public Button ButtonHoverOver => new Button(Driver, By.XPath($"{BaseXPath}/li[{XIndex}]//*[name()='svg']"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemContact"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="xIndex">The xIndex<see cref="int"/>.</param>
        /// <param name="yIndex">The yIndex<see cref="int"/>.</param>
        public ListItemContact(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            BaseXPath = baseXPath ?? "//div[@data-pagelet='RightRail']/div[2]//ul/div/li";
            XIndex = xIndex;
            YIndex = yIndex;
        }
    }
}
