using OpenQA.Selenium;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemActivity" />.
    /// </summary>
    public class ListItemActivity : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the EventTriggerButtonMenu.
        /// </summary>
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu => new EventTriggerButton<DialogMenu>(Driver, By.XPath(""));

        /// <summary>
        /// Gets the LabelActivity.
        /// </summary>
        public Label LabelActivity => new Label(Driver, By.XPath($"{BaseXPath}"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemActivity"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemActivity(string baseXPath, int index = 1)
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
        public int YIndex { get; set; }
    }
}
