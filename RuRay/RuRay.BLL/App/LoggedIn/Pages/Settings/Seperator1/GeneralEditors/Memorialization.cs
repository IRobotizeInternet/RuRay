using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayFacebook.App.NotLoggedIn.Help;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="Memorialization" />.
    /// </summary>
    public class Memorialization : BaseEditor
    {
        /// <summary>
        /// Gets the ComboboxChooseAFriend.
        /// </summary>
        public ComboboxSharingWithYourFriends ComboboxChooseAFriend =>
            new ComboboxSharingWithYourFriends(Driver, string.Empty);

        /// <summary>
        /// Gets the ButtonAdd.
        /// </summary>
        public Button ButtonAdd => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Add}]"));

        /// <summary>
        /// Gets the Link.
        /// </summary>
        public Hyperlink<DialogDeleteYourAccountInFuture> Link =>
            new Hyperlink<DialogDeleteYourAccountInFuture>(Driver, By.XPath($"//input[@value={ResMiscellaneous.RequestThatYourAccountBeDeletedAfterYouPassAway}]"));
    }

    /// <summary>
    /// Defines the <see cref="DialogDeleteYourAccountInFuture" />.
    /// </summary>
    public class DialogDeleteYourAccountInFuture : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogDeleteYourAccountInFuture"/> class.
        /// </summary>
        public DialogDeleteYourAccountInFuture()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div/h3[text()={ResMiscellaneous.DeleteYourAccountInTheFuture}]");

        /// <summary>
        /// Gets the ButtonDeleteAfterDeath.
        /// </summary>
        public Button ButtonDeleteAfterDeath => new Button(Driver, By.XPath("//button[text()='Delete After Death']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath("//a[text()='Cancel']"));

        /// <summary>
        /// Gets the LinkLearnMore.
        /// </summary>
        public Hyperlink<PageHelpChooseALegacyContact> LinkLearnMore =>
            new Hyperlink<PageHelpChooseALegacyContact>(Driver, By.XPath("//div[@role='dialog']//a[text()='Learn More']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
