using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogAddVideos" />.
    /// </summary>
    public partial class DialogAddVideos : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogAddVideos"/> class.
        /// </summary>
        public DialogAddVideos()
        {
        }

        /// <summary>
        /// Gets the ScrollVideos.
        /// </summary>
        public ScrollControl<ListItemAddVideo> ScrollVideos =>
            new ScrollControl<ListItemAddVideo>(Driver, $"//form//div[descendant::input[@aria-label='{ResCreatePost.SearchForVideos}']]/following-sibling::div[2]/div/div");

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.AddVideos}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
