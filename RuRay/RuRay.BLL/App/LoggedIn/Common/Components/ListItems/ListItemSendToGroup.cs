using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemSendToGroup" />.
    /// </summary>
    public class ListItemSendToGroup : BaseDiv, IListItem
    {
        /// <summary>
        /// The LabelFriendName.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Label"/>.</returns>
        public Label LabelFriendName(int index) =>
            new Label(Driver, By.XPath(string.Format(BaseXPath, index)));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemSendToGroup"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemSendToGroup(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath ?? $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]//" + "ul[{0}]";
        }
    }
}
