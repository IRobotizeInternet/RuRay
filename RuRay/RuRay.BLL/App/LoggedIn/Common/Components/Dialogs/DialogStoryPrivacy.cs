using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogStoryPrivacy" />.
    /// </summary>
    public class DialogStoryPrivacy : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogStoryPrivacy"/> class.
        /// </summary>
        public DialogStoryPrivacy()
        {
            BaseXPath = $"//div[@aria-label='{ResMiscellaneous.StoryPrivacy}']";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResMiscellaneous.StoryPrivacy}']");

        /// <summary>
        /// Gets the RButtonPublic.
        /// </summary>
        public RadioButton RButtonPublic =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Public}')]] "));

        /// <summary>
        /// Gets the RButtonFriends.
        /// </summary>
        public RadioButton RButtonFriends =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Friends}')]] "));

        /// <summary>
        /// Gets the RButtonCustom.
        /// </summary>
        public RadioButton RButtonCustom =>
            new RadioButton(Driver, By.XPath($"{BaseXPath}//div[@role='radio' and .//span[contains(text(), '{ResCreatePost.Custom}')]] "));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
