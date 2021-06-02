using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemAddVideo" />.
    /// </summary>
    public class ListItemAddVideo : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the LabelMovieTitle.
        /// </summary>
        public Label LabelMovieTitle =>
            new Label(Driver, By.XPath($"{BaseXPath}//img/parent::div/following-sibling::div/div/span/span"));

        /// <summary>
        /// Gets the LabelMovieViews.
        /// </summary>
        public Label LabelMovieViews =>
            new Label(Driver, By.XPath($"{BaseXPath}//img/parent::div/following-sibling::div/span"));

        /// <summary>
        /// Gets the CheckboxSelectThisCheckbox.
        /// </summary>
        public Checkbox CheckboxSelectThisCheckbox =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResCreatePost.SelectThisCheckbox}']"));

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemAddVideo"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="index">The index<see cref="int"/>.</param>
        public ListItemAddVideo(string baseXPath, int index = 1)
        {
            XIndex = index;
            BaseXPath = baseXPath;
        }
    }
}
