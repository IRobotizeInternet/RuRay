using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSelectAudience" />.
    /// </summary>
    public class DialogSelectAudience : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSelectAudience"/> class.
        /// </summary>
        public DialogSelectAudience()
        {
            BaseXPath = $"//form[@method='POST']//div[./div/div/h2/span/span[text()='{ResSelectPrivacy.SelectAudience}']]";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//form[@method='POST']//span[text()='{ResSelectPrivacy.SelectAudience}']");

        /// <summary>
        /// Gets the RButtonAddToYourPost.
        /// </summary>
        public RadioButton RButtonAddToYourPost => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Public}']"));

        /// <summary>
        /// Gets the RButtonFriends.
        /// </summary>
        public RadioButton RButtonFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Friends}']"));

        /// <summary>
        /// Gets the ButtonFriendsExcept.
        /// </summary>
        public EventTriggerButton<DialogFriendsExcepts> ButtonFriendsExcept =>
            new EventTriggerButton<DialogFriendsExcepts>(
                Driver,
                By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.FriendsExcept}']/following::span[contains(text(), '{ResSelectPrivacy.Friends_}')]"));

        /// <summary>
        /// Gets the ButtonSpecificFriends.
        /// </summary>
        public EventTriggerButton<DialogSpecificFriends> ButtonSpecificFriends =>
            new EventTriggerButton<DialogSpecificFriends>(Driver, By.XPath($"{BaseXPath}//span[@dir='auto' and text()='{ResSelectPrivacy.SpecificFriends}']"));

        /// <summary>
        /// Gets the RButtonOnlyMe.
        /// </summary>
        public RadioButton RButtonOnlyMe => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.OnlyMe}']"));

        /// <summary>
        /// Gets the ButtonCustom.
        /// </summary>
        public EventTriggerButton<DialogCustomPrivacy> ButtonCustom =>
            new EventTriggerButton<DialogCustomPrivacy>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Custom}']"));

        /// <summary>
        /// Gets the RButtonCloseFriends.
        /// </summary>
        public RadioButton RButtonCloseFriends => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.CloseFriends}']"));

        /// <summary>
        /// Gets the RButtonCanada.
        /// </summary>
        public RadioButton RButtonCanada => new RadioButton(Driver, By.XPath($"{BaseXPath}//span[text()='{ResSelectPrivacy.Canada}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
