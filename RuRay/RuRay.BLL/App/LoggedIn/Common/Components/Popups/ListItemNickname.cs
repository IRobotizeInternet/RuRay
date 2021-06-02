using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemNickname" />.
    /// </summary>
    public class ListItemNickname : BaseDiv, IListItem
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
        /// Gets the ButtonEdit.
        /// </summary>
        public Button ButtonEdit => new Button(Driver, By.XPath($"{BaseXPath}[{XIndex}]"));

        /// <summary>
        /// Gets the TextBoxNewNickNake.
        /// </summary>
        public TextBox TextBoxNewNickNake => new TextBox(Driver, By.XPath($"{BaseXPath}[{XIndex}]//input"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemNickname"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        public ListItemNickname(string baseXPath)
        {
            BaseXPath = baseXPath ?? $"//div[@aria-label='{ResHomePage.Nicknames}'][@role='dialog']/div[3]/div/div/div/div/div[./div][{XIndex}]";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
