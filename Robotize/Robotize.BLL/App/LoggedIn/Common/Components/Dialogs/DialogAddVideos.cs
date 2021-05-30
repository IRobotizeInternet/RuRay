using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public partial class DialogAddVideos : BaseDialog
    {
        public DialogAddVideos()
        {
        }

        public ScrollControl<ListItemAddVideo> ScrollVideos =>
            new ScrollControl<ListItemAddVideo>(Driver, $"//form//div[descendant::input[@aria-label='{ResCreatePost.SearchForVideos}']]/following-sibling::div[2]/div/div");

        protected override By ByForDialog => By.XPath($"//form[@method='POST']/parent::div[@role='dialog']//span[text()='{ResCreatePost.AddVideos}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}