using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemButton" />.
    /// </summary>
    public class ListItemButton : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the LabelActivity.
        /// </summary>
        public Label LabelActivity => new Label(Driver, By.XPath($"{BaseXPath}[{XIndex}]"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemButton"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemButton(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
