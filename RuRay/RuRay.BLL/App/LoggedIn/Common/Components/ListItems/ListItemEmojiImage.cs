using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemEmojiImage" />.
    /// </summary>
    public class ListItemEmojiImage : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the ButtonRecentlyUsedEmoji.
        /// </summary>
        public Button ButtonRecentlyUsedEmoji =>
            new Button(Driver, By.XPath($"//div[@class='uiScrollableAreaContent']/div/div/div/h3[text()='{ResHomePage.RecentlyUsed}']/following-sibling::div/div/span[{XIndex}]"));

        /// <summary>
        /// Gets the ButtonRecentlySmileysAndPeople.
        /// </summary>
        public Button ButtonRecentlySmileysAndPeople =>
           new Button(Driver, By.XPath($"//div[@class='uiScrollableAreaContent']/div/div/div/h3[text()='{ResHomePage.SmileysAndPeople}']/following-sibling::div/div[{XIndex}]//span[{YIndex}]"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemEmojiImage"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="xIndex">The xIndex<see cref="int"/>.</param>
        /// <param name="yIndex">The yIndex<see cref="int"/>.</param>
        public ListItemEmojiImage(
            string baseXPath,
            int xIndex = 1,
            int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
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
